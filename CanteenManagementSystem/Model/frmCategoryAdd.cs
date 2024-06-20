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

namespace CanteenManagementSystem.Model
{
    public partial class frmCategoryAdd : SampleAdd
    {
        public frmCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        public override void saveButton_Click(object sender, EventArgs e)
        {

            string qry = "";

            if (id == 0) //insert
            {
                qry = "insert into category values(@Name)";
            }
            else //update
            {
                qry = "update category Set catName = @Name where catID = @id";

            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", nameText.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully..");
                id = 0;
                nameText.Text = "";
                nameText.Focus();
            }
        }
    }
}
