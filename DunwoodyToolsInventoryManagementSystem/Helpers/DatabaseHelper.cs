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
            i.id, i.item_name, s.status_name
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
    }

}
