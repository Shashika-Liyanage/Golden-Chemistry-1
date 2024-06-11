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

namespace Golden_Chemistry_1.PharmacistUC
{
    public partial class UC_P_ViewMedicine : UserControl
    {
        public UC_P_ViewMedicine()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void UC_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("Select * from MedicineDetails", con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            gunaDataGridView1.DataSource = dt;
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String medicineName = txtMedicineName.Text;
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

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
