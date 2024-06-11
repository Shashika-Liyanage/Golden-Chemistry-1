namespace Golden_Chemistry_1
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Golden Chemistry Pharmacy \r\n                  Report";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 176);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 1;
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
            this.gunaButton2.ImageSize = new System.Drawing.Size(150, 75);
            this.gunaButton2.Location = new System.Drawing.Point(94, 12);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Size = new System.Drawing.Size(185, 110);
            this.gunaButton2.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(366, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "TEL : 077 9847123";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(362, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 34);
            this.label11.TabIndex = 22;
            this.label11.Text = "No 17, Negombo Rd, \r\n        Nagoda.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(57, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 3);
            this.panel2.TabIndex = 24;
            // 
            // btnLoad
            // 
            this.btnLoad.AnimationHoverSpeed = 0.07F;
            this.btnLoad.AnimationSpeed = 0.03F;
            this.btnLoad.BackColor = System.Drawing.Color.Transparent;
            this.btnLoad.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoad.BorderColor = System.Drawing.Color.HotPink;
            this.btnLoad.BorderSize = 2;
            this.btnLoad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoad.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Image = null;
            this.btnLoad.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoad.Location = new System.Drawing.Point(667, 425);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.OnHoverBaseColor = System.Drawing.Color.Silver;
            this.btnLoad.OnHoverBorderColor = System.Drawing.Color.HotPink;
            this.btnLoad.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoad.OnHoverImage = null;
            this.btnLoad.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoad.Radius = 15;
            this.btnLoad.Size = new System.Drawing.Size(144, 42);
            this.btnLoad.TabIndex = 53;
            this.btnLoad.Text = "Load Report";
            this.btnLoad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 479);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton btnLoad;
    }
}