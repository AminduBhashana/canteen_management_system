using CanteenManagementSystem.Model;
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

namespace CanteenManagementSystem.View
{
    public partial class frmProductView : SampleView
    {
        public frmProductView()
        {
            InitializeComponent();
            GetData();
        }

        private void frmProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            string qry = "Select productId, productName, productPrice, categoryId, c.catName from products p inner join category c on c.catId = p.categoryId where productName like @searchText";

            Hashtable parameters = new Hashtable();
            parameters.Add("@searchText", "%" + searchText.Text + "%");

            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvcatID);
            lb.Items.Add(dgvcat);

            MainClass.LoadData(qry, guna2DataGridView1, lb, parameters);
        }


        public override void addButton_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new Model.frmProductAdd());
            /* frmCategoryAdd frm = new frmCategoryAdd();
              frm.ShowDialog();*/
            GetData();
        }


        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }


        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                frmProductAdd frm = new frmProductAdd();
                frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                frm.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvcatID"].Value);

                MainClass.BlurBackground(frm);
                GetData();

            }
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                //need to confirm before delete
                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;

                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string qry = "Delete from products where productId = " + id + "";
                    Hashtable ht = new Hashtable();
                    MainClass.SQl(qry, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;

                    guna2MessageDialog1.Show("Deleted successfully");
                    GetData();
                }
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
