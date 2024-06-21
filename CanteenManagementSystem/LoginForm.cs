using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CanteenManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = textUser.Text;
            string password = textPass.Text;

            if (MainClass.IsValidUser(username, password))
            {
                MessageBox.Show("Login Successful!");
                Console.WriteLine("success");
                frmMain mainForm = new frmMain();
                mainForm.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                Console.WriteLine("Fail");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
