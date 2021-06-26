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
            //popupBayar.idNota = "FF" + id;
        }
        public void UpdateTotal()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            harga.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", sum);
            //popupBayar.popSubtotal = harga.Text;
            //popupBayar.popTotal = harga.Text;
        }

        public penjualan()
        {
            InitializeComponent();
        }
        formpembayaran popupBayar = new formpembayaran();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //popupBayar.view = dataGridView1;
                GenerateID();
                popupBayar.ShowDialog();
                UpdateTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error!" + Environment.NewLine + ex);
            }
        }
    }
}
