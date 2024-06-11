using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golden_Chemistry_1.AdministratorUC
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-QT0ABLE;Initial Catalog=GoldenChemistry;Integrated Security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmb = new SqlCommand();
            cmb.Connection= con;
            cmb.CommandText= query;
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String msg) 
        {
            SqlConnection con = getConnection();
            SqlCommand cmb = new SqlCommand();
            cmb.Connection= con;
            con.Open();
            cmb.CommandText= query;
            cmb.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
