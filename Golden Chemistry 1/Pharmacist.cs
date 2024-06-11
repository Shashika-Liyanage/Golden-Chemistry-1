using Golden_Chemistry_1.AdministratorUC;
using Golden_Chemistry_1.PharmacistUC;
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
    public partial class Pharmacist : Form
    {
        public Pharmacist()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            string message = "Do you want to Log Out?";
            string title = "Log Out";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                login obj = new login();
                obj.Show();
            }
            else
            {

            }

            myBtnSetting(btnLogOut, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pharmacist_Load(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = false;
            uC_P_Dashbord1.Visible= false;
            
        }

        private void btnDashbord2_Click(object sender, EventArgs e)
        {
           
            uC_P_Dashbord2.Visible = true;
            uC_P_Dashbord2.BringToFront();

           // myBtnSetting(btnDashbord2, null);
        }

        private void btnViewMedicineP_Click(object sender, EventArgs e)
        {
            uC_P_ViewMedicine1.Visible = true;
            uC_P_ViewMedicine1.BringToFront();

            //myBtnSetting(btnViewMedicineP, null);

        }

        private void btnSellMedicine_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sell_Medicine obj = new Sell_Medicine();
            obj.Show();

           // myBtnSetting(btnSellMedicine, null);

        }

        private void uC_P_SellMedicine1_Load(object sender, EventArgs e)
        {

        }

        private void uC_P_Dashbord1_Load(object sender, EventArgs e)
        {

        }
        private void myBtnSetting(object sender, MouseEventArgs e)
        {
            foreach (Control C in panel4.Controls)
            {

                C.ForeColor = Color.White;

            }
            Control click = (Control)sender;

            click.ForeColor = Color.HotPink;

        }

        private void uC_P_ViewMedicine1_Load(object sender, EventArgs e)
        {

        }
    }
}
