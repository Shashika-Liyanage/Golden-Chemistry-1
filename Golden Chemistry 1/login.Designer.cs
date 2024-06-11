namespace Golden_Chemistry_1
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.btnReset = new Guna.UI.WinForms.GunaButton();
            this.btnSignUp = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 770);
            this.panel1.TabIndex = 0;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(250, 150);
            this.gunaButton2.Location = new System.Drawing.Point(570, 35);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(387, 195);
            this.gunaButton2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Location = new System.Drawing.Point(523, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 450);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(608, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.Teal;
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(613, 491);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(344, 37);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.gunaTextBox2_TextChanged);
            // 
            // cmbUser
            // 
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Admin",
            "Pharmacist"});
            this.cmbUser.Location = new System.Drawing.Point(613, 370);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(344, 33);
            this.cmbUser.TabIndex = 19;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnReset.ImageSize = new System.Drawing.Size(35, 35);
            this.btnReset.Location = new System.Drawing.Point(796, 557);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Radius = 15;
            this.btnReset.Size = new System.Drawing.Size(161, 48);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.AnimationHoverSpeed = 0.07F;
            this.btnSignUp.AnimationSpeed = 0.03F;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignUp.BorderColor = System.Drawing.Color.HotPink;
            this.btnSignUp.BorderSize = 2;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.Image = ((System.Drawing.Image)(resources.GetObject("btnSignUp.Image")));
            this.btnSignUp.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSignUp.Location = new System.Drawing.Point(615, 557);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnSignUp.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnSignUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnHoverImage = null;
            this.btnSignUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignUp.Radius = 15;
            this.btnSignUp.Size = new System.Drawing.Size(161, 48);
            this.btnSignUp.TabIndex = 17;
            this.btnSignUp.Text = "Login";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(467, 723);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.btnExit.Location = new System.Drawing.Point(1007, 25);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(56, 46);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "gunaButton1";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Golden Chenistry Pharmacy Management System \r\n                    Login in. To se" +
    "e it in action \r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 628);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Golden Chemistry © 2023";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 723);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton btnExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private Guna.UI.WinForms.GunaButton btnSignUp;
        private Guna.UI.WinForms.GunaButton btnReset;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}