using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagementSystem.Model
{
    public partial class frmPOS : Form
    {
        public frmPOS()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType = "";

        private void frmPOS_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            AddCategory();
        }


        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
        }



        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        public int id = 0;
        private void btnBillList_Click(object sender, EventArgs e)
        {

            frmBillList frm = new frmBillList();
            MainClass.BlurBackground(frm);

            if (frm.MainID > 0)
            {
                id = frm.MainID;
                MainID = frm.MainID;
                LoadEntries();
            }
        }

        private void AddCategory()
        {
            string qry = "SELECT * FROM category";
            Hashtable parameters = new Hashtable();

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234;database=canteen_management_system"))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(qry, connection))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            categoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(50, 55, 89);
                    b.Size = new Size(197, 59);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["catName"].ToString();
                    categoryPanel.Controls.Add(b);  
                }
            }

        }

        private void LoadEntries()
        {
            string qry = @"Select * from tblMain minner join tblDetails d on m.MainID= d.MainID inner join products p on p.pID= d.proID Where m.MainID = " + id + "";
            SqlCommand cmd2 = new SqlCommand(qry, MainClass.con);
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);

            guna2DataGridView1.Rows.Clear();

            foreach (DataRow item in dt2.Rows)
            {
                string detailid = item["DetailID"].ToString(); 
                string proid = item["proID"].ToString();
                string proName = item["pName"].ToString();
                string qty = item["qty"].ToString();
                string price = item["price"].ToString();
                string amount = item["amount"].ToString();

                object[] obj = { 0, detailid, proid, qty, price, amount }; 
                guna2DataGridView1.Rows.Add(obj);

            }
           // GetTotal();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
           // frm.amt = Convert.ToDouble(lb1Total.Text); 
            MainClass.BlurBackground(frm);

          /*  MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lb1Table.Text = "";
            lb1Waiter.Text = "";
            lb1Table.Visible = false; 
            lb1waiter.Visible = false; 
            lb1Total.Text = "00";*/

        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            frmAddCustomer frm = new frmAddCustomer();
            frm.mainID = MainID;
            frm.orderType = OrderType;
            MainClass.BlurBackground(frm);

            if(frm.txtName.Text != "")
            {

            }
            
        }

        private void categortBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
