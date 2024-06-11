using Guna.UI.WinForms;
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
    public partial class UC_dashbord : UserControl
    {
       

        public UC_dashbord()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;" +
             "Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public void loadChart()
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_dashbord_Load(object sender, EventArgs e)
        {
            LoadMedicineData();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            LoadMedicineData();
        }

        private void LoadMedicineData()
        {
          
        }

    }
}
