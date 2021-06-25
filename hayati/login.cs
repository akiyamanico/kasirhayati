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
    public partial class login : Form1
    {
        private SqlCommand cmd;
        private DataSet set;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        koneksi konn = new koneksi();

        public login()
        {
            Form1.menu.loginbutton.Enabled = false;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from tblkasir where namakasir='" + textBox1.Text + "' and passwordkasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read()) 
                {
                    Form1 connected = new Form1();
                    connected.Show();
                    Form1.menu.loginbutton.Enabled = false;
                    Form1.menu.logoutbutton.Enabled = true;
                    Form1.menu.laporanmenu.Enabled = true;
                    Form1.menu.transaksimenu.Enabled = true;
                    Form1.menu.mastermenu.Enabled = true;
                    MessageBox.Show("Selamat Datang!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

