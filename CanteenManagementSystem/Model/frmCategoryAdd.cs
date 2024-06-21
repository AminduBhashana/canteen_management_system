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

            if (id == 0) 
            {
                qry = "INSERT INTO category (catName) VALUES (@Name)";
            }
            else 
            {
                qry = "UPDATE category SET catName = @Name WHERE catID = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", nameText.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully.");
                id = 0;
                nameText.Text = "";
                nameText.Focus();
            }
            else
            {
                guna2MessageDialog1.Show("Error saving data.");
            }
        }
    }
}
