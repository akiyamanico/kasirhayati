﻿
namespace hayati
{
    partial class formlaporanpenjualan
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
            this.exitbuttonreport = new System.Windows.Forms.Button();
            this.printreport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // exitbuttonreport
            // 
            this.exitbuttonreport.Location = new System.Drawing.Point(713, 390);
            this.exitbuttonreport.Name = "exitbuttonreport";
            this.exitbuttonreport.Size = new System.Drawing.Size(75, 23);
            this.exitbuttonreport.TabIndex = 1;
            this.exitbuttonreport.Text = "Keluar";
            this.exitbuttonreport.UseVisualStyleBackColor = true;
            this.exitbuttonreport.Click += new System.EventHandler(this.exitbuttonreport_Click);
            // 
            // printreport
            // 
            this.printreport.Location = new System.Drawing.Point(12, 390);
            this.printreport.Name = "printreport";
            this.printreport.Size = new System.Drawing.Size(141, 23);
            this.printreport.TabIndex = 2;
            this.printreport.Text = "Cetak Laporan";
            this.printreport.UseVisualStyleBackColor = true;
            this.printreport.Click += new System.EventHandler(this.printreport_Click);
            // 
            // formlaporanpenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.printreport);
            this.Controls.Add(this.exitbuttonreport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formlaporanpenjualan";
            this.Text = "Form Laporan Penjualan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exitbuttonreport;
        private System.Windows.Forms.Button printreport;
    }
}