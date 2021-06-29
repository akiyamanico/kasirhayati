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
public string barcode { get; internal set; }
        public string nbarang { get; internal set; }

        public barangmanual()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataIndexNo = dgv1.Rows[e.RowIndex].Index.ToString();
            string cellValue = dgv1.Rows[e.RowIndex].Cells[1].Value.ToString();
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
    }
}

