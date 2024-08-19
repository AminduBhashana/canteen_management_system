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
    public partial class frmTableAdd : SampleAdd
    {
        public frmTableAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void saveButton_Click_1(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0)
            {
                qry = "INSERT INTO tables (tName) VALUES (@Name)";
            }
            else
            {
                qry = "UPDATE tables SET tName = @Name WHERE tableId = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", nameText.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                MessageBox.Show("Saved successfully.");
                id = 0;
                nameText.Text = "";
                nameText.Focus();
            }
            else
            {
                MessageBox.Show("Error saving data.");
            }
        }
    }
}
