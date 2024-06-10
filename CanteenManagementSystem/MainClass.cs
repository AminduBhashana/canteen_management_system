using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagementSystem
{
    class MainClass
    {
        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                string query = "SELECT * FROM users WHERE username = @username AND upass = @password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {                         
                            USER = reader["username"].ToString(); 
                            isValid = true;
                        }
                    }
                }
            }
            return isValid;
        
        }

        public static string user;

        public static string USER
        {
            get { return user; }
            private set { user = value; }
        }
    }
}
