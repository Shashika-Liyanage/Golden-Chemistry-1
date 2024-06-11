using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Golden_Chemistry_1.AdministratorUC
{
    public partial class UC_AddMedicine : UserControl
    {
       
        public UC_AddMedicine()
        {
            InitializeComponent();
            

        }
       
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        private void Load_data()
        {
            cmd = new SqlCommand("Select * from MedicineDetails", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMedicineID.Text) || String.IsNullOrEmpty(txtMedicineName.Text) || String.IsNullOrEmpty(txtQuantity.Text) ||
                String.IsNullOrEmpty(txtMDate.Text) || String.IsNullOrEmpty(txtEDate.Text) || String.IsNullOrEmpty(txtPerUnit.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Insert into MedicineDetails Values (@MedID, @MedName, @Quantity, @ManufDate, @ExpDate, @PerUnit)", con);
                Parameters();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Load_data();
                MessageBox.Show("Record Added Successfully");
                clearAll();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {

            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtQuantity.Clear();
            txtMDate.ResetText();
            txtEDate.ResetText();
            txtPerUnit.Clear();

        }

        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = gunaDataGridView1.Rows[index];
            txtMedicineID.Text = selectedrow.Cells[1].Value.ToString();
            txtMedicineName.Text = selectedrow.Cells[2].Value.ToString();
            txtQuantity.Text = selectedrow.Cells[3].Value.ToString();
            txtMDate.Text = selectedrow.Cells[4].Value.ToString();
            txtEDate.Text = selectedrow.Cells[5].Value.ToString();
            txtPerUnit.Text = selectedrow.Cells[6].Value.ToString();
        }
        private void Parameters()
        {
            cmd.Parameters.AddWithValue("MedID", txtMedicineID.Text);
            cmd.Parameters.AddWithValue("MedName", txtMedicineName.Text);
            cmd.Parameters.AddWithValue("Quantity", txtQuantity.Text);
            cmd.Parameters.AddWithValue("ManufDate", txtMDate.Text);
            cmd.Parameters.AddWithValue("ExpDate", txtEDate.Text);
            cmd.Parameters.AddWithValue("PerUnit", txtPerUnit.Text);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMedicineID.Text) || String.IsNullOrEmpty(txtMedicineName.Text) || String.IsNullOrEmpty(txtQuantity.Text) ||
                String.IsNullOrEmpty(txtMDate.Text) || String.IsNullOrEmpty(txtEDate.Text) || String.IsNullOrEmpty(txtPerUnit.Text))
            {
                MessageBox.Show("Complete the all required fields");
                return;
            }
            else
            {
                cmd = new SqlCommand("Update MedicineDetails set MedID = @MedID, MedName = @MedName, Quantity = @Quantity, ManufDate = @ManufDate," +
                    " ExpDate = @ExpDate, PerUnit = @PerUnit where MedID = @MedID", con);


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
            cmd = new SqlCommand("Delete From MedicineDetails where MedID = @MedID", con);
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
            String medicineName = txtSearch.Text;
            {
                string query = "SELECT * FROM MedicineDetails WHERE MedName LIKE @MedName";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@MedName", "%" + medicineName + "%");

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
