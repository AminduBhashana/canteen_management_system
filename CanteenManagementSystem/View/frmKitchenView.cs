using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CanteenManagementSystem.View
{
    public partial class frmKitchenView : Form
    {
        public frmKitchenView()
        {
            InitializeComponent();
        }

        private void frmKitchenView_Load(object sender, EventArgs e)
        {
            GetOrders();
        }

        private void GetOrders()
        {
            flowLayoutPanel1.Controls.Clear();

            string qry1 = @"SELECT * FROM table_main WHERE status = 'pending'";
            DataTable dt1 = new DataTable();
            Hashtable parameters = new Hashtable(); // Empty parameters as none are needed for this query

            dt1 = MainClass.ExecuteSelectQuery(qry1, parameters);

            FlowLayoutPanel p1;

            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                p1 = new FlowLayoutPanel
                {
                    AutoSize = true,
                    Width = 230,
                    Height = 350,
                    FlowDirection = FlowDirection.TopDown,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                FlowLayoutPanel p2 = new FlowLayoutPanel
                {
                    BackColor = Color.FromArgb(50, 55, 89),
                    AutoSize = true,
                    Width = 230,
                    Height = 125,
                    FlowDirection = FlowDirection.TopDown,
                    Margin = new Padding(0)
                };

                Label lb1 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 10, 3, 0),
                    AutoSize = true,
                    Text = "Table: " + dt1.Rows[i]["tableName"].ToString()
                };

                Label lb2 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Waiter Name: " + dt1.Rows[i]["waiterName"].ToString()
                };

                Label lb3 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 0),
                    AutoSize = true,
                    Text = "Order Time: " + dt1.Rows[i]["aTime"].ToString()
                };

                Label lb4 = new Label
                {
                    ForeColor = Color.White,
                    Margin = new Padding(10, 5, 3, 10),
                    AutoSize = true,
                    Text = "Order Type: " + dt1.Rows[i]["orderType"].ToString()
                };

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                // Retrieve products related to the current order
                int mid = Convert.ToInt32(dt1.Rows[i]["mainId"].ToString());

                string qry2 = @"SELECT * FROM table_main m
                                INNER JOIN table_details d ON m.mainId = d.mainId 
                                INNER JOIN products p ON p.productId = d.proId
                                WHERE m.mainId = @mainId";
                Hashtable ht = new Hashtable();
                ht.Add("@mainId", mid);

                DataTable dt2 = MainClass.ExecuteSelectQuery(qry2, ht);

                for (int j = 0; j < dt2.Rows.Count; j++)
                {
                    Label lb5 = new Label
                    {
                        ForeColor = Color.White,
                        Margin = new Padding(10, 5, 3, 0),
                        AutoSize = true,
                        Text = $"{j + 1}. {dt2.Rows[j]["productName"].ToString()} - {dt2.Rows[j]["qty"].ToString()}"
                    };

                    p1.Controls.Add(lb5);
                }

                // Add a button to change the order status
                Guna2Button b = new Guna2Button
                {
                    AutoRoundedCorners = true,
                    Size = new Size(100, 35),
                    FillColor = Color.FromArgb(241, 85, 126),
                    Margin = new Padding(30, 5, 3, 10),
                    Text = "Complete",
                    Tag = dt1.Rows[i]["mainId"].ToString() // Store the id
                };

                b.Click += new EventHandler(b_click);
                p1.Controls.Add(b);

                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void b_click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32((sender as Guna2Button).Tag.ToString());

            guna2MessageDialog1.Icon = MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = MessageDialogButtons.YesNo;

            if (guna2MessageDialog1.Show("Are you sure you want to mark this order as complete?") == DialogResult.Yes)
            {
                string qry = @"UPDATE table_main SET status = 'Complete' WHERE mainId = @ID";
                Hashtable ht = new Hashtable();
                ht.Add("@ID", id);

                if (MainClass.SQl(qry, ht) > 0)
                {
                    guna2MessageDialog1.Buttons = MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Order marked as complete successfully.");
                }

                GetOrders(); // Refresh orders
            }
        }
    }
}
