
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
            this.hrgbarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocktersedia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ditambahkan_tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedata = new System.Windows.Forms.Button();
            this.printdata = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.hrgbarang,
            this.stocktersedia,
            this.expired,
            this.ditambahkan_tanggal});
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(823, 357);
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
            // hrgbarang
            // 
            this.hrgbarang.HeaderText = "hargabarang";
            this.hrgbarang.Name = "hrgbarang";
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
            // stockbarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.printdata);
            this.Controls.Add(this.savedata);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stockbarang";
            this.Text = "stockbarang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcodebarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrgbarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocktersedia;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn ditambahkan_tanggal;
        private System.Windows.Forms.Button savedata;
        private System.Windows.Forms.Button printdata;
        private System.Windows.Forms.Button button3;
    }
}