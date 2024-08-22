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
    public partial class frmCheckout : SampleAdd
    {
        public frmCheckout()
        {
            InitializeComponent();
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
        }

        public double amt;
        public int MainID = 0;

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            double amt = 0;
            double receipt = 0;
            double change = 0;

            double.TryParse(txtBillAmount.Text, out amt);
            double.TryParse(txtReceived.Text, out receipt);

            change = Math.Abs(amt - receipt);

            txtChange.Text = change.ToString();
        }

        public virtual void SaveButton_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrEmpty(txtBillAmount.Text) || string.IsNullOrEmpty(txtReceived.Text) || string.IsNullOrEmpty(txtChange.Text))
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Please fill all fields.");
                return;
            }

            // Proceed with database update if validation passes
            string qry = @"UPDATE table_main 
                   SET total = @total, recieved = @rec, `change` = @change, status = 'Paid' 
                   WHERE mainId = @id";

            Hashtable ht = new Hashtable();
            ht.Add("@id", MainID);
            ht.Add("@total", txtBillAmount.Text);
            ht.Add("@rec", txtReceived.Text);
            ht.Add("@change", txtChange.Text);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Saved Successfully");
                this.Close();
            }
        }


        private void frmCheckout_Load(object sender, EventArgs e)
        {
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            txtBillAmount.Text = amt.ToString();
        }
    }
}