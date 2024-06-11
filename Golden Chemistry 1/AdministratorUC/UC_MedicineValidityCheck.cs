using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace Golden_Chemistry_1.AdministratorUC
{
    public partial class UC_MedicineValidityCheck : UserControl
    {
       

        public UC_MedicineValidityCheck()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;" +
            "Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        private void UC_MedicineValidityCheck_Load(object sender, EventArgs e)
        {

        }

        private void txtcheck_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string loginType = cmbCheck.SelectedItem?.ToString();

            if (cmbCheck.Text == "View All Medicines")
            {
                lblSet.Text = cmbCheck.Text;
                cmd = new SqlCommand("Select * from MedicineDetails", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                gunaDataGridView1.DataSource = dt;
                con.Close();

            }
            else if (cmbCheck.Text == "Expired Medicine")
            {
               
                lblSet.Text = cmbCheck.Text;
                gunaDataGridView1.ClearSelection();

                cmd = new SqlCommand("SELECT * FROM MedicineDetails WHERE ExpDate<GETDATE()", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                gunaDataGridView1.DataSource = dt;
               


            }
            else if (cmbCheck.Text == "Valid Medicines ")
            {
                lblSet.Text = cmbCheck.Text;
                gunaDataGridView1.ClearSelection();
                

                lblSet.Text = cmbCheck.Text;
                cmd = new SqlCommand("SELECT * FROM MedicineDetails WHERE ExpDate >= GETDATE()", con);
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                gunaDataGridView1.DataSource = dt;
                con.Close();
            }

            else
            {
                
            }
        }

        private void lblSet_Click(object sender, EventArgs e)
        {
           

        }
    }
}
