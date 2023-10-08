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
using System.Globalization;

namespace hayati
{

 
    public partial class penjualan : Form
    {
        public static penjualan selling;
        MenuStrip strip;
        login formlogin;
        koneksi konn = new koneksi();
        void formlogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            formlogin = null;
        }
        void terkunci()
        {
            loginbutton.Enabled = true;
            logoutbutton.Enabled = false;
            laporanmenu.Enabled = false;
            transaksimenu.Enabled = false;
            mastermenu.Enabled = false;
            selling = this;
        }

   formpembayaran popupBayar = new formpembayaran();


        //TODO Adding much feature right here and blablabla

        public void GenerateID()
        {
            string numbers = "1234567890";

            string characters = numbers;
            int length = 10;
            string id = string.Empty;
            for (int i = 0; i < length; i++)
            {
                string character = string.Empty;
                do
                {
                    int index = new Random().Next(0, characters.Length);
                    character = characters.ToCharArray()[index].ToString();
                } while (id.IndexOf(character) != -1);
                id += character;
            }
            popupBayar.idNota = "HY" + id;
        }

        // get class

        public void UpdateTotal()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            harga.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", sum);
            popupBayar.popSubtotal = harga.Text;
            popupBayar.popTotal = harga.Text;
        }
        public string barcodeupdate
        {
            get
                {
                return this.barcodeid.Text;
                }
            set
            {
                this.barcodeid.Text = value;
            }
        }
        public string strvalue = string.Empty;
        public static string str1;
        public penjualan()
        {
            InitializeComponent();
        }

        private void penjualan_Load(object sender, EventArgs e)
        {
            terkunci();
        }
        private void loginbutton_Click(object sender, EventArgs e)
        {

        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lockedmenu = new login();
            lockedmenu.Show();
            terkunci();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stockbarang stockinformation = new stockbarang();
            stockinformation.Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.EndEdit();
            if (e.RowIndex < 0)
            {
                return;
            }
            int newQty = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            int value = newQty * int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            dataGridView1.Rows[e.RowIndex].Cells[3].Value = newQty * int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

            UpdateTotal();

        }
        protected void insertdata()
        {
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            string barcodeId = barcodeid.Text;

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if(row.Cells[4].Value.ToString() == barcodeId)
                {
                    row.Cells[1].Value = int.Parse(row.Cells[1].Value.ToString()) + 1;
                    int newQty = int.Parse(row.Cells[1].Value.ToString());
                    int value = newQty * int.Parse(row.Cells[2].Value.ToString());
                    row.Cells[3].Value = newQty * int.Parse(row.Cells[2].Value.ToString());
                    UpdateTotal();
                    return;
                }             
            }
            try
            {

                if (string.IsNullOrEmpty(barcodeId))
                {
                    return;
                }
                SqlConnection Conn = konn.GetConn();
                SqlCommand cmd = new SqlCommand("select * from tblbarang where barcodeid=" + barcodeId, Conn);
                Conn.Open();
                SqlDataReader row = cmd.ExecuteReader();
                if (row.HasRows)
                {
                    row.Read();
                    string Nama = row["namabarang"].ToString();
                    long Harga = long.Parse(row["hargajual"].ToString());
                    long barcode = long.Parse(row["barcodeid"].ToString());
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridView1);
                    newRow.Cells[0].Value = Nama;
                    newRow.Cells[1].Value = 1;
                    newRow.Cells[2].Value = Harga;
                    newRow.Cells[3].Value = long.Parse(newRow.Cells[2].Value.ToString()) * long.Parse(newRow.Cells[1].Value.ToString());
                    newRow.Cells[4].Value = barcode;
                    dataGridView1.Rows.Add(newRow);
                    nama_barang.Text = Nama.ToString();
                    harga_barang.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", Harga);
                    UpdateTotal();
                }
                else
                {
                    MessageBox.Show("Data not found");
                }
                Conn.Close();
                barcodeid.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + Environment.NewLine + ex);
                barcodeid.Clear();
            }
            barcodeid.Clear();
        }
        private void barcodeid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                barcodeid.Clear();
            }
        }

        // When bayar is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //popupBayar.view = dataGridView1;
                GenerateID();
                popupBayar.Dgv = dataGridView1;
                popupBayar.ShowDialog();
                popupBayar.FormClosing += new FormClosingEventHandler(this.penjualan_FormClosing);       
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + Environment.NewLine + ex);
                
            }
        }

        private void penjualan_FormClosing(object sender, FormClosingEventArgs e)
        {
            harga.Text = "0";
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            nama_barang.Text = "0";
        }

        private void panelbarcode_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void setbuttonmanual_Click(object sender, EventArgs e)
        {
            barangmanual formmanual = new barangmanual();
            formmanual.barcodemanualtb.Text = "Barcode";
            formmanual.Show();
            this.Hide();
            while (formmanual.Visible)
            {
                Application.DoEvents();
            }
            this.Show();
            this.barcodeid.Text = formmanual.barcodemanualtb.Text;
        }

    }


}
