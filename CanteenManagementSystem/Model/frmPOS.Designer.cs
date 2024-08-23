namespace CanteenManagementSystem.Model
{
    partial class frmPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblWaiter = new Guna.UI.WinForms.GunaLabel();
            this.lblTable = new Guna.UI.WinForms.GunaLabel();
            this.btnClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnDine = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnTakeAway = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnKOT = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBillList = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnHold = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNew = new Guna.UI2.WinForms.Guna2TileButton();
            this.POSLabel = new Guna.UI.WinForms.GunaLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.totalLabel = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.categoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categortBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.productPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2MessageDialog2 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel1.Controls.Add(this.lblWaiter);
            this.guna2Panel1.Controls.Add(this.lblTable);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Controls.Add(this.btnDine);
            this.guna2Panel1.Controls.Add(this.btnTakeAway);
            this.guna2Panel1.Controls.Add(this.btnKOT);
            this.guna2Panel1.Controls.Add(this.btnBillList);
            this.guna2Panel1.Controls.Add(this.btnHold);
            this.guna2Panel1.Controls.Add(this.btnNew);
            this.guna2Panel1.Controls.Add(this.POSLabel);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1366, 100);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblWaiter
            // 
            this.lblWaiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.lblWaiter.Location = new System.Drawing.Point(1113, 55);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(80, 31);
            this.lblWaiter.TabIndex = 11;
            this.lblWaiter.Text = "Waiter";
            // 
            // lblTable
            // 
            this.lblTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTable.AutoSize = true;
            this.lblTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.lblTable.Location = new System.Drawing.Point(1115, 25);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(67, 31);
            this.lblTable.TabIndex = 10;
            this.lblTable.Text = "Table";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageRotate = 0F;
            this.btnClose.Location = new System.Drawing.Point(1267, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 62);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.guna2PictureBox3_Click);
            // 
            // btnDine
            // 
            this.btnDine.BorderRadius = 10;
            this.btnDine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDine.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDine.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnDine.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDine.ForeColor = System.Drawing.Color.White;
            this.btnDine.Location = new System.Drawing.Point(975, 25);
            this.btnDine.Name = "btnDine";
            this.btnDine.Size = new System.Drawing.Size(89, 62);
            this.btnDine.TabIndex = 9;
            this.btnDine.Text = "Dine In";
            this.btnDine.Click += new System.EventHandler(this.guna2TileButton5_Click);
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.BorderRadius = 10;
            this.btnTakeAway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTakeAway.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeAway.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTakeAway.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTakeAway.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTakeAway.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnTakeAway.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.ForeColor = System.Drawing.Color.White;
            this.btnTakeAway.Location = new System.Drawing.Point(880, 25);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(89, 62);
            this.btnTakeAway.TabIndex = 8;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.Click += new System.EventHandler(this.btnTakeAway_Click);
            // 
            // btnKOT
            // 
            this.btnKOT.BorderRadius = 10;
            this.btnKOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKOT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKOT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKOT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKOT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKOT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnKOT.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKOT.ForeColor = System.Drawing.Color.White;
            this.btnKOT.Image = ((System.Drawing.Image)(resources.GetObject("btnKOT.Image")));
            this.btnKOT.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKOT.Location = new System.Drawing.Point(785, 25);
            this.btnKOT.Name = "btnKOT";
            this.btnKOT.Size = new System.Drawing.Size(89, 62);
            this.btnKOT.TabIndex = 7;
            this.btnKOT.Text = "KOT";
            this.btnKOT.Click += new System.EventHandler(this.btnKOT_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BorderRadius = 10;
            this.btnBillList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBillList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBillList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBillList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBillList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnBillList.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillList.ForeColor = System.Drawing.Color.White;
            this.btnBillList.Image = ((System.Drawing.Image)(resources.GetObject("btnBillList.Image")));
            this.btnBillList.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBillList.Location = new System.Drawing.Point(690, 25);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(89, 62);
            this.btnBillList.TabIndex = 6;
            this.btnBillList.Text = "Bill List";
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // btnHold
            // 
            this.btnHold.BorderRadius = 10;
            this.btnHold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnHold.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = ((System.Drawing.Image)(resources.GetObject("btnHold.Image")));
            this.btnHold.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHold.Location = new System.Drawing.Point(595, 25);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(89, 62);
            this.btnHold.TabIndex = 5;
            this.btnHold.Text = "Hold";
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BorderRadius = 10;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNew.Location = new System.Drawing.Point(500, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(89, 62);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // POSLabel
            // 
            this.POSLabel.AutoSize = true;
            this.POSLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.POSLabel.Location = new System.Drawing.Point(98, 28);
            this.POSLabel.Name = "POSLabel";
            this.POSLabel.Size = new System.Drawing.Size(84, 45);
            this.POSLabel.TabIndex = 3;
            this.POSLabel.Text = "POS";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 75);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guna2Panel2.Controls.Add(this.totalLabel);
            this.guna2Panel2.Controls.Add(this.gunaLabel1);
            this.guna2Panel2.Controls.Add(this.btnCheckout);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 668);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1366, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.totalLabel.Location = new System.Drawing.Point(1236, 30);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(73, 41);
            this.totalLabel.TabIndex = 5;
            this.totalLabel.Text = "0.00";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.gunaLabel1.Location = new System.Drawing.Point(1143, 30);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(81, 41);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "Total";
            this.gunaLabel1.Click += new System.EventHandler(this.gunaLabel1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(953, 21);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(111, 47);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // categoryPanel
            // 
            this.categoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryPanel.Location = new System.Drawing.Point(12, 183);
            this.categoryPanel.Name = "categoryPanel";
            this.categoryPanel.Size = new System.Drawing.Size(200, 479);
            this.categoryPanel.TabIndex = 2;
            // 
            // categortBtn
            // 
            this.categortBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.categortBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categortBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categortBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categortBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categortBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(153)))), ((int)(((byte)(32)))));
            this.categortBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categortBtn.ForeColor = System.Drawing.Color.White;
            this.categortBtn.Location = new System.Drawing.Point(15, 183);
            this.categortBtn.Name = "categortBtn";
            this.categortBtn.Size = new System.Drawing.Size(197, 59);
            this.categortBtn.TabIndex = 0;
            this.categortBtn.Text = "Category";
            this.categortBtn.Click += new System.EventHandler(this.categortBtn_Click);
            // 
            // productPanel
            // 
            this.productPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productPanel.AutoScroll = true;
            this.productPanel.Location = new System.Drawing.Point(218, 183);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(668, 479);
            this.productPanel.TabIndex = 3;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(892, 183);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.Size = new System.Drawing.Size(462, 479);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick_1);
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 6;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 50F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 50;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 50;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 70F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 70;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 125;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 70F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 70;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 70;
            // 
            // searchText
            // 
            this.searchText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.DefaultText = "";
            this.searchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchText.IconLeft = global::CanteenManagementSystem.Properties.Resources.search_9_256;
            this.searchText.Location = new System.Drawing.Point(218, 133);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.PlaceholderText = "Search Here";
            this.searchText.SelectedText = "";
            this.searchText.Size = new System.Drawing.Size(371, 43);
            this.searchText.TabIndex = 10;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "Canteen Management system";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // guna2MessageDialog2
            // 
            this.guna2MessageDialog2.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog2.Caption = null;
            this.guna2MessageDialog2.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.guna2MessageDialog2.Parent = null;
            this.guna2MessageDialog2.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.guna2MessageDialog2.Text = null;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.categortBtn);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.productPanel);
            this.Controls.Add(this.categoryPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOS";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI.WinForms.GunaLabel POSLabel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton btnNew;
        private Guna.UI2.WinForms.Guna2TileButton btnKOT;
        private Guna.UI2.WinForms.Guna2TileButton btnBillList;
        private Guna.UI2.WinForms.Guna2TileButton btnHold;
        private Guna.UI2.WinForms.Guna2TileButton btnDine;
        private Guna.UI2.WinForms.Guna2TileButton btnTakeAway;
        private Guna.UI2.WinForms.Guna2PictureBox btnClose;
        private System.Windows.Forms.FlowLayoutPanel categoryPanel;
        private System.Windows.Forms.FlowLayoutPanel productPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2TileButton categortBtn;
        public System.Windows.Forms.Button btnCheckout;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI2.WinForms.Guna2TextBox searchText;
        private Guna.UI.WinForms.GunaLabel totalLabel;
        private Guna.UI.WinForms.GunaLabel lblWaiter;
        private Guna.UI.WinForms.GunaLabel lblTable;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog2;
    }
}