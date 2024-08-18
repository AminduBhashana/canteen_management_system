using CanteenManagementSystem.Model;
using System;
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
    public partial class frmTableView : SampleView
    {
        public frmTableView()
        {
            InitializeComponent();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new frmTableAdd());
            //frmTableAdd frm = new frmTableAdd();
            //frm.ShowDialog();
            //GetData();
        }
    }
}
