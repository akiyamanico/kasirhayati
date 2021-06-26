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
    public partial class Form1 : Form
    {
        public static Form1 menu;
        MenuStrip strip;
        login formlogin;
        void formlogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            formlogin = null;
        }
        void locked()
        {
            loginbutton.Enabled = true;
            logoutbutton.Enabled = false;
            laporanmenu.Enabled = false;
            transaksimenu.Enabled = false;
            mastermenu.Enabled = false;
            menu = this;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, FormClosedEventHandler e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            locked();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (formlogin == null)
            {
                formlogin = new login();
                formlogin.FormClosed += new FormClosedEventHandler(formlogin_fromClosed);
                formlogin.ShowDialog();
                this.Hide();
            }
            else
            {
                formlogin.Activate();
            }
        }

        private void Formlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lockedmenu = new login();
            lockedmenu.Show();
            locked();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            penjualan marketting = new penjualan();
            marketting.Show();
            MessageBox.Show("Selamat Berjualan");
        }
    }
}
