namespace Golden_Chemistry_1.AdministratorUC
{
    partial class UC_Category
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Category));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryID = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoryType = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category Management";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.BaseColor = System.Drawing.Color.White;
            this.txtCategoryID.BorderColor = System.Drawing.Color.Silver;
            this.txtCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategoryID.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtCategoryID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategoryID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCategoryID.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryID.Location = new System.Drawing.Point(129, 168);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.PasswordChar = '\0';
            this.txtCategoryID.SelectedText = "";
            this.txtCategoryID.Size = new System.Drawing.Size(323, 44);
            this.txtCategoryID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category ID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(129, 292);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(323, 44);
            this.txtQuantity.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantity";
            // 
            // txtCategoryType
            // 
            this.txtCategoryType.BackColor = System.Drawing.Color.Transparent;
            this.txtCategoryType.BaseColor = System.Drawing.Color.White;
            this.txtCategoryType.BorderColor = System.Drawing.Color.Silver;
            this.txtCategoryType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCategoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategoryType.FocusedColor = System.Drawing.Color.Empty;
            this.txtCategoryType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCategoryType.ForeColor = System.Drawing.Color.Black;
            this.txtCategoryType.FormattingEnabled = true;
            this.txtCategoryType.Items.AddRange(new object[] {
            "Syrup",
            "Capsyules",
            "Tablets",
            "Injection",
            "Antibiotic",
            "Inhalers"});
            this.txtCategoryType.Location = new System.Drawing.Point(565, 168);
            this.txtCategoryType.Name = "txtCategoryType";
            this.txtCategoryType.OnHoverItemBaseColor = System.Drawing.Color.Teal;
            this.txtCategoryType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.txtCategoryType.Size = new System.Drawing.Size(323, 35);
            this.txtCategoryType.TabIndex = 15;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(30, 441);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1077, 298);
            this.gunaDataGridView1.TabIndex = 16;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.HotPink;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUpdate.Location = new System.Drawing.Point(312, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(180, 48);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.BorderColor = System.Drawing.Color.HotPink;
            this.btnReset.BorderSize = 2;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReset.Location = new System.Drawing.Point(831, 378);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 15;
            this.btnReset.Size = new System.Drawing.Size(180, 48);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.btnAdd.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAdd.Location = new System.Drawing.Point(53, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(180, 48);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.BorderColor = System.Drawing.Color.HotPink;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(599, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Radius = 15;
            this.btnDelete.Size = new System.Drawing.Size(180, 48);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Location = new System.Drawing.Point(514, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 250);
            this.panel2.TabIndex = 56;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.BorderColor = System.Drawing.Color.HotPink;
            this.btnSearch.BorderSize = 2;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSearch.Location = new System.Drawing.Point(795, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 15;
            this.btnSearch.Size = new System.Drawing.Size(64, 42);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(466, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(323, 44);
            this.txtSearch.TabIndex = 60;
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
            this.btnExit.Location = new System.Drawing.Point(1048, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(56, 46);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "gunaButton1";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // UC_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.txtCategoryType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_Category";
            this.Size = new System.Drawing.Size(1140, 770);
            this.Load += new System.EventHandler(this.UC_Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtCategoryID;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox txtCategoryType;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}
