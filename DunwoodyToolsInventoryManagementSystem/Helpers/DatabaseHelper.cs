using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data;

namespace DunwoodyToolsInventoryManagementSystem.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DCT_Tools;Integrated Security=True;TrustServerCertificate=True";

        public static bool CheckLoginCredentials(string username, string hashedPassword)
        {
            string query = "SELECT COUNT(1) FROM user_tbl WHERE username = @Username AND password = @PasswordHash";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@PasswordHash", hashedPassword);

                connection.Open();
                int userCount = (int)command.ExecuteScalar();

                return userCount > 0;
            }
        }

        public static DataTable GetItems()
        {
            string query = @"
        SELECT 
            i.id,
            i.item_name AS ItemName,
            i.item_description,
            i.item_image,
            s.status_name,
            STRING_AGG(c.category_name, ', ') AS Categories
        FROM 
            item_tbl i
        JOIN 
            status_tbl s ON i.status_id = s.id
        JOIN 
            item_category ic ON i.id = ic.item_id
        JOIN 
            category_tbl c ON ic.category_id = c.id
        GROUP BY 
            i.id, i.item_name, s.status_name, i.item_description, i.item_image
        ORDER BY 
            i.id;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
        }



        public static List<string> GetCategoriesForItem(int itemId)
        {
            List<string> categories = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // SQL query to get category names for the specified item
                string query = @"
            SELECT c.category_name 
            FROM category_tbl c
            INNER JOIN item_category ic ON c.id = ic.category_id
            WHERE ic.item_id = @ItemId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemId", itemId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader["category_name"].ToString());
                        }
                    }
                }
            }
            return categories;
        }


        public static void AddItem(string name, string status, string description, byte[] imageData, List<string> categories)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get or create the StatusID
                int statusId = GetOrCreateStatusId(status, connection);

                // Insert the item and retrieve its ID
                string itemQuery = "INSERT INTO item_tbl (item_name, status_id, item_description, item_image) " +
                                   "VALUES (@Name, @StatusID, @Description, @ImageData); SELECT SCOPE_IDENTITY();";

                int itemId;
                using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                {
                    itemCommand.Parameters.AddWithValue("@Name", name);
                    itemCommand.Parameters.AddWithValue("@StatusID", statusId);
                    itemCommand.Parameters.AddWithValue("@Description", description);
                    itemCommand.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value = (object)imageData ?? DBNull.Value;
                    itemId = Convert.ToInt32(itemCommand.ExecuteScalar());
                }

                // Insert categories for this item in the item_category table
                foreach (var category in categories)
                {
                    int categoryId = GetOrCreateCategoryId(category, connection);
                    string categoryQuery = "INSERT INTO item_category (item_id, category_id) VALUES (@ItemID, @CategoryID)";

                    using (SqlCommand categoryCommand = new SqlCommand(categoryQuery, connection))
                    {
                        categoryCommand.Parameters.AddWithValue("@ItemID", itemId);
                        categoryCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                        categoryCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void UpdateItem(int itemId, string name, string status, string description, byte[] imageData, List<string> categories)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Get or create the StatusID
                int statusId = GetOrCreateStatusId(status, connection);

                // Update item details
                string itemQuery = "UPDATE item_tbl SET item_name = @Name, status_id = @StatusID, item_description = @Description, item_image = @ImageData WHERE id = @ItemID";

                using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                {
                    itemCommand.Parameters.AddWithValue("@ItemID", itemId);
                    itemCommand.Parameters.AddWithValue("@Name", name);
                    itemCommand.Parameters.AddWithValue("@StatusID", statusId);
                    itemCommand.Parameters.AddWithValue("@Description", description);
                    itemCommand.Parameters.Add("@ImageData", SqlDbType.VarBinary).Value = (object)imageData ?? DBNull.Value;
                    itemCommand.ExecuteNonQuery();
                }

                // Delete existing categories for the item
                string deleteCategoriesQuery = "DELETE FROM item_category WHERE item_id = @ItemID";
                using (SqlCommand deleteCommand = new SqlCommand(deleteCategoriesQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ItemID", itemId);
                    deleteCommand.ExecuteNonQuery();
                }

                // Insert updated categories for this item
                foreach (var category in categories)
                {
                    int categoryId = GetOrCreateCategoryId(category, connection);
                    string categoryQuery = "INSERT INTO item_category (item_id, category_id) VALUES (@ItemID, @CategoryID)";

                    using (SqlCommand categoryCommand = new SqlCommand(categoryQuery, connection))
                    {
                        categoryCommand.Parameters.AddWithValue("@ItemID", itemId);
                        categoryCommand.Parameters.AddWithValue("@CategoryID", categoryId);
                        categoryCommand.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void DeleteItem(int itemId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM item_tbl WHERE id = @ItemID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemID", itemId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static DataTable GetItemsWithCategories()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT 
                i.id AS ItemID,
                i.item_name AS ItemName,
                s.status_name AS StatusName,
                i.item_description AS Description,
                i.item_image AS ImageData,
                STRING_AGG(c.category_name, ', ') AS CategoryNames
            FROM 
                item_tbl i
            LEFT JOIN 
                status_tbl s ON i.status_id = s.id
            LEFT JOIN 
                item_category ic ON i.id = ic.item_id
            LEFT JOIN 
                category_tbl c ON ic.category_id = c.id
            GROUP BY 
                i.id, i.item_name, s.status_name, i.item_description, i.item_image";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable itemsTable = new DataTable();
                    adapter.Fill(itemsTable);
                    return itemsTable;
                }
            }
        }

        private static int GetOrCreateStatusId(string statusName, SqlConnection connection)
        {
            if (string.IsNullOrEmpty(statusName))
                throw new ArgumentException("Status name cannot be null or empty.", nameof(statusName));

            // Check if the status exists
            string checkQuery = "SELECT id FROM status_tbl WHERE status_name = @StatusName";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@StatusName", statusName);
                object result = checkCommand.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result); // Return existing StatusID
                }
            }

            // Insert new status and return its ID
            string insertQuery = "INSERT INTO status_tbl (status_name) VALUES (@StatusName); SELECT SCOPE_IDENTITY();";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@StatusName", statusName);
                return Convert.ToInt32(insertCommand.ExecuteScalar());
            }
        }



        private static int GetOrCreateCategoryId(string categoryName, SqlConnection connection)
        {
            string checkQuery = "SELECT id FROM category_tbl WHERE category_name = @CategoryName";
            using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
            {
                checkCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                object result = checkCommand.ExecuteScalar();

                if (result != null)
                {
                    return Convert.ToInt32(result);
                }
            }

            string insertQuery = "INSERT INTO category_tbl (category_name) VALUES (@CategoryName); SELECT SCOPE_IDENTITY();";
            using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@CategoryName", categoryName);
                return Convert.ToInt32(insertCommand.ExecuteScalar());
            }
        }


        public static List<string> GetStatuses()
        {
            List<string> statuses = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT status_name FROM status_tbl";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(reader["status_name"].ToString());
                    }
                }
            }
            return statuses;
        }

        public static DataTable GetStatusesv2()
        {
            string query = "SELECT id, status_name AS StatusName FROM status_tbl ORDER BY status_name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable statusesTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(statusesTable);
                return statusesTable;
            }
        }
        public static DataTable GetCategoriesv2()
        {
            string query = "SELECT id, category_name AS CategoryName FROM category_tbl ORDER BY category_name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable categoriesTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(categoriesTable);
                return categoriesTable;
            }
        }



    }

}
