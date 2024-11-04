using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunwoodyToolsInventoryManagementSystem.Helpers
{
    internal class FilterHelper
    {
        public static List<string> GetUniqueStatuses()
        {
            List<string> statuses = new List<string>();
            string query = "SELECT DISTINCT status_name FROM status_tbl";  // Adjust table name if necessary

            using (SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DCT_Tools;Integrated Security=True;TrustServerCertificate=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statuses.Add(reader.GetString(0));
                    }
                }
            }

            return statuses;
        }

        public static List<string> GetUniqueCategories()
        {
            List<string> categories = new List<string>();
            string query = "SELECT DISTINCT category_name FROM category_tbl";  // Adjust table name if necessary

            using (SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=DCT_Tools;Integrated Security=True;TrustServerCertificate=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(reader.GetString(0));
                    }
                }
            }

            return categories;
        }

    }
}
