using CanteenManagementSystem.View;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenManagementSystem.Model
{
    public partial class frmProductAdd : SampleAdd
    {
        public frmProductAdd()
        {
            InitializeComponent();         
        }

        public int id = 0;
        public int cID = 0;

        private void frmProductAdd_Load(object sender, EventArgs e)
        {
            //for cb fill
            string qry = "Select catId 'id' , catName 'name' from category ";

            MainClass.CBFill(qry, cbCat);

            if (cID > 0) //for update
            {
                cbCat.SelectedValue = cID;
            }

            if (id > 0)
            {
                ForUpdateLoadData();
            }
        }

        string filepath;
        Byte[] imageByteArray;

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images(.jpg, .png)|* .png; *.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filepath = ofd.FileName;
                txtImage.Image = new Bitmap(filepath);
            }
        }

        public override void saveButton_Click(object sender, EventArgs e)
        {
            string qry = "";

            if (id == 0) // Insert
            {
                qry = "INSERT INTO products (productName, productPrice, categoryId, productImage) VALUES (@Name, @Price, @Cat, @Img)";
            }
            else // Update
            {
                qry = "UPDATE products SET productName = @Name, productPrice = @Price, categoryId = @Cat, productImage = @Img WHERE productId = @Id";
            }

            // Convert image to byte array
            Image temp = new Bitmap(txtImage.Image);
            MemoryStream ms = new MemoryStream();
            temp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            byte[] imageByteArray = ms.ToArray();

            Hashtable ht = new Hashtable();
            ht.Add("@Id", id);
            ht.Add("@Name", txtName.Text);

            // Convert and validate the price
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                ht.Add("@Price", price);
            }
            else
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            ht.Add("@Cat", Convert.ToInt32(cbCat.SelectedValue));
            ht.Add("@Img", imageByteArray);

            if (MainClass.SQl(qry, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved successfully.");
                id = 0;
                txtName.Text = "";
                txtPrice.Text = "";
                cbCat.SelectedIndex = -1;
                txtImage.Image = CanteenManagementSystem.Properties.Resources.products;
                txtName.Focus();
          
            }
        }

        private void ForUpdateLoadData()
        {
            string qry = "SELECT * FROM products WHERE productId = @Id";

            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;pwd=1234;database=canteen_management_system"))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(qry, connection))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            txtName.Text = dt.Rows[0]["productName"].ToString();
                            txtPrice.Text = dt.Rows[0]["productPrice"].ToString();

                            if (dt.Rows[0]["productImage"] != DBNull.Value)
                            {
                                byte[] imageArray = (byte[])dt.Rows[0]["productImage"];
                                txtImage.Image = Image.FromStream(new MemoryStream(imageArray));
                            }
                        }
                    }
                }
            }
        }
}
}
