﻿using CanteenManagementSystem.Model;
using Guna.UI2.WinForms;
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
    public partial class frmCategoryView : SampleView
    {
        public frmCategoryView()
        {
            InitializeComponent();
            GetData();
        }

         public void GetData()
         {
            string qry = "SELECT * FROM category WHERE catName LIKE @searchText";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            Hashtable parameters = new Hashtable();
            parameters.Add("@searchText", "%" + searchText.Text + "%");

            MainClass.LoadData(qry, guna2DataGridView1, lb, parameters);
        }

         private void frmCategoryView_Load(object sender, EventArgs e)
         {
             GetData();
         }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmCategoryAdd());
            /*frmCategoryAdd frm = new frmCategoryAdd();
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

                 frmCategoryAdd frm = new frmCategoryAdd();
                 frm.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                 frm.nameText.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
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
                     string qry = "Delete from category where catID = " + id + "";
                     Hashtable ht = new Hashtable();
                     MainClass.SQl(qry, ht);

                     guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                     guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;

                     guna2MessageDialog1.Show("Deleted successfully");
                     GetData();
                 }
             }
         }

       
    }
}
