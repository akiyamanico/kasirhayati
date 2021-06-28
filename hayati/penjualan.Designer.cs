
namespace hayati
{
    partial class penjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namaBrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttl_hrg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.harga_barang = new System.Windows.Forms.Label();
            this.nama_barang = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.harga = new System.Windows.Forms.Label();
            this.barcodeid = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.loginbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.exitbutton = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.laporanpenjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksimenu = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mastermenu = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelbarcode = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelbarcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.Location = new System.Drawing.Point(1141, 198);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(71, 27);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Tambah";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(35, 724);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Hapus";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaBrg,
            this.qty,
            this.hrg,
            this.ttl_hrg,
            this.Barcode});
            this.dataGridView1.Location = new System.Drawing.Point(35, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1177, 485);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // namaBrg
            // 
            this.namaBrg.HeaderText = "Nama Barang";
            this.namaBrg.Name = "namaBrg";
            this.namaBrg.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            // 
            // hrg
            // 
            this.hrg.HeaderText = "Harga";
            this.hrg.Name = "hrg";
            this.hrg.ReadOnly = true;
            // 
            // ttl_hrg
            // 
            this.ttl_hrg.HeaderText = "Total";
            this.ttl_hrg.Name = "ttl_hrg";
            this.ttl_hrg.ReadOnly = true;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Barcode.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.harga_barang);
            this.panel1.Controls.Add(this.nama_barang);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(35, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 67);
            this.panel1.TabIndex = 22;
            // 
            // harga_barang
            // 
            this.harga_barang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.harga_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.harga_barang.Location = new System.Drawing.Point(1798, -33);
            this.harga_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harga_barang.Name = "harga_barang";
            this.harga_barang.Size = new System.Drawing.Size(356, 61);
            this.harga_barang.TabIndex = 1;
            this.harga_barang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nama_barang
            // 
            this.nama_barang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nama_barang.AutoEllipsis = true;
            this.nama_barang.AutoSize = true;
            this.nama_barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nama_barang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nama_barang.Location = new System.Drawing.Point(4, 3);
            this.nama_barang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Size = new System.Drawing.Size(0, 46);
            this.nama_barang.TabIndex = 0;
            this.nama_barang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1111, 723);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 33);
            this.button3.TabIndex = 21;
            this.button3.Text = "Bayar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // harga
            // 
            this.harga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.harga.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.harga.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.harga.ForeColor = System.Drawing.Color.Lime;
            this.harga.Location = new System.Drawing.Point(773, 35);
            this.harga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(440, 76);
            this.harga.TabIndex = 20;
            this.harga.Text = "0";
            this.harga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barcodeid
            // 
            this.barcodeid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.barcodeid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.barcodeid.Location = new System.Drawing.Point(910, 199);
            this.barcodeid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.barcodeid.Name = "barcodeid";
            this.barcodeid.Size = new System.Drawing.Size(223, 26);
            this.barcodeid.TabIndex = 19;
            this.barcodeid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcodeid_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountmenu,
            this.laporanmenu,
            this.transaksimenu,
            this.mastermenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "strip";
            // 
            // accountmenu
            // 
            this.accountmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginbutton,
            this.logoutbutton,
            this.exitbutton});
            this.accountmenu.Name = "accountmenu";
            this.accountmenu.Size = new System.Drawing.Size(67, 20);
            this.accountmenu.Text = "Account";
            // 
            // loginbutton
            // 
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(115, 22);
            this.loginbutton.Text = "Login";
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(115, 22);
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(115, 22);
            this.exitbutton.Text = "Exit";
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // laporanmenu
            // 
            this.laporanmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanpenjualan});
            this.laporanmenu.Name = "laporanmenu";
            this.laporanmenu.Size = new System.Drawing.Size(69, 20);
            this.laporanmenu.Text = "Laporan";
            // 
            // laporanpenjualan
            // 
            this.laporanpenjualan.Name = "laporanpenjualan";
            this.laporanpenjualan.Size = new System.Drawing.Size(187, 22);
            this.laporanpenjualan.Text = "Laporan Penjualan";
            // 
            // transaksimenu
            // 
            this.transaksimenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penjualanToolStripMenuItem});
            this.transaksimenu.Name = "transaksimenu";
            this.transaksimenu.Size = new System.Drawing.Size(79, 20);
            this.transaksimenu.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            // 
            // mastermenu
            // 
            this.mastermenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.mastermenu.Name = "mastermenu";
            this.mastermenu.Size = new System.Drawing.Size(60, 20);
            this.mastermenu.Text = "Master";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // panelbarcode
            // 
            this.panelbarcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelbarcode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelbarcode.Controls.Add(this.label1);
            this.panelbarcode.Controls.Add(this.label2);
            this.panelbarcode.ForeColor = System.Drawing.Color.Lime;
            this.panelbarcode.Location = new System.Drawing.Point(36, 35);
            this.panelbarcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelbarcode.Name = "panelbarcode";
            this.panelbarcode.Size = new System.Drawing.Size(729, 76);
            this.panelbarcode.TabIndex = 23;
            this.panelbarcode.Paint += new System.Windows.Forms.PaintEventHandler(this.panelbarcode_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2327, -57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 61);
            this.label1.TabIndex = 1;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 46);
            this.label2.TabIndex = 0;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tambahkan Barang Secara Manual";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // penjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelbarcode);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.harga);
            this.Controls.Add(this.barcodeid);
            this.Name = "penjualan";
            this.Text = "penjualan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.penjualan_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelbarcode.ResumeLayout(false);
            this.panelbarcode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label harga_barang;
        public System.Windows.Forms.Label nama_barang;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label harga;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ToolStripMenuItem accountmenu;
        public System.Windows.Forms.ToolStripMenuItem loginbutton;
        public System.Windows.Forms.ToolStripMenuItem logoutbutton;
        public System.Windows.Forms.ToolStripMenuItem exitbutton;
        public System.Windows.Forms.ToolStripMenuItem laporanmenu;
        private System.Windows.Forms.ToolStripMenuItem laporanpenjualan;
        public System.Windows.Forms.ToolStripMenuItem transaksimenu;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mastermenu;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttl_hrg;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.Panel panelbarcode;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox barcodeid;
    }
}