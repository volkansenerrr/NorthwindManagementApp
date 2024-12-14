namespace NorthwindManagementApp
{
    partial class frm_YoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YoneticiGiris));
            this.gb_KullaniciGiris = new System.Windows.Forms.GroupBox();
            this.btn_Kapat = new System.Windows.Forms.Button();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.pb_YoneticiGiris = new System.Windows.Forms.PictureBox();
            this.tb_Sifre = new System.Windows.Forms.TextBox();
            this.tb_KullaniciAdi = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_KullaniciAdi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_KullaniciGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_YoneticiGiris)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_KullaniciGiris
            // 
            this.gb_KullaniciGiris.Controls.Add(this.btn_Kapat);
            this.gb_KullaniciGiris.Controls.Add(this.btn_Giris);
            this.gb_KullaniciGiris.Controls.Add(this.pb_YoneticiGiris);
            this.gb_KullaniciGiris.Controls.Add(this.tb_Sifre);
            this.gb_KullaniciGiris.Controls.Add(this.tb_KullaniciAdi);
            this.gb_KullaniciGiris.Controls.Add(this.lbl_Sifre);
            this.gb_KullaniciGiris.Controls.Add(this.lbl_KullaniciAdi);
            this.gb_KullaniciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gb_KullaniciGiris.Location = new System.Drawing.Point(12, 12);
            this.gb_KullaniciGiris.Name = "gb_KullaniciGiris";
            this.gb_KullaniciGiris.Size = new System.Drawing.Size(671, 552);
            this.gb_KullaniciGiris.TabIndex = 0;
            this.gb_KullaniciGiris.TabStop = false;
            this.gb_KullaniciGiris.Text = "Kullanıcı Giriş";
            // 
            // btn_Kapat
            // 
            this.btn_Kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Kapat.Location = new System.Drawing.Point(447, 415);
            this.btn_Kapat.Name = "btn_Kapat";
            this.btn_Kapat.Size = new System.Drawing.Size(109, 38);
            this.btn_Kapat.TabIndex = 6;
            this.btn_Kapat.Text = "Kapat";
            this.btn_Kapat.UseVisualStyleBackColor = true;
            this.btn_Kapat.Click += new System.EventHandler(this.btn_Kapat_Click);
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(314, 415);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(116, 38);
            this.btn_Giris.TabIndex = 5;
            this.btn_Giris.Text = "Giriş Yap";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // pb_YoneticiGiris
            // 
            this.pb_YoneticiGiris.Image = ((System.Drawing.Image)(resources.GetObject("pb_YoneticiGiris.Image")));
            this.pb_YoneticiGiris.Location = new System.Drawing.Point(6, 33);
            this.pb_YoneticiGiris.Name = "pb_YoneticiGiris";
            this.pb_YoneticiGiris.Size = new System.Drawing.Size(659, 175);
            this.pb_YoneticiGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_YoneticiGiris.TabIndex = 4;
            this.pb_YoneticiGiris.TabStop = false;
            // 
            // tb_Sifre
            // 
            this.tb_Sifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_Sifre.Location = new System.Drawing.Point(258, 367);
            this.tb_Sifre.Name = "tb_Sifre";
            this.tb_Sifre.Size = new System.Drawing.Size(298, 27);
            this.tb_Sifre.TabIndex = 3;
            // 
            // tb_KullaniciAdi
            // 
            this.tb_KullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_KullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_KullaniciAdi.Location = new System.Drawing.Point(258, 323);
            this.tb_KullaniciAdi.Name = "tb_KullaniciAdi";
            this.tb_KullaniciAdi.Size = new System.Drawing.Size(298, 27);
            this.tb_KullaniciAdi.TabIndex = 2;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(177, 366);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(75, 29);
            this.lbl_Sifre.TabIndex = 1;
            this.lbl_Sifre.Text = "Şifre :";
            // 
            // lbl_KullaniciAdi
            // 
            this.lbl_KullaniciAdi.AutoSize = true;
            this.lbl_KullaniciAdi.Location = new System.Drawing.Point(95, 322);
            this.lbl_KullaniciAdi.Name = "lbl_KullaniciAdi";
            this.lbl_KullaniciAdi.Size = new System.Drawing.Size(157, 29);
            this.lbl_KullaniciAdi.TabIndex = 0;
            this.lbl_KullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // frm_YoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(695, 576);
            this.Controls.Add(this.gb_KullaniciGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_YoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Northwind Yönetim Giriş";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GirisForm_FormClosing);
            this.gb_KullaniciGiris.ResumeLayout(false);
            this.gb_KullaniciGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_YoneticiGiris)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_KullaniciGiris;
        private System.Windows.Forms.TextBox tb_Sifre;
        private System.Windows.Forms.TextBox tb_KullaniciAdi;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_KullaniciAdi;
        private System.Windows.Forms.PictureBox pb_YoneticiGiris;
        private System.Windows.Forms.Button btn_Kapat;
        private System.Windows.Forms.Button btn_Giris;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

