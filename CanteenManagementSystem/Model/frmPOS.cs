using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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

            productPanel.Controls.Clear();
            loadProducts();
        }

        public static MySqlConnection GetConnection()
        {
            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";
            return new MySqlConnection(connString);
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
            int count = 0;

            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                count++;
                row.Cells[0].Value = count;

            }
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

                    b.Click += new EventHandler(b_Click);

                    categoryPanel.Controls.Add(b);  
                }
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button b = (Guna.UI2.WinForms.Guna2Button)sender;
            if(b.Text == "All Categories")
            {
                searchText.Text = "1";
                searchText.Text = "";
                return;
            }
            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pCategory.ToLower().Contains(b.Text.Trim().ToLower());
            }
        }

        private void AddItems(string id,String productId, string name, string cat, string price,Image pImage) {
            var w = new ucProduct()
            {
                pName = name,
                pPrice = price,
                pCategory = cat,
                pImage = pImage,
                id = Convert.ToInt32(productId),
            };

            productPanel.Controls.Add(w);

            w.onSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;

                foreach (DataGridViewRow item in guna2DataGridView1.Rows)
                {
                    if (Convert.ToInt32(item.Cells["dgvproID"].Value) == wdg.id)
                    {
                        item.Cells["dgvQty"].Value = int.Parse(item.Cells["dgvQty"].Value.ToString()) + 1;
                        item.Cells["dgvAmount"].Value = (int.Parse(item.Cells["dgvQty"].Value.ToString()) * double.Parse(item.Cells["dgvPrice"].Value.ToString())).ToString("F2");
                        getTotal();
                        return;
                    }
                    
                }
                guna2DataGridView1.Rows.Add(new object[] {0, 0, wdg.id, wdg.pName, 1, wdg.pPrice, wdg.pPrice });
                getTotal();
            };
        }

        private void LoadEntries()
        {
            string qry = @"SELECT * FROM table_main m 
                   INNER JOIN table_details d ON m.mainId = d.mainId 
                   INNER JOIN products p ON p.productId = d.proId 
                   WHERE m.mainId = @id";

            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();  // Open the connection
                using (MySqlCommand cmd2 = new MySqlCommand(qry, connection))
                {
                    cmd2.Parameters.AddWithValue("@id", id); // Using parameterized query to prevent SQL injection

                    using (MySqlDataAdapter da2 = new MySqlDataAdapter(cmd2))
                    {
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);

                        

                        guna2DataGridView1.Rows.Clear();

                        foreach (DataRow item in dt2.Rows)
                        {
                            lblTable.Text = item["tableName"].ToString();
                            lblWaiter.Text = item["waiterName"].ToString();

                            string detailid = item["detailId"].ToString();
                            string proid = item["proId"].ToString();
                            string proName = item["productName"].ToString();
                            string qty = item["qty"].ToString();
                            string price = item["price"].ToString();
                            string amount = item["amount"].ToString();

                            object[] obj = { 0, detailid, proid,proName, qty, price, amount };
                            guna2DataGridView1.Rows.Add(obj);
                        }
                        getTotal();
                    }
                }
            }
        }



        private void loadProducts()
        {
            string qry = "SELECT * FROM products INNER JOIN category on catId = categoryId";
            string connString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";

            DataTable dt = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connString))
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

            foreach (DataRow item in dt.Rows)
            {
                byte[] imagearray = (byte[])item["productImage"];
                Image productImage = Image.FromStream(new MemoryStream(imagearray));

                AddItems(
                    "0",
                    item["productId"].ToString(),
                    item["productName"].ToString(),
                    item["catName"].ToString(),
                    item["productPrice"].ToString(),
                    productImage
                );
            }
        }




        private void btnCheckout_Click(object sender, EventArgs e)
        {
            frmCheckout frm = new frmCheckout();
            frm.MainID = id;
            frm.amt = Convert.ToDouble(totalLabel.Text); 
            MainClass.BlurBackground(frm);

            MainID = 0;
            guna2DataGridView1.Rows.Clear();
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            totalLabel.Text = "00";

        }

        private void getTotal()
        {
            double total = 0;
            totalLabel.Text = "";
            foreach (DataGridViewRow item in guna2DataGridView1.Rows)
            {
                total += double.Parse(item.Cells["dgvAmount"].Value.ToString());
            }
            totalLabel.Text = total.ToString("F2");
        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            OrderType = "Take Away";
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

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pName.ToLower().Contains(searchText.Text.Trim().ToLower());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblTable.Text = "";
            lblWaiter.Text = "";
            lblTable.Visible = false;
            lblWaiter.Visible = false;
            guna2DataGridView1.Rows.Clear();
            MainID = 0;
            totalLabel.Text = "00";
        }

        private void guna2TileButton5_Click(object sender, EventArgs e)
        {
            OrderType = "Din In";
            frmSelectTable frm = new frmSelectTable();
            MainClass.BlurBackground(frm);
            if(frm.TableName != "")
            {
                lblTable.Text = frm.TableName;
                lblTable.Visible = true;
            }
            else
            {
                lblTable.Text = "";
                lblTable.Visible = false;
            }

            frmSelectWaiter frm2 = new frmSelectWaiter();
            MainClass.BlurBackground(frm2);
            if(frm2.waiterName != "")
            {
                lblWaiter.Text = frm2.waiterName;
                lblWaiter.Visible=true;
            }
            else
            {
                lblWaiter.Text = "";
                lblTable.Visible = false;
            }
        }

        private void btnKOT_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";
            int detailId = 0;
            MainID = 0;

            string connectionString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Insert or Update the main order
                    if (MainID == 0)
                    {
                        qry1 = @"INSERT INTO table_main (aDate, aTime, tableName, waiterName, status, orderType, total, recieved, `change`) 
                         VALUES (@aDate, @aTime, @tableName, @waiterName, @status, @orderType, @total, @recieved, @change); 
                         SELECT LAST_INSERT_ID()";
                    }
                    else
                    {
                        qry1 = @"UPDATE table_main 
                         SET status = @status, total = @total, recieved = @recieved, `change` = @change 
                         WHERE MainId = @mainId";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(qry1, con))
                    {
                        cmd.Parameters.AddWithValue("@mainId", MainID);
                        cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
                        cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@tableName", lblTable.Text);
                        cmd.Parameters.AddWithValue("@waiterName", lblWaiter.Text);
                        cmd.Parameters.AddWithValue("@status", "pending");
                        cmd.Parameters.AddWithValue("@orderType", OrderType);
                        cmd.Parameters.AddWithValue("@total", Convert.ToDouble(totalLabel.Text));
                        cmd.Parameters.AddWithValue("@recieved", Convert.ToDouble(0));
                        cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

                        if (MainID == 0)
                        {
                            MainID = Convert.ToInt32(cmd.ExecuteScalar()); // Retrieve the last inserted ID
                        }
                        else
                        {
                            cmd.ExecuteNonQuery(); // Update the existing record
                        }
                    }

                    // Insert or Update order details for each row in DataGridView
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the last empty row

                        // Ensure cells are not null or empty
                        string dgvIdStr = row.Cells["dgvid"].Value?.ToString();
                        string proIdStr = row.Cells["dgvproID"].Value?.ToString();
                        string qtyStr = row.Cells["dgvQty"].Value?.ToString();
                        string priceStr = row.Cells["dgvPrice"].Value?.ToString();
                        string amountStr = row.Cells["dgvAmount"].Value?.ToString();

                        if (string.IsNullOrWhiteSpace(dgvIdStr) || string.IsNullOrWhiteSpace(proIdStr) ||
                            string.IsNullOrWhiteSpace(qtyStr) || string.IsNullOrWhiteSpace(priceStr) || string.IsNullOrWhiteSpace(amountStr))
                        {
                            MessageBox.Show("Some cells are empty. Please fill in all details.");
                            continue;
                        }

                        // Convert values
                        detailId = Convert.ToInt32(dgvIdStr);
                        int proId = Convert.ToInt32(proIdStr);
                        int qty = Convert.ToInt32(qtyStr);
                        double price = Convert.ToDouble(priceStr);
                        double amount = Convert.ToDouble(amountStr);

                        if (detailId == 0)
                        {
                            qry2 = @"INSERT INTO table_details (mainId, proId, qty, price, amount) 
                             VALUES (@mainId, @proId, @qty, @price, @amount)";
                        }
                        else
                        {
                            qry2 = @"UPDATE table_details 
                             SET proId = @proId, qty = @qty, price = @price, amount = @amount 
                             WHERE detailId = @detailId";
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(qry2, con))
                        {
                            cmd2.Parameters.AddWithValue("@detailId", detailId);
                            cmd2.Parameters.AddWithValue("@mainId", MainID);
                            cmd2.Parameters.AddWithValue("@proId", proId);
                            cmd2.Parameters.AddWithValue("@qty", qty);
                            cmd2.Parameters.AddWithValue("@price", price);
                            cmd2.Parameters.AddWithValue("@amount", amount);

                            cmd2.ExecuteNonQuery(); // Insert or update the details record
                        }
                    }

                    // Show success message
                    guna2MessageDialog1.Show("Saved Successfully");

                    // Reset form
                    MainID = 0;
                    detailId = 0;
                    guna2DataGridView1.Rows.Clear();
                    lblTable.Text = "";
                    lblWaiter.Text = "";
                    lblTable.Visible = false;
                    lblWaiter.Visible = false;
                    totalLabel.Text = "00";
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("There was an issue with data formatting: " + fex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Ensure the connection is closed
                }
            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            string qry1 = "";
            string qry2 = "";
            int detailId = 0;
            MainID = 0;

            string connectionString = "server=localhost;uid=root;pwd=1234;database=canteen_management_system";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    if(OrderType == "")
                    {
                        guna2MessageDialog1.Show("Please select order type");
                        return;
                    }

                    // Insert or Update the main order
                    if (MainID == 0)
                    {
                        qry1 = @"INSERT INTO table_main (aDate, aTime, tableName, waiterName, status, orderType, total, recieved, `change`) 
                         VALUES (@aDate, @aTime, @tableName, @waiterName, @status, @orderType, @total, @recieved, @change); 
                         SELECT LAST_INSERT_ID()";
                    }
                    else
                    {
                        qry1 = @"UPDATE table_main 
                         SET status = @status, total = @total, recieved = @recieved, `change` = @change 
                         WHERE MainId = @mainId";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(qry1, con))
                    {
                        cmd.Parameters.AddWithValue("@mainId", MainID);
                        cmd.Parameters.AddWithValue("@aDate", Convert.ToDateTime(DateTime.Now.Date));
                        cmd.Parameters.AddWithValue("@aTime", DateTime.Now.ToShortTimeString());
                        cmd.Parameters.AddWithValue("@tableName", lblTable.Text);
                        cmd.Parameters.AddWithValue("@waiterName", lblWaiter.Text);
                        cmd.Parameters.AddWithValue("@status", "Hold");
                        cmd.Parameters.AddWithValue("@orderType", OrderType);
                        cmd.Parameters.AddWithValue("@total", Convert.ToDouble(totalLabel.Text));
                        cmd.Parameters.AddWithValue("@recieved", Convert.ToDouble(0));
                        cmd.Parameters.AddWithValue("@change", Convert.ToDouble(0));

                        if (MainID == 0)
                        {
                            MainID = Convert.ToInt32(cmd.ExecuteScalar()); // Retrieve the last inserted ID
                        }
                        else
                        {
                            cmd.ExecuteNonQuery(); // Update the existing record
                        }
                    }

                    // Insert or Update order details for each row in DataGridView
                    foreach (DataGridViewRow row in guna2DataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Skip the last empty row

                        // Ensure cells are not null or empty
                        string dgvIdStr = row.Cells["dgvid"].Value?.ToString();
                        string proIdStr = row.Cells["dgvproID"].Value?.ToString();
                        string qtyStr = row.Cells["dgvQty"].Value?.ToString();
                        string priceStr = row.Cells["dgvPrice"].Value?.ToString();
                        string amountStr = row.Cells["dgvAmount"].Value?.ToString();

                        if (string.IsNullOrWhiteSpace(dgvIdStr) || string.IsNullOrWhiteSpace(proIdStr) ||
                            string.IsNullOrWhiteSpace(qtyStr) || string.IsNullOrWhiteSpace(priceStr) || string.IsNullOrWhiteSpace(amountStr))
                        {
                            MessageBox.Show("Some cells are empty. Please fill in all details.");
                            continue;
                        }

                        // Convert values
                        detailId = Convert.ToInt32(dgvIdStr);
                        int proId = Convert.ToInt32(proIdStr);
                        int qty = Convert.ToInt32(qtyStr);
                        double price = Convert.ToDouble(priceStr);
                        double amount = Convert.ToDouble(amountStr);

                        if (detailId == 0)
                        {
                            qry2 = @"INSERT INTO table_details (mainId, proId, qty, price, amount) 
                             VALUES (@mainId, @proId, @qty, @price, @amount)";
                        }
                        else
                        {
                            qry2 = @"UPDATE table_details 
                             SET proId = @proId, qty = @qty, price = @price, amount = @amount 
                             WHERE detailId = @detailId";
                        }

                        using (MySqlCommand cmd2 = new MySqlCommand(qry2, con))
                        {
                            cmd2.Parameters.AddWithValue("@detailId", detailId);
                            cmd2.Parameters.AddWithValue("@mainId", MainID);
                            cmd2.Parameters.AddWithValue("@proId", proId);
                            cmd2.Parameters.AddWithValue("@qty", qty);
                            cmd2.Parameters.AddWithValue("@price", price);
                            cmd2.Parameters.AddWithValue("@amount", amount);

                            cmd2.ExecuteNonQuery(); // Insert or update the details record
                        }
                    }

                    // Show success message
                    guna2MessageDialog1.Show("Saved Successfully");

                    // Reset form
                    MainID = 0;
                    detailId = 0;
                    guna2DataGridView1.Rows.Clear();
                    lblTable.Text = "";
                    lblWaiter.Text = "";
                    lblTable.Visible = false;
                    lblWaiter.Visible = false;
                    totalLabel.Text = "00";
                }
                catch (FormatException fex)
                {
                    MessageBox.Show("There was an issue with data formatting: " + fex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close(); // Ensure the connection is closed
                }
            }
        }
    }
}
