namespace Golden_Chemistry_1
{
    partial class Administrator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDashbord = new Guna.UI.WinForms.GunaButton();
            this.btnAddMedicine = new Guna.UI.WinForms.GunaButton();
            this.btnCategory = new Guna.UI.WinForms.GunaButton();
            this.btnLogOut = new Guna.UI.WinForms.GunaButton();
            this.btnAddUser = new Guna.UI.WinForms.GunaButton();
            this.btnSupplier = new Guna.UI.WinForms.GunaButton();
            this.btnValidity = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse6 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse7 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse8 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse9 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse10 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.uC_Category1 = new Golden_Chemistry_1.AdministratorUC.UC_Category();
            this.uC_Supplier1 = new Golden_Chemistry_1.AdministratorUC.UC_Supplier();
            this.uC_MedicineValidityCheck1 = new Golden_Chemistry_1.AdministratorUC.UC_MedicineValidityCheck();
            this.uC_AddMedicine1 = new Golden_Chemistry_1.AdministratorUC.UC_AddMedicine();
            this.uC_AddUser1 = new Golden_Chemistry_1.AdministratorUC.UC_AddUser();
            this.uC_dashbord1 = new Golden_Chemistry_1.AdministratorUC.UC_dashbord();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 779);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(333, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 749);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(112, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDashbord);
            this.panel4.Controls.Add(this.btnAddMedicine);
            this.panel4.Controls.Add(this.btnCategory);
            this.panel4.Controls.Add(this.btnLogOut);
            this.panel4.Controls.Add(this.btnAddUser);
            this.panel4.Controls.Add(this.btnSupplier);
            this.panel4.Controls.Add(this.btnValidity);
            this.panel4.Location = new System.Drawing.Point(12, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 573);
            this.panel4.TabIndex = 14;
            // 
            // btnDashbord
            // 
            this.btnDashbord.AnimationHoverSpeed = 0.07F;
            this.btnDashbord.AnimationSpeed = 0.03F;
            this.btnDashbord.BaseColor = System.Drawing.Color.Gray;
            this.btnDashbord.BorderColor = System.Drawing.Color.Black;
            this.btnDashbord.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDashbord.FocusedColor = System.Drawing.Color.Empty;
            this.btnDashbord.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashbord.ForeColor = System.Drawing.Color.White;
            this.btnDashbord.Image = ((System.Drawing.Image)(resources.GetObject("btnDashbord.Image")));
            this.btnDashbord.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDashbord.Location = new System.Drawing.Point(-1, 28);
            this.btnDashbord.Name = "btnDashbord";
            this.btnDashbord.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDashbord.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnDashbord.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnDashbord.OnHoverImage = null;
            this.btnDashbord.OnPressedColor = System.Drawing.Color.Black;
            this.btnDashbord.Size = new System.Drawing.Size(305, 49);
            this.btnDashbord.TabIndex = 2;
            this.btnDashbord.Text = "Dashbord";
            this.btnDashbord.Click += new System.EventHandler(this.btnDashbord_Click);
            this.btnDashbord.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDashbord_MouseClick);
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.AnimationHoverSpeed = 0.07F;
            this.btnAddMedicine.AnimationSpeed = 0.03F;
            this.btnAddMedicine.BaseColor = System.Drawing.Color.Gray;
            this.btnAddMedicine.BorderColor = System.Drawing.Color.Black;
            this.btnAddMedicine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddMedicine.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.Color.White;
            this.btnAddMedicine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMedicine.Image")));
            this.btnAddMedicine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddMedicine.Location = new System.Drawing.Point(0, 189);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddMedicine.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAddMedicine.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddMedicine.OnHoverImage = null;
            this.btnAddMedicine.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddMedicine.Size = new System.Drawing.Size(305, 49);
            this.btnAddMedicine.TabIndex = 8;
            this.btnAddMedicine.Text = "Medicine Management";
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.AnimationHoverSpeed = 0.07F;
            this.btnCategory.AnimationSpeed = 0.03F;
            this.btnCategory.BaseColor = System.Drawing.Color.Gray;
            this.btnCategory.BorderColor = System.Drawing.Color.Black;
            this.btnCategory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCategory.FocusedColor = System.Drawing.Color.Empty;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCategory.Location = new System.Drawing.Point(2, 431);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategory.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnCategory.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnCategory.OnHoverImage = null;
            this.btnCategory.OnPressedColor = System.Drawing.Color.Black;
            this.btnCategory.Size = new System.Drawing.Size(305, 49);
            this.btnCategory.TabIndex = 13;
            this.btnCategory.Text = "Catagory Management";
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.AnimationHoverSpeed = 0.07F;
            this.btnLogOut.AnimationSpeed = 0.03F;
            this.btnLogOut.BaseColor = System.Drawing.Color.Gray;
            this.btnLogOut.BorderColor = System.Drawing.Color.Black;
            this.btnLogOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOut.Location = new System.Drawing.Point(3, 512);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogOut.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnLogOut.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnLogOut.OnHoverImage = null;
            this.btnLogOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogOut.Size = new System.Drawing.Size(305, 49);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AnimationHoverSpeed = 0.07F;
            this.btnAddUser.AnimationSpeed = 0.03F;
            this.btnAddUser.BaseColor = System.Drawing.Color.Gray;
            this.btnAddUser.BorderColor = System.Drawing.Color.Black;
            this.btnAddUser.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddUser.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Image")));
            this.btnAddUser.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddUser.Location = new System.Drawing.Point(2, 107);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddUser.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnAddUser.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnAddUser.OnHoverImage = null;
            this.btnAddUser.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddUser.Size = new System.Drawing.Size(305, 49);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "User Management";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.AnimationHoverSpeed = 0.07F;
            this.btnSupplier.AnimationSpeed = 0.03F;
            this.btnSupplier.BaseColor = System.Drawing.Color.Gray;
            this.btnSupplier.BorderColor = System.Drawing.Color.Black;
            this.btnSupplier.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSupplier.FocusedColor = System.Drawing.Color.Empty;
            this.btnSupplier.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnSupplier.Image")));
            this.btnSupplier.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSupplier.Location = new System.Drawing.Point(0, 352);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSupplier.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnSupplier.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSupplier.OnHoverImage = null;
            this.btnSupplier.OnPressedColor = System.Drawing.Color.Black;
            this.btnSupplier.Size = new System.Drawing.Size(305, 49);
            this.btnSupplier.TabIndex = 12;
            this.btnSupplier.Text = "Supplier Management";
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnValidity
            // 
            this.btnValidity.AnimationHoverSpeed = 0.07F;
            this.btnValidity.AnimationSpeed = 0.03F;
            this.btnValidity.BaseColor = System.Drawing.Color.Gray;
            this.btnValidity.BorderColor = System.Drawing.Color.Black;
            this.btnValidity.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnValidity.FocusedColor = System.Drawing.Color.Empty;
            this.btnValidity.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidity.ForeColor = System.Drawing.Color.White;
            this.btnValidity.Image = ((System.Drawing.Image)(resources.GetObject("btnValidity.Image")));
            this.btnValidity.ImageSize = new System.Drawing.Size(25, 25);
            this.btnValidity.Location = new System.Drawing.Point(3, 272);
            this.btnValidity.Name = "btnValidity";
            this.btnValidity.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnValidity.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnValidity.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnValidity.OnHoverImage = null;
            this.btnValidity.OnPressedColor = System.Drawing.Color.Black;
            this.btnValidity.Size = new System.Drawing.Size(305, 49);
            this.btnValidity.TabIndex = 10;
            this.btnValidity.Text = "Medicine Validity Check";
            this.btnValidity.Click += new System.EventHandler(this.btnValidity_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.uC_Category1);
            this.panel3.Controls.Add(this.uC_Supplier1);
            this.panel3.Controls.Add(this.uC_MedicineValidityCheck1);
            this.panel3.Controls.Add(this.uC_AddMedicine1);
            this.panel3.Controls.Add(this.uC_AddUser1);
            this.panel3.Controls.Add(this.uC_dashbord1);
            this.panel3.Location = new System.Drawing.Point(337, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1118, 775);
            this.panel3.TabIndex = 2;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this.panel3;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this.panel3;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.panel3;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.TargetControl = this.panel3;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.TargetControl = this.panel3;
            // 
            // gunaElipse6
            // 
            this.gunaElipse6.TargetControl = this.panel3;
            // 
            // gunaElipse7
            // 
            this.gunaElipse7.TargetControl = this.panel3;
            // 
            // gunaElipse8
            // 
            this.gunaElipse8.TargetControl = this.panel3;
            // 
            // gunaElipse9
            // 
            this.gunaElipse9.TargetControl = this.panel3;
            // 
            // gunaElipse10
            // 
            this.gunaElipse10.TargetControl = this.panel3;
            // 
            // uC_Category1
            // 
            this.uC_Category1.BackColor = System.Drawing.Color.LightGray;
            this.uC_Category1.Location = new System.Drawing.Point(0, -3);
            this.uC_Category1.Name = "uC_Category1";
            this.uC_Category1.Size = new System.Drawing.Size(1140, 800);
            this.uC_Category1.TabIndex = 9;
            this.uC_Category1.Load += new System.EventHandler(this.uC_Category1_Load);
            // 
            // uC_Supplier1
            // 
            this.uC_Supplier1.BackColor = System.Drawing.Color.LightGray;
            this.uC_Supplier1.Location = new System.Drawing.Point(0, 0);
            this.uC_Supplier1.Name = "uC_Supplier1";
            this.uC_Supplier1.Size = new System.Drawing.Size(1140, 770);
            this.uC_Supplier1.TabIndex = 8;
            // 
            // uC_MedicineValidityCheck1
            // 
            this.uC_MedicineValidityCheck1.BackColor = System.Drawing.Color.LightGray;
            this.uC_MedicineValidityCheck1.Location = new System.Drawing.Point(0, 0);
            this.uC_MedicineValidityCheck1.Name = "uC_MedicineValidityCheck1";
            this.uC_MedicineValidityCheck1.Size = new System.Drawing.Size(1140, 770);
            this.uC_MedicineValidityCheck1.TabIndex = 7;
            // 
            // uC_AddMedicine1
            // 
            this.uC_AddMedicine1.BackColor = System.Drawing.Color.LightGray;
            this.uC_AddMedicine1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddMedicine1.Name = "uC_AddMedicine1";
            this.uC_AddMedicine1.Size = new System.Drawing.Size(1140, 770);
            this.uC_AddMedicine1.TabIndex = 4;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.LightGray;
            this.uC_AddUser1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(1104, 770);
            this.uC_AddUser1.TabIndex = 1;
            // 
            // uC_dashbord1
            // 
            this.uC_dashbord1.BackColor = System.Drawing.Color.LightGray;
            this.uC_dashbord1.Location = new System.Drawing.Point(0, 0);
            this.uC_dashbord1.Name = "uC_dashbord1";
            this.uC_dashbord1.Size = new System.Drawing.Size(1119, 770);
            this.uC_dashbord1.TabIndex = 0;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 780);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnLogOut;
        private Guna.UI.WinForms.GunaButton btnAddUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnValidity;
        private Guna.UI.WinForms.GunaButton btnAddMedicine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnSupplier;
        private AdministratorUC.UC_dashbord uC_dashbord1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private AdministratorUC.UC_AddUser uC_AddUser1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private Guna.UI.WinForms.GunaElipse gunaElipse6;
        private Guna.UI.WinForms.GunaElipse gunaElipse7;
        private Guna.UI.WinForms.GunaElipse gunaElipse8;
        private Guna.UI.WinForms.GunaElipse gunaElipse9;
        private Guna.UI.WinForms.GunaButton btnCategory;
        private Guna.UI.WinForms.GunaElipse gunaElipse10;
        private AdministratorUC.UC_Category uC_Category1;
        private AdministratorUC.UC_Supplier uC_Supplier1;
        private AdministratorUC.UC_MedicineValidityCheck uC_MedicineValidityCheck1;
        
        
        private AdministratorUC.UC_AddMedicine uC_AddMedicine1;
        
        private Guna.UI.WinForms.GunaButton btnDashbord;
        private System.Windows.Forms.Panel panel4;
    }
}