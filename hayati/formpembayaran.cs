using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayati
{

    public partial class formpembayaran : Form
    {
        public formpembayaran()
        {
            InitializeComponent();
        }

        private void bayar_Click(object sender, EventArgs e)
        {
            int total = totalakhirtb.Text.ToAngka();
            int bayar = int.Parse(totalbayartb.Text.ToString()) - total;
            if (bayar < 0)
            {
                MessageBox.Show("Angka kembalian minus!, Cek kembali");
            }
            else
            {
                try { 
                    //TODO Menambahkan Update Database Dan Fungsi Print
                    MessageBox.Show("Simpan Berhasil! Kembalian = " + totalkembaliantb.Text);
                    totalbayartb.Clear();
                    diskoncheckbox.Checked = false;
                    totalkembaliantb.Clear();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error!" + Environment.NewLine + ex);
                }

            }
        }
    }
    public static class Rupiah
    {
        public static int ToAngka(this string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }
    }
}
