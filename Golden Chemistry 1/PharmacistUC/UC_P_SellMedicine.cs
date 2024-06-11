using Golden_Chemistry_1.AdministratorUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using System.Data.SqlClient;

namespace Golden_Chemistry_1.PharmacistUC
{
    public partial class UC_P_SellMedicine : UserControl

    {
        
        public UC_P_SellMedicine()
        {
            InitializeComponent();


            printDocument1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True");
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataAdapter dr;
        SqlDataReader read;



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void UC_P_SellMedicine_Load(object sender, EventArgs e)
        {
           
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            string MediID = txtMediId.Text;
            string MediName = txtMediName.Text;
            double PerPrice = double.Parse(txtPricePerUnit.Text);
            double Qty = double.Parse(txtQuantity.Text);

            double tot = PerPrice * Qty;

            this.dataGridView1.Rows.Add(MediID, MediName, PerPrice, Qty, tot) ;

            int sum = 0;
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
            }
            txtTotalPrice.Text = sum.ToString() ;


            txtMediId.Clear();
            txtMediName.Clear();
            txtPricePerUnit.Clear();
            txtQuantity.Clear();
            
        }

        private void txtMediId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cmd = new SqlCommand("select * from product where id = '" + txtMediId.Text +"'",con);
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
                else {
                    MessageBox.Show("Not Founded");
                }
                con.Close();
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

                int sum = 0;
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[4].Value);
                }
                txtTotalPrice.Text = sum.ToString();

            }
        }

        public void SalesSave()
        { 
            string total = txtTotalPrice.Text;
            string pay = txtPayment.Text;
            string bal = txtBalance.Text;

            string sql1;
            string sql2;

            sql1 = "insert into sale(subtotal,pay,balance)values (@subtotal,@pay,@balance) select @@identity;";
            con.Open();
            cmd = new SqlCommand(sql1,con);
            cmd.Parameters.AddWithValue("@subtotal", total);
            cmd.Parameters.AddWithValue("@pay", pay);
            cmd.Parameters.AddWithValue("@balance", bal);

            int lastid = int.Parse(cmd.ExecuteScalar().ToString());

            string MedName;
            int price = 0;
            int qty = 0;
            int tot = 0;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                MedName = dataGridView1.Rows[row].Cells[1].Value.ToString();
                price = int.Parse(dataGridView1.Rows[row].Cells[2].Value.ToString());
                qty = int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                tot = int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                sql2 = "insert into sale_product(sales_id,MediName,price,qty,total)values (@sales_id,@MediName,@price,@qty,@total)";
               
                cmd1 = new SqlCommand(sql2, con);
                cmd1.Parameters.AddWithValue("@sales_id", lastid);
                cmd1.Parameters.AddWithValue("@MediName", MedName);
                cmd1.Parameters.AddWithValue("@price", price);
                cmd1.Parameters.AddWithValue("@qty", qty);
                cmd1.Parameters.AddWithValue("@total", tot);
                cmd1.ExecuteNonQuery();

            }
            MessageBox.Show("sales completeeedddddddddddddd");
            con.Close();
        }




        private void btnPurchasePrint_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txtTotalPrice.Text);
            double pay = double.Parse(txtPayment.Text);
            double bal = pay - total;
            txtBalance.Text = bal.ToString();

            SalesSave();

            Print(this.panel1);



        }
        Bitmap MemoryImage;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog previewdlg = new PrintPreviewDialog();

        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }

        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 20) - (this.panel1.Width / 20), this.panel1.Location.Y);
        }

        public void Print(Panel pnl)
        {
            Panel pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printDocument1;
            previewdlg.ShowDialog();
        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPricePerUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
