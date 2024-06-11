using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Chemistry_1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Administrator f2 = new Administrator();
            f2.Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbUser.Items.Clear();
            txtPassword.Clear();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

            string password = txtPassword.Text;
           string loginType = cmbUser.SelectedItem?.ToString();

            if (cmbUser.Text== "Admin" && password == "Admin@123")
            {
                MessageBox.Show("Admin Login Successful");
                Hide();
                Administrator f2 = new Administrator();
                f2.Show();

                // Perform actions for admin login
            }
            else if (cmbUser.Text == "Pharmacist" && password == "Pharmacist@456")
            {
                MessageBox.Show("Pharmacist Login Successful");
                Hide();
                Pharmacist f2 = new Pharmacist();
                f2.Show();
                // Perform actions for user login
            }
            else
            {
                MessageBox.Show("Invalid Login Credentials");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
