namespace Golden_Chemistry_1.AdministratorUC
{
    partial class UC_MedicineValidityCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MedicineValidityCheck));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCheck = new Guna.UI.WinForms.GunaComboBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.lblSet = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.btnCheck = new Guna.UI.WinForms.GunaButton();
            this.btnSync = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Medicine Validity Check";
            // 
            // cmbCheck
            // 
            this.cmbCheck.BackColor = System.Drawing.Color.Transparent;
            this.cmbCheck.BaseColor = System.Drawing.Color.White;
            this.cmbCheck.BorderColor = System.Drawing.Color.Silver;
            this.cmbCheck.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCheck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheck.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCheck.ForeColor = System.Drawing.Color.Black;
            this.cmbCheck.FormattingEnabled = true;
            this.cmbCheck.Items.AddRange(new object[] {
            "Valid Medicines ",
            "Expired Medicine",
            "View All Medicines"});
            this.cmbCheck.Location = new System.Drawing.Point(313, 135);
            this.cmbCheck.Name = "cmbCheck";
            this.cmbCheck.OnHoverItemBaseColor = System.Drawing.Color.Teal;
            this.cmbCheck.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCheck.Size = new System.Drawing.Size(399, 35);
            this.cmbCheck.TabIndex = 6;
            this.cmbCheck.SelectedIndexChanged += new System.EventHandler(this.txtcheck_SelectedIndexChanged);
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(30, 244);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 51;
            this.gunaDataGridView1.RowTemplate.Height = 24;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(1060, 423);
            this.gunaDataGridView1.TabIndex = 8;
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
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // lblSet
            // 
            this.lblSet.AutoSize = true;
            this.lblSet.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSet.Location = new System.Drawing.Point(33, 207);
            this.lblSet.Name = "lblSet";
            this.lblSet.Size = new System.Drawing.Size(64, 34);
            this.lblSet.TabIndex = 9;
            this.lblSet.Text = "Set";
            this.lblSet.Click += new System.EventHandler(this.lblSet_Click);
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
            this.btnExit.Location = new System.Drawing.Point(1044, 13);
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
            // btnCheck
            // 
            this.btnCheck.AnimationHoverSpeed = 0.07F;
            this.btnCheck.AnimationSpeed = 0.03F;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheck.BorderColor = System.Drawing.Color.HotPink;
            this.btnCheck.BorderSize = 2;
            this.btnCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheck.FocusedColor = System.Drawing.Color.Empty;
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageSize = new System.Drawing.Size(22, 22);
            this.btnCheck.Location = new System.Drawing.Point(730, 128);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnCheck.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnCheck.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCheck.OnHoverImage = null;
            this.btnCheck.OnPressedColor = System.Drawing.Color.Black;
            this.btnCheck.Radius = 15;
            this.btnCheck.Size = new System.Drawing.Size(145, 42);
            this.btnCheck.TabIndex = 69;
            this.btnCheck.Text = "Check";
            this.btnCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
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
            this.btnSync.Location = new System.Drawing.Point(513, 45);
            this.btnSync.Name = "btnSync";
            this.btnSync.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSync.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSync.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSync.OnHoverImage = null;
            this.btnSync.OnPressedColor = System.Drawing.Color.Black;
            this.btnSync.Size = new System.Drawing.Size(44, 36);
            this.btnSync.TabIndex = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // UC_MedicineValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSet);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.cmbCheck);
            this.Controls.Add(this.label1);
            this.Name = "UC_MedicineValidityCheck";
            this.Size = new System.Drawing.Size(1140, 770);
            this.Load += new System.EventHandler(this.UC_MedicineValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cmbCheck;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Label lblSet;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaButton btnCheck;
        private Guna.UI.WinForms.GunaButton btnSync;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
