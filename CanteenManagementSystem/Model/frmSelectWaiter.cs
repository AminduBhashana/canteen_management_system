using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagementSystem.Model
{
    public partial class frmSelectWaiter : Form
    {

        private MySqlConnection con;
        public frmSelectWaiter()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        public String waiterName;

        private void InitializeDatabaseConnection()
        {
            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";
            con = new MySqlConnection(connString);
        }

        private void frmSelectWaiter_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string qry = "SELECT * FROM staff WHERE sRole LIKE 'Other'";
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(qry, con))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            DisplayData(dt);
        }

        private void DisplayData(DataTable dt)
        {
            foreach (DataRow row in dt.Rows)
            {
                Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button
                {
                    Text = row["sName"].ToString(),
                    Width = 150,
                    Height = 50,
                    FillColor = Color.FromArgb(241, 85, 126),
                    HoverState = { FillColor = Color.FromArgb(50, 55, 89) }
                };

                b.Click += new EventHandler(b_Click);
                // Assuming you have a FlowLayoutPanel named flowLayoutPanel1 to hold the buttons
                flowLayoutPanel1.Controls.Add(b);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            waiterName = (sender as Guna.UI2.WinForms.Guna2Button).Text;
            this.Close();
        }
    }
}
