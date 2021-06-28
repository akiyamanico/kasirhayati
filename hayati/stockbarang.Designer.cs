
namespace hayati
{
    partial class stockbarang
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcodebarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocktersedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ditambahkan_tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedata = new System.Windows.Forms.Button();
            this.printdata = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.namabarangtb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hbtb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hjtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stocktb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.expireddate = new System.Windows.Forms.DateTimePicker();
            this.todaydate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarang,
            this.barcodebarang,
            this.namabarang,
            this.hargabeli,
            this.hargajualbarang,
            this.stocktersedia,
            this.expired,
            this.ditambahkan_tanggal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(823, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idbarang
            // 
            this.idbarang.HeaderText = "id";
            this.idbarang.Name = "idbarang";
            // 
            // barcodebarang
            // 
            this.barcodebarang.HeaderText = "barcodeid";
            this.barcodebarang.Name = "barcodebarang";
            // 
            // namabarang
            // 
            this.namabarang.HeaderText = "namabarang";
            this.namabarang.Name = "namabarang";
            // 
            // hargabeli
            // 
            this.hargabeli.HeaderText = "hargabelibarang";
            this.hargabeli.Name = "hargabeli";
            // 
            // hargajualbarang
            // 
            this.hargajualbarang.HeaderText = "hargajual";
            this.hargajualbarang.Name = "hargajualbarang";
            // 
            // stocktersedia
            // 
            this.stocktersedia.HeaderText = "stockbarang";
            this.stocktersedia.Name = "stocktersedia";
            // 
            // expired
            // 
            this.expired.HeaderText = "expired";
            this.expired.Name = "expired";
            // 
            // ditambahkan_tanggal
            // 
            this.ditambahkan_tanggal.HeaderText = "ditambahkan_tanggal";
            this.ditambahkan_tanggal.Name = "ditambahkan_tanggal";
            // 
            // savedata
            // 
            this.savedata.Location = new System.Drawing.Point(12, 415);
            this.savedata.Name = "savedata";
            this.savedata.Size = new System.Drawing.Size(75, 23);
            this.savedata.TabIndex = 1;
            this.savedata.Text = "Simpan";
            this.savedata.UseVisualStyleBackColor = true;
            this.savedata.Click += new System.EventHandler(this.savedata_Click);
            // 
            // printdata
            // 
            this.printdata.Location = new System.Drawing.Point(108, 415);
            this.printdata.Name = "printdata";
            this.printdata.Size = new System.Drawing.Size(75, 23);
            this.printdata.TabIndex = 2;
            this.printdata.Text = "Cetak";
            this.printdata.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(760, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(97, 54);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(100, 23);
            this.barcode.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barcode";
            // 
            // namabarangtb
            // 
            this.namabarangtb.Location = new System.Drawing.Point(97, 82);
            this.namabarangtb.Name = "namabarangtb";
            this.namabarangtb.Size = new System.Drawing.Size(100, 23);
            this.namabarangtb.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nama Barang";
            // 
            // hbtb
            // 
            this.hbtb.Location = new System.Drawing.Point(97, 111);
            this.hbtb.Name = "hbtb";
            this.hbtb.Size = new System.Drawing.Size(100, 23);
            this.hbtb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Harga Beli";
            // 
            // hjtb
            // 
            this.hjtb.Location = new System.Drawing.Point(285, 24);
            this.hjtb.Name = "hjtb";
            this.hjtb.Size = new System.Drawing.Size(100, 23);
            this.hjtb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Harga Jual";
            // 
            // stocktb
            // 
            this.stocktb.Location = new System.Drawing.Point(285, 54);
            this.stocktb.Name = "stocktb";
            this.stocktb.Size = new System.Drawing.Size(100, 23);
            this.stocktb.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Stock Barang";
            // 
            // expireddate
            // 
            this.expireddate.Location = new System.Drawing.Point(285, 84);
            this.expireddate.Name = "expireddate";
            this.expireddate.Size = new System.Drawing.Size(200, 23);
            this.expireddate.TabIndex = 16;
            // 
            // todaydate
            // 
            this.todaydate.Location = new System.Drawing.Point(635, 12);
            this.todaydate.Name = "todaydate";
            this.todaydate.Size = new System.Drawing.Size(200, 23);
            this.todaydate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Expired";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tanggal Hari Ini";
            // 
            // stockbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.todaydate);
            this.Controls.Add(this.expireddate);
            this.Controls.Add(this.stocktb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hjtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hbtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.namabarangtb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.printdata);
            this.Controls.Add(this.savedata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stockbarang";
            this.Text = "stockbarang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Button printdata;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodebarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocktersedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn ditambahkan_tanggal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namabarangtb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hbtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hjtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stocktb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expireddate;
        private System.Windows.Forms.DateTimePicker todaydate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}