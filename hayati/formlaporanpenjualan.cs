using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayati
{
    public partial class formlaporanpenjualan : Form
    {
        public formlaporanpenjualan()
        {
            InitializeComponent();
        }

        private void exitbuttonreport_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printreport_Click(object sender, EventArgs e)
        {
            //TODO Cetak Laporan Dengan Crystal Report
        }
    }
}
