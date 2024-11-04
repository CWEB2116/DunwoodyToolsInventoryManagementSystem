using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

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
    }

}
