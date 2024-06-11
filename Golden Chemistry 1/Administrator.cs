using Golden_Chemistry_1.AdministratorUC;
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
    public partial class Administrator : Form

    {
        public Administrator()
        {
            
            InitializeComponent();
            this.CenterToScreen();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            myBtnSetting(btnLogOut, null);

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


        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            uC_dashbord1.Visible = true;
            uC_dashbord1.BringToFront();
            

            myBtnSetting(btnDashbord, null);



        }

        private void Administrator_Load(object sender, EventArgs e)
        {
           
           

        }

        private void uC_dashbord1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();

            myBtnSetting(btnAddUser, null);

           

        }

        private void Administrator_Load_1(object sender, EventArgs e)
        {
            uC_dashbord1.Visible = false;
            uC_AddUser1.Visible = false;
            
            
            uC_AddMedicine1.Visible = false;
          
            
            uC_MedicineValidityCheck1.Visible = false;
            uC_Supplier1.Visible = false;
            uC_Category1.Visible = false;
            btnDashbord.PerformClick();
        }

        private void uC_AddUser1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            uC_AddMedicine1.Visible = true;
            uC_AddMedicine1.BringToFront();

            myBtnSetting(btnAddMedicine, null);


        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
          
        }

        private void btnValidity_Click(object sender, EventArgs e)
        {
            uC_MedicineValidityCheck1.Visible = true;
            uC_MedicineValidityCheck1.BringToFront();

            myBtnSetting(btnValidity, null);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            uC_Supplier1.Visible = true;
            uC_Supplier1.BringToFront();

            myBtnSetting(btnSupplier, null);
        }

        private void uC_Supplier1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            uC_Category1.Visible = true;
            uC_Category1.BringToFront();

            myBtnSetting(btnCategory, null);

        }

        private void btnDashbord_MouseClick(object sender, MouseEventArgs e)
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

        private void uC_Category1_Load(object sender, EventArgs e)
        {

        }
    }
}
