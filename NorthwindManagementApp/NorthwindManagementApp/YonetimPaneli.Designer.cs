namespace NorthwindManagementApp
{
    partial class frm_YonetimPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YonetimPaneli));
            this.ms_MenuSeridi = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kategori = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_DurumSeridi = new System.Windows.Forms.StatusStrip();
            this.ms_MenuSeridi.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_MenuSeridi
            // 
            this.ms_MenuSeridi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_MenuSeridi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ürünToolStripMenuItem});
            this.ms_MenuSeridi.Location = new System.Drawing.Point(0, 0);
            this.ms_MenuSeridi.Name = "ms_MenuSeridi";
            this.ms_MenuSeridi.Size = new System.Drawing.Size(1206, 30);
            this.ms_MenuSeridi.TabIndex = 0;
            this.ms_MenuSeridi.Text = "Yönetim Menüsü";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 26);
            this.toolStripMenuItem1.Text = "Dosya";
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Kategori});
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.ürünToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // TSMI_Kategori
            // 
            this.TSMI_Kategori.Name = "TSMI_Kategori";
            this.TSMI_Kategori.Size = new System.Drawing.Size(224, 26);
            this.TSMI_Kategori.Text = "Kategori";
            this.TSMI_Kategori.Click += new System.EventHandler(this.TSMI_Kategori_Click);
            // 
            // ss_DurumSeridi
            // 
            this.ss_DurumSeridi.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_DurumSeridi.Location = new System.Drawing.Point(0, 1033);
            this.ss_DurumSeridi.Name = "ss_DurumSeridi";
            this.ss_DurumSeridi.Size = new System.Drawing.Size(1206, 22);
            this.ss_DurumSeridi.TabIndex = 1;
            this.ss_DurumSeridi.Text = "statusStrip1";
            // 
            // frm_YonetimPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 1055);
            this.Controls.Add(this.ss_DurumSeridi);
            this.Controls.Add(this.ms_MenuSeridi);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_MenuSeridi;
            this.Name = "frm_YonetimPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetim Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_YonetimPaneli_Load);
            this.ms_MenuSeridi.ResumeLayout(false);
            this.ms_MenuSeridi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_MenuSeridi;
        private System.Windows.Forms.StatusStrip ss_DurumSeridi;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Kategori;
    }
}