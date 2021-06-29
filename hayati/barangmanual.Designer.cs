
namespace hayati
{
    partial class barangmanual
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.updatedata = new System.Windows.Forms.Button();
            this.barcodemanualtb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(21, 142);
            this.dgv1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 72;
            this.dgv1.RowTemplate.Height = 25;
            this.dgv1.Size = new System.Drawing.Size(1443, 476);
            this.dgv1.TabIndex = 1;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // updatedata
            // 
            this.updatedata.Location = new System.Drawing.Point(647, 630);
            this.updatedata.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.updatedata.Name = "updatedata";
            this.updatedata.Size = new System.Drawing.Size(251, 46);
            this.updatedata.TabIndex = 2;
            this.updatedata.Text = "Masukan Data";
            this.updatedata.UseVisualStyleBackColor = true;
            this.updatedata.Click += new System.EventHandler(this.updatedata_Click);
            // 
            // barcodemanualtb
            // 
            this.barcodemanualtb.Location = new System.Drawing.Point(1089, 98);
            this.barcodemanualtb.Name = "barcodemanualtb";
            this.barcodemanualtb.Size = new System.Drawing.Size(375, 35);
            this.barcodemanualtb.TabIndex = 3;
            // 
            // barangmanual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 706);
            this.Controls.Add(this.barcodemanualtb);
            this.Controls.Add(this.updatedata);
            this.Controls.Add(this.dgv1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "barangmanual";
            this.Text = "barangmanual";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.barangmanual_FormClosing);
            this.Load += new System.EventHandler(this.barangmanual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button updatedata;
        public System.Windows.Forms.TextBox barcodemanualtb;
    }
}