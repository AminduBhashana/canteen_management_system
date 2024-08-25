using System;
using System.Collections;
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
    public partial class frmBillList : SampleAdd
    {
        public frmBillList()
        {
            InitializeComponent();
        }

        public int MainID = 0;

        private void frmBillList_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string qry = @"SELECT mainId, tableName, waiterName, orderType, status, total 
               FROM table_main 
               WHERE status <> 'pending'";

            // Create a ListBox to store column names
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);      
            lb.Items.Add(dgvtable);    
            lb.Items.Add(dgvWaiter);  
            lb.Items.Add(dgvType);     
            lb.Items.Add(dgvStatus);  
            lb.Items.Add(dgvTotal);   

            // Define parameters if any (create Hashtable)
            Hashtable parameters = new Hashtable();
            // Example: parameters.Add("@someParameter", value);

            // Use MainClass to load data into the DataGridView
            MainClass.LoadData(qry, guna2DataGridView1, lb, parameters);
        }


        private void guna2DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //for serial no

            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count; 
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {
              
                MainID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                this.Close();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //need to confirm before delete
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from category where catID = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;

                    guna2MessageDialog1.Show("Deleted successfully");

                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
