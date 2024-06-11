using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Golden_Chemistry_1.AdministratorUC
{
    public partial class UC_AddUser : UserControl
    {
        
        public UC_AddUser()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Load_data()
        {
            cmd = new SqlCommand("Select * from User1", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
        }
        public void GetUserID()
        { 
            string userid;
            string query = "select UserID from User1 order by UserID Desc";
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int id = int.Parse(dr[0].ToString()) + 1;
                userid = id.ToString("0000");
            }
            else if (Convert.IsDBNull(dr))
            {
                userid = ("0001");
            }
            else
            {
                userid = ("0001");
            }
            con.Close();



        }

        private void UC_AddUser_Load(object sender, EventArgs e)
        {
            Load_data();
            GetUserID();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtUserRole.Items.Clear();
            txtUserRole.SelectedIndex = -1;
            txtUserID.Clear();
            txtMobileNo.Clear();
            txtEmail.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            

        }

        private void btnReset_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = gunaDataGridView1.Rows[index];
            txtUserRole.Text = selectedrow.Cells[1].Value.ToString();
            txtUserID.Text = selectedrow.Cells[2].Value.ToString();
            txtMobileNo.Text = selectedrow.Cells[3].Value.ToString();
            txtEmail.Text = selectedrow.Cells[4].Value.ToString();
            txtUserName.Text = selectedrow.Cells[5].Value.ToString();
            txtPassword.Text = selectedrow.Cells[6].Value.ToString();

        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("UserRole", txtUserRole.Text);
            cmd.Parameters.AddWithValue("UserID", txtUserID.Text);
            cmd.Parameters.AddWithValue("Mobile", txtMobileNo.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("UserName", txtUserName.Text);
            cmd.Parameters.AddWithValue("Pass", txtPassword.Text);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserRole.Text) || String.IsNullOrEmpty(txtUserID.Text) ||
                String.IsNullOrEmpty(txtMobileNo.Text) ||
                String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtUserName.Text) 
                || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into User1 Values (@UserRole," +
                    " @UserID, @Mobile, @Email, @UserName, @Pass)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Added a User Successfully");
                clearAll();

            }

        }
        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        private static Regex contact_validation()
        {
            string pattern2 = "^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

            return new Regex(pattern2, RegexOptions.IgnoreCase);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserRole.Text) || String.IsNullOrEmpty(txtUserID.Text) ||
                String.IsNullOrEmpty(txtMobileNo.Text) ||
                String.IsNullOrEmpty(txtEmail.Text) || 
                
                String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update User1 set UserRole = @UserRole, UserID = @UserID, " +
                    "Mobile = @Mobile, Email = @Email," +
                    " UserName = @UserName, Pass = @Pass where UserID = @UserID", con);


                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Update Successfully");
                clearAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Delete?";
            string title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            {

            }
            cmd = new SqlCommand("Delete From User1 where UserID = @UserID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Delete Successfully");
            clearAll();
        }
        static Regex validate_emailaddress = email_validation();
        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (validate_emailaddress.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Email Address is valid.");
            }

        }
        static Regex validate_contact = contact_validation();
        private void txtMobileNo_Leave(object sender, EventArgs e)
        {
            if (validate_contact.IsMatch(txtMobileNo.Text) != true)
            {
                MessageBox.Show("Invalid Contact!", "Invalid", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMobileNo.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Contact Number is valid.");
            }
        }
        
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String UserName = txtSearch.Text;
            {
                string query = "SELECT * FROM User1 WHERE UserName LIKE @UserName";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@UserName", "%" + UserName + "%");

                // Execute the query and retrieve the results
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Display the results in the DataGridView
                gunaDataGridView1.DataSource = dataTable;

                // Close the database connection

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
