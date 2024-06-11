using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Text.RegularExpressions;

namespace Golden_Chemistry_1.AdministratorUC
{
    public partial class UC_Supplier : UserControl
    {
        public UC_Supplier()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Load_data()
        {
            cmd = new SqlCommand("Select * from Supplier", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;


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

        private void UC_Supplier_Load(object sender, EventArgs e)
        {
         
            Load_data();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {

            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = gunaDataGridView1.Rows[index];
            txtSupplierID.Text = selectedrow.Cells[1].Value.ToString();
            txtSupplierName.Text = selectedrow.Cells[2].Value.ToString();
            txtContact.Text = selectedrow.Cells[3].Value.ToString();
            txtEmail.Text = selectedrow.Cells[4].Value.ToString();
           
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("SupplierID", txtSupplierID.Text);
            cmd.Parameters.AddWithValue("SupplierName", txtSupplierName.Text);
            cmd.Parameters.AddWithValue("SupplierContact", txtContact.Text);
            cmd.Parameters.AddWithValue("SupplierEmail", txtEmail.Text);
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           


            if (String.IsNullOrEmpty(txtSupplierID.Text) || String.IsNullOrEmpty(txtSupplierName.Text) || String.IsNullOrEmpty(txtContact.Text)  || String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Supplier Values (@SupplierID, @SupplierName, @SupplierContact, @SupplierEmail)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                clearAll();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSupplierID.Text) || String.IsNullOrEmpty(txtSupplierName.Text) || String.IsNullOrEmpty(txtContact.Text) || String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Supplier set SupplierID = @SupplierID, SupplierName = @SupplierName,  SupplierEmail = @SupplierEmail where SupplierID = @SupplierID", con);


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
            cmd = new SqlCommand("Delete From Supplier where SupplierID = @SupplierID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();

            MessageBox.Show("Record Delete Successfully");


            clearAll();
        }

        static Regex validate_contact = contact_validation();
        private void txtContact_Leave(object sender, EventArgs e)
        {

            if (validate_contact.IsMatch(txtContact.Text) != true)
            {
                MessageBox.Show("Invalid Contact!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtContact.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Contact Number is valid.");
            }
        }

        static Regex validate_emailaddress = email_validation();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (validate_emailaddress.IsMatch(txtEmail.Text) != true)
            {
                MessageBox.Show("Invalid Email Address!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Email Address is valid.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String SupName = txtSearch.Text;
            {
                string query = "SELECT * FROM Supplier WHERE SupplierName LIKE @SupplierName";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@SupplierName", "%" + SupName + "%");

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

        private void txtSupplierID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
