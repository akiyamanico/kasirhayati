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
    public partial class stockbarang : Form
    {
        private SqlCommand cmd;
        koneksi Conn = new koneksi();
        public stockbarang()
        {
            InitializeComponent();
            TampilGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TampilGrid()
        {
            SqlConnection Konn = Conn.GetConn();
            SqlCommand Command = new SqlCommand("select * from tblbarang", Konn);
            Konn.Open();
            SqlDataReader reader = Command.ExecuteReader();
            DataTable mytable = new DataTable();

            mytable.Load(reader);
            Konn.Close();
            dataGridView1.DataSource = mytable;
        }

        private void savedata_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || barcode.Text.Trim() == "" || namabarangtb.Text.Trim() == "" || hbtb.Text.Trim() == "" || hjtb.Text.Trim() == "" || stocktb.Text.Trim() == "")
            {
                MessageBox.Show("Data Belum Lengkap");
            }
            else
            {
                SqlConnection Konn = Conn.GetConn();
                try
                {
                    cmd = new SqlCommand("insert into tblbarang values('"+ textBox1.Text + "','" + barcode.Text + "','" + namabarangtb.Text + "','" + hbtb.Text + "', '" + hjtb.Text +"', '" +stocktb.Text + "')" ,Konn);
                    Konn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert data berhasil!");
                    TampilGrid();
                }
                catch(Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }
    }
}
