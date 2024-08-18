using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CanteenManagementSystem
{
    class MainClass
    {
        public static readonly string con_string = "server=localhost; User ID=root; Password=1234;database=canteen_management_system";
        public static SqlConnection con = new SqlConnection(con_string);


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

        //Method for crud operation sql

        public static int SQl(string qry, Hashtable parameters)
        {
            int rowsAffected = 0;

            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";

            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();

                using (MySqlCommand command = new MySqlCommand(qry, connection))
                {
                    foreach (DictionaryEntry parameter in parameters)
                    {
                        command.Parameters.AddWithValue((string)parameter.Key, parameter.Value);
                    }

                    rowsAffected = command.ExecuteNonQuery();
                }
            }

            return rowsAffected;
        }


        //For Loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb, Hashtable parameters)
        {
            gv.CellFormatting += new DataGridViewCellFormattingEventHandler(gv_CellFormatting);

            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(qry, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        foreach (DictionaryEntry parameter in parameters)
                        {
                            cmd.Parameters.AddWithValue((string)parameter.Key, parameter.Value);
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            for (int i = 0; i < lb.Items.Count; i++)
                            {
                                string colName = ((DataGridViewColumn)lb.Items[i]).Name;
                                gv.Columns[colName].DataPropertyName = dt.Columns[i].ToString();
                            }

                            gv.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private static void gv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            Guna.UI2.WinForms.Guna2DataGridView gv = (Guna.UI2.WinForms.Guna2DataGridView)sender;
            int count = 0;

            foreach (DataGridViewRow row in gv.Rows)
            {
                count++;
                row.Cells[0].Value = count;

            }
        }

        public static void BlurBackground(Form Model)
        {
            Form Background = new Form();
            using (Model)
            {
                Background.StartPosition = FormStartPosition.Manual;
                Background.FormBorderStyle = FormBorderStyle.None;
                Background.Opacity = 0.5d;
                Background.BackColor = Color.Black;
                Background.Size = frmMain.Instance.Size;
                Background.Location = frmMain.Instance.Location;
                Background.ShowInTaskbar = false;
                Background.Show();
                Model.Owner = Background;
                Model.ShowDialog(Background);
                Background.Dispose();
            }
        }

        //for cb fill

        public static void CBFill(string qry, ComboBox cb)
        {
            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";

           /* using (MySqlConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(qry, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);                   

                        cb.DisplayMember = "name";
                        cb.ValueMember = "id";
                        cb.DataSource = dt;
                        cb.SelectedIndex = -1; // Ensure no item is selected by default
                    }
                }
            }*/
        }

    }
}


