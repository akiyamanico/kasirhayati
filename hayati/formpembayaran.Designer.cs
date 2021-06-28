
namespace hayati
{
    partial class formpembayaran
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
            this.subtotaltb = new System.Windows.Forms.TextBox();
            this.diskoncheckbox = new System.Windows.Forms.CheckBox();
            this.totaldiskon = new System.Windows.Forms.NumericUpDown();
            this.idnotatb = new System.Windows.Forms.TextBox();
            this.totalakhirtb = new System.Windows.Forms.TextBox();
            this.totalbayartb = new System.Windows.Forms.TextBox();
            this.totalkembaliantb = new System.Windows.Forms.TextBox();
            this.bayar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.totaldiskon)).BeginInit();
            this.SuspendLayout();
            // 
            // subtotaltb
            // 
            this.subtotaltb.Location = new System.Drawing.Point(138, 63);
            this.subtotaltb.Name = "subtotaltb";
            this.subtotaltb.ReadOnly = true;
            this.subtotaltb.Size = new System.Drawing.Size(120, 23);
            this.subtotaltb.TabIndex = 0;
            // 
            // diskoncheckbox
            // 
            this.diskoncheckbox.AutoSize = true;
            this.diskoncheckbox.Location = new System.Drawing.Point(92, 92);
            this.diskoncheckbox.Name = "diskoncheckbox";
            this.diskoncheckbox.Size = new System.Drawing.Size(15, 14);
            this.diskoncheckbox.TabIndex = 1;
            this.diskoncheckbox.UseVisualStyleBackColor = true;
            this.diskoncheckbox.CheckStateChanged += new System.EventHandler(this.diskoncheckbox_CheckStateChanged);
            // 
            // totaldiskon
            // 
            this.totaldiskon.Location = new System.Drawing.Point(138, 92);
            this.totaldiskon.Name = "totaldiskon";
            this.totaldiskon.ReadOnly = true;
            this.totaldiskon.Size = new System.Drawing.Size(120, 23);
            this.totaldiskon.TabIndex = 2;
            this.totaldiskon.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totaldiskon_KeyUp);
            // 
            // idnotatb
            // 
            this.idnotatb.Location = new System.Drawing.Point(138, 34);
            this.idnotatb.Name = "idnotatb";
            this.idnotatb.ReadOnly = true;
            this.idnotatb.Size = new System.Drawing.Size(120, 23);
            this.idnotatb.TabIndex = 3;
            // 
            // totalakhirtb
            // 
            this.totalakhirtb.Location = new System.Drawing.Point(138, 121);
            this.totalakhirtb.Name = "totalakhirtb";
            this.totalakhirtb.Size = new System.Drawing.Size(120, 23);
            this.totalakhirtb.TabIndex = 5;
            // 
            // totalbayartb
            // 
            this.totalbayartb.Location = new System.Drawing.Point(138, 150);
            this.totalbayartb.Name = "totalbayartb";
            this.totalbayartb.Size = new System.Drawing.Size(120, 23);
            this.totalbayartb.TabIndex = 4;
            this.totalbayartb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.totalbayartb_KeyDown);
            this.totalbayartb.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totalbayartb_KeyUp);
            // 
            // totalkembaliantb
            // 
            this.totalkembaliantb.Location = new System.Drawing.Point(138, 179);
            this.totalkembaliantb.Name = "totalkembaliantb";
            this.totalkembaliantb.Size = new System.Drawing.Size(120, 23);
            this.totalkembaliantb.TabIndex = 6;
            // 
            // bayar
            // 
            this.bayar.Location = new System.Drawing.Point(92, 208);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(75, 23);
            this.bayar.TabIndex = 7;
            this.bayar.Text = "Bayar";
            this.bayar.UseVisualStyleBackColor = true;
            this.bayar.Click += new System.EventHandler(this.bayar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Nota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Diskon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total Akhir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bayar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kembalian";
            // 
            // formpembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 246);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.totalkembaliantb);
            this.Controls.Add(this.totalakhirtb);
            this.Controls.Add(this.totalbayartb);
            this.Controls.Add(this.idnotatb);
            this.Controls.Add(this.totaldiskon);
            this.Controls.Add(this.diskoncheckbox);
            this.Controls.Add(this.subtotaltb);
            this.Name = "formpembayaran";
            this.Text = "Pembayaran";
            this.Load += new System.EventHandler(this.formpembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totaldiskon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox subtotaltb;
        private System.Windows.Forms.CheckBox diskoncheckbox;
        private System.Windows.Forms.NumericUpDown totaldiskon;
        private System.Windows.Forms.TextBox idnotatb;
        private System.Windows.Forms.TextBox totalakhirtb;
        private System.Windows.Forms.TextBox totalbayartb;
        private System.Windows.Forms.TextBox totalkembaliantb;
        private System.Windows.Forms.Button bayar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}