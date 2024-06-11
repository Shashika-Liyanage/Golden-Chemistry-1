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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Golden_Chemistry_1.AdministratorUC
{
    public partial class UC_Category : UserControl
    {
        public UC_Category()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Load_data()
        {
            cmd = new SqlCommand("Select * from Category", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;


        }

        private void UC_Category_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
           
        }
        public void clearAll()
        {

            txtCategoryID.Clear();
            txtQuantity.Clear();
            txtCategoryType.Items.Clear();



        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = gunaDataGridView1.Rows[index];
            txtCategoryID.Text = selectedrow.Cells[1].Value.ToString();
            txtQuantity.Text = selectedrow.Cells[2].Value.ToString();
            txtCategoryType.Text = selectedrow.Cells[3].Value.ToString();
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("CategotyID", txtCategoryID.Text);
            cmd.Parameters.AddWithValue("CategoryQuantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("CategotyType", txtCategoryType.Text);
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(txtCategoryID.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtCategoryType.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into Category Values (@CategotyID, @CategoryQuantity, @CategotyType)", con);
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
            if (String.IsNullOrEmpty(txtCategoryID.Text) || String.IsNullOrEmpty(txtQuantity.Text) || String.IsNullOrEmpty(txtCategoryType.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update Category set CategotyID = @CategotyID, CategoryQuantity = @CategoryQuantity, CategotyType = @CategotyType where CategotyID = @CategotyID", con);


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
            cmd = new SqlCommand("Delete From Category where CategotyID = @CategotyID", con);
            Parameters();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Load_data();
            MessageBox.Show("Record Delete Successfully");
            clearAll();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            String CatType = txtSearch.Text;
            {
                string query = "SELECT * FROM Category WHERE CategotyType LIKE @CategotyType";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@CategotyType", "%" + CatType + "%");

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
