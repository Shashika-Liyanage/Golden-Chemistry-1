namespace Golden_Chemistry_1
{
    partial class Sell_Medicine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell_Medicine));
            this.txtTotalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSync = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.txtMediName = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPricePerUnit = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMediId = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBalance = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPayment = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.pnlBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPrice.Location = new System.Drawing.Point(181, 320);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(341, 37);
            this.txtTotalPrice.TabIndex = 59;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(179, 288);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 25);
            this.label23.TabIndex = 58;
            this.label23.Text = "Total Price";
            // 
            // pnlBill
            // 
            this.pnlBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBill.Controls.Add(this.lblBalance);
            this.pnlBill.Controls.Add(this.lblPayment);
            this.pnlBill.Controls.Add(this.lblTotalPrice);
            this.pnlBill.Controls.Add(this.label22);
            this.pnlBill.Controls.Add(this.label21);
            this.pnlBill.Controls.Add(this.dataGridView2);
            this.pnlBill.Controls.Add(this.label20);
            this.pnlBill.Controls.Add(this.label15);
            this.pnlBill.Controls.Add(this.label19);
            this.pnlBill.Controls.Add(this.label18);
            this.pnlBill.Controls.Add(this.label17);
            this.pnlBill.Controls.Add(this.label16);
            this.pnlBill.Controls.Add(this.label14);
            this.pnlBill.Controls.Add(this.label13);
            this.pnlBill.Controls.Add(this.dateTimePicker1);
            this.pnlBill.Controls.Add(this.label12);
            this.pnlBill.Controls.Add(this.label11);
            this.pnlBill.Controls.Add(this.label10);
            this.pnlBill.Controls.Add(this.label9);
            this.pnlBill.Location = new System.Drawing.Point(818, 8);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(559, 771);
            this.pnlBill.TabIndex = 57;
            this.pnlBill.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBill_Paint);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(482, 638);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(32, 22);
            this.lblBalance.TabIndex = 54;
            this.lblBalance.Text = "00";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(482, 579);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(32, 22);
            this.lblPayment.TabIndex = 53;
            this.lblPayment.Text = "00";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(482, 520);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(32, 22);
            this.lblTotalPrice.TabIndex = 52;
            this.lblTotalPrice.Text = "00";
            this.lblTotalPrice.Click += new System.EventHandler(this.lblTotalPrice_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(129, 675);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(339, 16);
            this.label22.TabIndex = 51;
            this.label22.Text = "---------------------------------------------------------------------------------" +
    "--";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(126, 692);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(343, 54);
            this.label21.TabIndex = 50;
            this.label21.Text = "THANK YOU  FOR YOUR PURCHASING.....!\r\n                    ......VISIT AGAIN.....\r" +
    "\n\r\n";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView2.Location = new System.Drawing.Point(7, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(541, 301);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Medi ID";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Medi Name";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Per Unit";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Qty";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Total Price";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(456, 160);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 48;
            this.label20.Text = "Amount";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(360, 520);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 22);
            this.label15.TabIndex = 47;
            this.label15.Text = "Total Price";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(363, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Quantity";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(255, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 16);
            this.label18.TabIndex = 42;
            this.label18.Text = "Price Per Unit";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(360, 638);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 22);
            this.label17.TabIndex = 40;
            this.label17.Text = "Balance";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(360, 579);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 22);
            this.label16.TabIndex = 39;
            this.label16.Text = "Payment ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(134, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Medicine Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(163, 129);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(235, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "---------------------------------------------------------";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(210, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "TEL : 077 9847123";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 32);
            this.label11.TabIndex = 20;
            this.label11.Text = "No 17, Negombo Rd, \r\n        Nagoda.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(201, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 40);
            this.label10.TabIndex = 19;
            this.label10.Text = "Golden Chemistry \r\n     Pharmacy";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Medicine ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(10, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(802, 242);
            this.dataGridView1.TabIndex = 56;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Medicine ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Medicine Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price Per Unit";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "DELETE";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(389, 223);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(341, 37);
            this.txtQuantity.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Quantity";
            // 
            // btnSync
            // 
            this.btnSync.AnimationHoverSpeed = 0.07F;
            this.btnSync.AnimationSpeed = 0.03F;
            this.btnSync.BackColor = System.Drawing.Color.Transparent;
            this.btnSync.BaseColor = System.Drawing.Color.Transparent;
            this.btnSync.BorderColor = System.Drawing.Color.Black;
            this.btnSync.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSync.FocusedColor = System.Drawing.Color.Empty;
            this.btnSync.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSync.ForeColor = System.Drawing.Color.White;
            this.btnSync.Image = ((System.Drawing.Image)(resources.GetObject("btnSync.Image")));
            this.btnSync.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSync.Location = new System.Drawing.Point(325, 34);
            this.btnSync.Name = "btnSync";
            this.btnSync.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSync.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSync.OnHoverImage = null;
            this.btnSync.OnPressedColor = System.Drawing.Color.Black;
            this.btnSync.Size = new System.Drawing.Size(44, 36);
            this.btnSync.TabIndex = 53;
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdd.BorderColor = System.Drawing.Color.HotPink;
            this.btnAdd.BorderSize = 2;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(597, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(133, 42);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMediName
            // 
            this.txtMediName.BaseColor = System.Drawing.Color.White;
            this.txtMediName.BorderColor = System.Drawing.Color.Silver;
            this.txtMediName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMediName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMediName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMediName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediName.Location = new System.Drawing.Point(12, 225);
            this.txtMediName.Name = "txtMediName";
            this.txtMediName.PasswordChar = '\0';
            this.txtMediName.SelectedText = "";
            this.txtMediName.Size = new System.Drawing.Size(340, 37);
            this.txtMediName.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Medicine Name";
            // 
            // txtPricePerUnit
            // 
            this.txtPricePerUnit.BaseColor = System.Drawing.Color.White;
            this.txtPricePerUnit.BorderColor = System.Drawing.Color.Silver;
            this.txtPricePerUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPricePerUnit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPricePerUnit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPricePerUnit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPricePerUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPricePerUnit.Location = new System.Drawing.Point(389, 137);
            this.txtPricePerUnit.Name = "txtPricePerUnit";
            this.txtPricePerUnit.PasswordChar = '\0';
            this.txtPricePerUnit.SelectedText = "";
            this.txtPricePerUnit.Size = new System.Drawing.Size(341, 37);
            this.txtPricePerUnit.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Price Per Unit";
            // 
            // txtMediId
            // 
            this.txtMediId.BaseColor = System.Drawing.Color.White;
            this.txtMediId.BorderColor = System.Drawing.Color.Silver;
            this.txtMediId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMediId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMediId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMediId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMediId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediId.Location = new System.Drawing.Point(11, 137);
            this.txtMediId.Name = "txtMediId";
            this.txtMediId.PasswordChar = '\0';
            this.txtMediId.SelectedText = "";
            this.txtMediId.Size = new System.Drawing.Size(341, 37);
            this.txtMediId.TabIndex = 45;
            this.txtMediId.TextChanged += new System.EventHandler(this.txtMediId_TextChanged);
            this.txtMediId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMediId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Medicine ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(306, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 50);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sell Medicine";
            // 
            // txtBalance
            // 
            this.txtBalance.BaseColor = System.Drawing.Color.White;
            this.txtBalance.BorderColor = System.Drawing.Color.Silver;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBalance.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBalance.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(389, 680);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.SelectedText = "";
            this.txtBalance.Size = new System.Drawing.Size(341, 37);
            this.txtBalance.TabIndex = 64;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(401, 647);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 25);
            this.label8.TabIndex = 63;
            this.label8.Text = "Balance";
            // 
            // txtPayment
            // 
            this.txtPayment.BaseColor = System.Drawing.Color.White;
            this.txtPayment.BorderColor = System.Drawing.Color.Silver;
            this.txtPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPayment.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPayment.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPayment.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(21, 680);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PasswordChar = '\0';
            this.txtPayment.SelectedText = "";
            this.txtPayment.Size = new System.Drawing.Size(341, 37);
            this.txtPayment.TabIndex = 61;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 649);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Payment ";
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPrint.BorderColor = System.Drawing.Color.HotPink;
            this.btnPrint.BorderSize = 2;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(597, 743);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 15;
            this.btnPrint.Size = new System.Drawing.Size(153, 50);
            this.btnPrint.TabIndex = 65;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.BorderColor = System.Drawing.Color.HotPink;
            this.btnBack.BorderSize = 2;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = null;
            this.btnBack.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBack.Location = new System.Drawing.Point(1279, 799);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 15;
            this.btnBack.Size = new System.Drawing.Size(94, 37);
            this.btnBack.TabIndex = 66;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(756, 8);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(56, 46);
            this.btnExit.TabIndex = 67;
            this.btnExit.Text = "gunaButton1";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Sell_Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 839);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMediName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPricePerUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMediId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sell_Medicine";
            this.Text = "Sell_Medicine";
            this.Load += new System.EventHandler(this.Sell_Medicine_Load);
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtTotalPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton btnSync;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox txtMediName;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtPricePerUnit;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtMediId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtBalance;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtPayment;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private Guna.UI.WinForms.GunaButton btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblTotalPrice;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}