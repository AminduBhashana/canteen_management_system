using CanteenManagementSystem.Model;
using CanteenManagementSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //for accessing frm main
        static frmMain _obj;

        public static frmMain Instance
        {
            get { if (_obj == null) { _obj = new frmMain(); } return _obj; }
        }


        public void AddControls(Form form)
        {
            CenterPanel.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            CenterPanel.Controls.Add(form);
            form.Show();

        }  

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            label2.Text = MainClass.USER;
            _obj = this;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            AddControls(new frmHome());
        }

       

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            AddControls(new frmCategoryView());
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            AddControls(new frmProductView());
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            AddControls(new frmStaffView());
        }

        private void tablesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void posButton_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.Show();
        }
    }
}
