namespace Golden_Chemistry_1.AdministratorUC
{
    partial class UC_Supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Supplier));
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSupplierName = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierID = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(684, 312);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(323, 44);
            this.txtEmail.TabIndex = 42;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(679, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Email";
            // 
            // txtContact
            // 
            this.txtContact.BaseColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.Silver;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContact.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtContact.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(684, 178);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(323, 44);
            this.txtContact.TabIndex = 35;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            this.txtContact.Leave += new System.EventHandler(this.txtContact_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(679, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Contact Number";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.BaseColor = System.Drawing.Color.White;
            this.txtSupplierName.BorderColor = System.Drawing.Color.Silver;
            this.txtSupplierName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSupplierName.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtSupplierName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSupplierName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(109, 312);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.Size = new System.Drawing.Size(323, 44);
            this.txtSupplierName.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Supplier Name";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.BaseColor = System.Drawing.Color.White;
            this.txtSupplierID.BorderColor = System.Drawing.Color.Silver;
            this.txtSupplierID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplierID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSupplierID.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtSupplierID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSupplierID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSupplierID.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierID.Location = new System.Drawing.Point(109, 178);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.PasswordChar = '\0';
            this.txtSupplierID.SelectedText = "";
            this.txtSupplierID.Size = new System.Drawing.Size(323, 44);
            this.txtSupplierID.TabIndex = 30;
            this.txtSupplierID.TextChanged += new System.EventHandler(this.txtSupplierID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Supplier ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 50);
            this.label1.TabIndex = 43;
            this.label1.Text = "Supplier Management";
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(36, 483);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1071, 262);
            this.gunaDataGridView1.TabIndex = 45;
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
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
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
            this.btnUpdate.Location = new System.Drawing.Point(308, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 15;
            this.btnUpdate.Size = new System.Drawing.Size(180, 48);
            this.btnUpdate.TabIndex = 44;
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
            this.btnReset.Location = new System.Drawing.Point(871, 415);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 15;
            this.btnReset.Size = new System.Drawing.Size(180, 48);
            this.btnReset.TabIndex = 40;
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
            this.btnAdd.Location = new System.Drawing.Point(53, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 15;
            this.btnAdd.Size = new System.Drawing.Size(180, 48);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Location = new System.Drawing.Point(551, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 275);
            this.panel2.TabIndex = 53;
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
            this.btnDelete.Location = new System.Drawing.Point(621, 415);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
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
            this.btnSearch.Location = new System.Drawing.Point(826, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 15;
            this.btnSearch.Size = new System.Drawing.Size(64, 42);
            this.btnSearch.TabIndex = 63;
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
            this.txtSearch.Location = new System.Drawing.Point(477, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(323, 44);
            this.txtSearch.TabIndex = 62;
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
            this.btnExit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExit.Location = new System.Drawing.Point(1034, 9);
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
            // UC_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label4);
            this.Name = "UC_Supplier";
            this.Size = new System.Drawing.Size(1140, 770);
            this.Load += new System.EventHandler(this.UC_Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaButton btnReset;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaTextBox txtContact;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtSupplierName;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtSupplierID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnExit;
    }
}
