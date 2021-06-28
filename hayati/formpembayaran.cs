using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hayati
{

    public partial class formpembayaran : Form
    {
        koneksi konn = new koneksi();
        public DataGridView Dgv { get; set; }
        public string popSubtotal
        {
            get { return this.subtotaltb.Text; }
            set { this.subtotaltb.Text = value; }
        }

        public string popTotal
        {
            get { return this.totalakhirtb.Text; }
            set { this.totalakhirtb.Text = value; }
        }

        public string idNota
        {
            get { return this.idnotatb.Text; }
            set { this.idnotatb.Text = value; }
        }



        public formpembayaran()
        {
            InitializeComponent();
        }

        // Make class for ReceiptItem
        private class ReceiptItem
        {
            public string Name { get; set; }

            public decimal Cost { get; set; }

            public int Amount { get; set; }

            public int Discount { get; set; }

            public decimal Total { get { return Cost * Amount; } }
        }

        // Setting Font for printing
        public class PrintText
        {
            public PrintText(string text, Font font) : this(text, font, new StringFormat()) { }

            public PrintText(string text, Font font, StringFormat stringFormat)
            {
                Text = text;
                Font = font;
                StringFormat = stringFormat;
            }

            public string Text { get; set; }

            public Font Font { get; set; }

            /// <summary> Default is horizontal string formatting </summary>
            public StringFormat StringFormat { get; set; }
        }

        // Printing the text to printer
        public void GetPrint(Object sender, PrintPageEventArgs g)
        {

            //Form1 view = new Form1();

            {
                const int FIRST_COL_PAD = 15;
                const int SECOND_COL_PAD = 5;
                const int THIRD_COL_PAD = 15;

                var sb = new StringBuilder();
                sb.Append("No Nota: ");
                sb.AppendLine(idnotatb.Text);
                sb.Append("Waktu: ");
                sb.AppendLine(DateTime.Now.ToString());
                sb.AppendLine("================");

                foreach (DataGridViewRow row in Dgv.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        var Name = row.Cells[0].Value.ToString();
                        sb.AppendLine((Name).PadRight(FIRST_COL_PAD));

                        var amount = int.Parse(row.Cells[1].Value.ToString());
                        var breakDown = amount > 0 ? "x" + amount : string.Empty;
                        sb.Append(breakDown.PadRight(SECOND_COL_PAD));

                        var Cost = int.Parse(row.Cells[2].Value.ToString());
                        sb.Append(("@" + string.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N0}", Cost)).PadRight(10));

                        var Total = int.Parse(row.Cells[3].Value.ToString());
                        sb.AppendLine(string.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N0}", Total).PadLeft(THIRD_COL_PAD));

                        //if (item.Discount > 0)
                        //{
                        //    sb.Append(string.Format("DISCOUNT {0:D2}%", item.Discount).PadRight(FIRST_COL_PAD + SECOND_COL_PAD));
                        //     sb.Append(string.Format("{0:0.00}", -(item.Total / 100 * item.Discount)).PadLeft(THIRD_COL_PAD));
                        //     sb.AppendLine();
                        // }
                    }

                }

                sb.AppendLine("================");

                int sum = 0;
                for (int i = 0; i < Dgv.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(Dgv.Rows[i].Cells[3].Value);
                }

                sb.Append(("Subtotal").PadRight(THIRD_COL_PAD));
                sb.AppendLine((string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", sum).PadLeft(THIRD_COL_PAD)));

                sb.Append(("Diskon").PadRight(THIRD_COL_PAD));
                decimal subtotal = subtotaltb.Text.ToAngka();
                decimal diskon = decimal.Parse(totaldiskon.Text.ToString()) / 100;
                decimal totalDisc = (diskon * subtotal);
                sb.AppendLine((string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", totalDisc).PadLeft(THIRD_COL_PAD)));

                sb.AppendLine("================");
                sb.Append(("Total").PadRight(THIRD_COL_PAD));
                sb.AppendLine((string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", sum - totalDisc).PadLeft(THIRD_COL_PAD)));

                sb.AppendLine("================");
                sb.Append(("Bayar").PadRight(THIRD_COL_PAD));
                sb.AppendLine((string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", int.Parse(totalbayartb.Text)).PadLeft(THIRD_COL_PAD)));

                sb.Append(("Kembalian").PadRight(THIRD_COL_PAD));
                sb.AppendLine((string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", totalkembaliantb.Text.ToAngka()).PadLeft(THIRD_COL_PAD)));
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("");
                sb.AppendLine("Terimakasih telah berbelanja di <shop-name>.");


                var printText = new PrintText(sb.ToString(), new Font("Cascadia Mono", 8));
                var layoutArea = new SizeF(220, 0);
                SizeF stringSize = g.Graphics.MeasureString(printText.Text, printText.Font, layoutArea, printText.StringFormat);

                RectangleF rectf = new RectangleF(new PointF(), new SizeF(220, stringSize.Height));

                g.Graphics.DrawString(printText.Text, printText.Font, Brushes.Black, rectf, printText.StringFormat);


            }
        }


        // Focus at totalbayar
        private void formpembayaran_Load(object sender, EventArgs e)
        {

            this.ActiveControl = totalbayartb;



        }

        // Function watch checkbox
        private void diskoncheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            totaldiskon.Enabled = (diskoncheckbox.CheckState == CheckState.Checked);

        }

        // Auto update stuff
        private void totaldiskon_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //    (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            // only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;

            //}


        }

        private void totaldiskon_KeyUp(object sender, KeyEventArgs e)
        {


            decimal subtotal = subtotaltb.Text.ToAngka();
            decimal diskon = decimal.Parse(totaldiskon.Text.ToString()) / 100;
            decimal totalcurrent = subtotal - (diskon * subtotal);

            totalakhirtb.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", totalcurrent);


        }

        private void totalbayartb_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int total = totalakhirtb.Text.ToAngka();
                int bayar = int.Parse(totalbayartb.Text.ToString()) - total;

                totalkembaliantb.Text = string.Format(CultureInfo.CreateSpecificCulture("id-id"), "Rp. {0:N0}", bayar);
            }
            catch
            {
                totalkembaliantb.Text = "0";
            }
        }

        private void totalbayartb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }


        }
        //

        // When enter pressed.
        private void totalbayartb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bayar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Run print function 
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

                    //Get item from datagridview
                    SqlConnection con = konn.GetConn();
                    foreach (DataGridViewRow row in Dgv.Rows)
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("update tblbarang set stockbarang = stockbarang - " + int.Parse(row.Cells[1].Value.ToString()) + " where barcodeid = " + row.Cells[4].Value, con);
                        cmd.ExecuteReader();
                        con.Close();
                    }


                    //TODO Menambahkan Update Database Dan Fungsi Print
                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += new PrintPageEventHandler(GetPrint);

                    printDoc.Print();
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
