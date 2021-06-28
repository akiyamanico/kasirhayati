
namespace hayati
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Font = new System.Drawing.Font("Caviar Dreams", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountmenu,
            this.laporanmenu,
            this.transaksimenu,
            this.mastermenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.loginbutton.Size = new System.Drawing.Size(116, 22);
            this.loginbutton.Text = "Login";
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(116, 22);
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(116, 22);
            this.exitbutton.Text = "Exit";
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // laporanmenu
            // 
            this.laporanmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laporanpenjualan});
            this.laporanmenu.Name = "laporanmenu";
            this.laporanmenu.Size = new System.Drawing.Size(70, 20);
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
            this.transaksimenu.Size = new System.Drawing.Size(72, 20);
            this.transaksimenu.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem
            // 
            this.penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            this.penjualanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.penjualanToolStripMenuItem.Text = "Penjualan";
            this.penjualanToolStripMenuItem.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // mastermenu
            // 
            this.mastermenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockToolStripMenuItem});
            this.mastermenu.Name = "mastermenu";
            this.mastermenu.Size = new System.Drawing.Size(59, 20);
            this.mastermenu.Text = "Master";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("SF Pro Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Hayati Store - Kasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem laporanpenjualan;
        private System.Windows.Forms.ToolStripMenuItem penjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem laporanmenu;
        public System.Windows.Forms.ToolStripMenuItem transaksimenu;
        public System.Windows.Forms.ToolStripMenuItem mastermenu;
        public System.Windows.Forms.ToolStripMenuItem accountmenu;
        public System.Windows.Forms.ToolStripMenuItem loginbutton;
        public System.Windows.Forms.ToolStripMenuItem logoutbutton;
        public System.Windows.Forms.ToolStripMenuItem exitbutton;
    }
}

