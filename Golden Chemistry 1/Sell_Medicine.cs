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
using System.Xml.Linq;
using System.Drawing.Printing;

namespace Golden_Chemistry_1
{
    public partial class Sell_Medicine : Form
    {
        public Sell_Medicine()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataAdapter dr;
        SqlDataReader read;


        private void Sell_Medicine_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pharmacist obj = new Pharmacist();
            obj.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string MediID = txtMediId.Text;
            string MediName = txtMediName.Text;
            double PerPrice = double.Parse(txtPricePerUnit.Text);
            double Qty = double.Parse(txtQuantity.Text);

            double tot = PerPrice * Qty;
            this.dataGridView1.Rows.Add(MediID, MediName, PerPrice, Qty, tot);
            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
            }
            txtTotalPrice.Text = sum.ToString();
           
            this.dataGridView2.Rows.Add(MediID, MediName, PerPrice, Qty, tot);
            int sum2 = 0;
            for (int row = 0; row < dataGridView2.Rows.Count; row++)
            {
                sum2 = sum2 + Convert.ToInt32(dataGridView2.Rows[row].Cells[4].Value);
            }
            txtTotalPrice.Text = sum2.ToString();


            txtMediId.Clear();
            txtMediName.Clear();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();
        }

        private void txtMediId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmd = new SqlCommand("select * from productNew where id = '" + 
                txtMediId.Text + "'", con);
                con.Open();
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    string MedName;
                    string price;

                    MedName = read["MedName"].ToString();
                    price = read["price"].ToString();

                    txtMediName.Text = MedName;
                    txtPricePerUnit.Text = price;

                }
                else
                {
                    MessageBox.Show("Not Founded");
                }
                con.Close();
            }
            con.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
                    printPreviewDialog.Document = printDocument;
                    printPreviewDialog.ShowDialog();
                }
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.
        PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // Specify the panel to be printed (assuming you have a panel named "panel1")
            Panel panelToPrint = pnlBill;

            // Get the bounds of the printable area
            RectangleF bounds = e.PageSettings.PrintableArea;

            // Calculate the scaling factor to fit the panel within the printable area
            float scalingFactor = Math.Min(bounds.Width / panelToPrint.Width, 
            bounds.Height / panelToPrint.Height);

            // Scale the graphics object by the scaling factor
            graphics.ScaleTransform(scalingFactor, scalingFactor);

            // Create a bitmap to hold the panel's content
            Bitmap bitmap = new Bitmap(panelToPrint.Width, panelToPrint.Height);
            panelToPrint.DrawToBitmap(bitmap, panelToPrint.ClientRectangle);

            // Draw the bitmap on the graphics object
            graphics.DrawImage(bitmap, 0, 0);
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = txtTotalPrice.Text.Trim();
        }

        private void txtPayment_TextChanged(object sender, EventArgs e)
        {
            lblPayment.Text = txtPayment.Text.Trim();
            double tot = Double.Parse(txtTotalPrice.Text);
            double pay= Double.Parse(txtPayment.Text);
            double v = pay - tot;
            string blnc=Convert.ToString(v);
            txtBalance.Text = blnc;
            
        }
        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            lblBalance.Text = txtBalance.Text.Trim();
            double tot = Double.Parse(txtTotalPrice.Text);
            double pay = Double.Parse(txtPayment.Text);
            double v = pay - tot;
            string blnc = Convert.ToString(v);
            lblBalance.Text = blnc;
        }

        private void txtMediId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlBill_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
