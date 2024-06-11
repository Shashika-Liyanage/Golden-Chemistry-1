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
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >= 782)
            { 
                timer1.Stop();
                login fm2 = new login();
                fm2.Show();
                this.Hide();
            }
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            

        }
    }
}
