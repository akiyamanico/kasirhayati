using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hayati
{
    public partial class barangmanual : Form
    {
        private SqlCommand cmd;
        private SqlDataReader rdr;
        koneksi Conn = new koneksi();
        penjualan f2 = new penjualan();
        public DataGridView Dgv { get; set; }
        public barangmanual()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cellValue = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
            barcodemanualtb.Text = cellValue;
        }
 

        private void barangmanual_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Konn = Conn.GetConn();
                Konn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblbarang", Konn);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "ss");
                dgv1.DataSource = ds.Tables["ss"]; ;
            }
            catch
            {
                MessageBox.Show("No Record Found");
            }
        }
        public string updatestuff
        {
            get
            {
                return this.barcodemanualtb.Text;
            }
            set
            {
                this.barcodemanualtb.Text = value;
            }
        }

        private void updatedata_Click(object sender, EventArgs e)
        {
            f2.barcodeid.Text = barcodemanualtb.Text;
        }
        private void barangmanual_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void barcodemanualtb_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            SqlConnection Konn = Conn.GetConn();
            Konn.Open();
            SqlCommand cmd = Konn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tblbarang where namabarang like('" + barcodemanualtb + "%')";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv1.DataSource = dt;
            Konn.Close();
        }
    }
}

