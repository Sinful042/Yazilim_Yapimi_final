namespace Proje_Ödevi
{
    partial class kayit_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayit_frm));
            this.kayit_btn = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.kullanici_adi = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tc = new System.Windows.Forms.TextBox();
            this.adres = new System.Windows.Forms.TextBox();
            this.cikiskayit = new System.Windows.Forms.Button();
            this.gerikayit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretekrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kayit_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.kayit_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.kayit_btn.Location = new System.Drawing.Point(357, 383);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(122, 39);
            this.kayit_btn.TabIndex = 8;
            this.kayit_btn.Text = "Kayıt Ol";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // ad
            // 
            this.ad.BackColor = System.Drawing.SystemColors.Window;
            this.ad.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.ad.ForeColor = System.Drawing.Color.Silver;
            this.ad.Location = new System.Drawing.Point(156, 24);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(200, 27);
            this.ad.TabIndex = 9;
            this.ad.Text = "Ad";
            this.ad.TextChanged += new System.EventHandler(this.ad_TextChanged);
            this.ad.Enter += new System.EventHandler(this.ad_Enter);
            this.ad.Leave += new System.EventHandler(this.ad_Leave);
            // 
            // soyad
            // 
            this.soyad.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.soyad.ForeColor = System.Drawing.Color.Silver;
            this.soyad.Location = new System.Drawing.Point(156, 64);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(200, 27);
            this.soyad.TabIndex = 10;
            this.soyad.Text = "Soyad";
            this.soyad.Enter += new System.EventHandler(this.soyad_Enter);
            this.soyad.Leave += new System.EventHandler(this.soyad_Leave);
            // 
            // kullanici_adi
            // 
            this.kullanici_adi.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.kullanici_adi.ForeColor = System.Drawing.Color.Silver;
            this.kullanici_adi.Location = new System.Drawing.Point(156, 104);
            this.kullanici_adi.Name = "kullanici_adi";
            this.kullanici_adi.Size = new System.Drawing.Size(200, 27);
            this.kullanici_adi.TabIndex = 11;
            this.kullanici_adi.Text = "Kullanıcı-Adı";
            this.kullanici_adi.Enter += new System.EventHandler(this.kullanici_adi_Enter);
            this.kullanici_adi.Leave += new System.EventHandler(this.kullanici_adi_Leave);
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(156, 265);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(200, 27);
            this.email.TabIndex = 13;
            this.email.Text = "E-mail";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // telefon
            // 
            this.telefon.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.telefon.ForeColor = System.Drawing.Color.Silver;
            this.telefon.Location = new System.Drawing.Point(156, 345);
            this.telefon.MaxLength = 11;
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(200, 27);
            this.telefon.TabIndex = 14;
            this.telefon.Text = "Telefon";
            this.telefon.Enter += new System.EventHandler(this.telefon_Enter);
            this.telefon.Leave += new System.EventHandler(this.telefon_Leave);
            // 
            // sifre
            // 
            this.sifre.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.sifre.ForeColor = System.Drawing.Color.Silver;
            this.sifre.Location = new System.Drawing.Point(156, 144);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(200, 27);
            this.sifre.TabIndex = 15;
            this.sifre.Text = "Parola";
            this.sifre.Enter += new System.EventHandler(this.sifre_Enter);
            this.sifre.Leave += new System.EventHandler(this.sifre_Leave);
            // 
            // tc
            // 
            this.tc.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.tc.ForeColor = System.Drawing.Color.Silver;
            this.tc.Location = new System.Drawing.Point(156, 225);
            this.tc.MaxLength = 11;
            this.tc.Name = "tc";
            this.tc.Size = new System.Drawing.Size(200, 27);
            this.tc.TabIndex = 16;
            this.tc.Text = "TC";
            this.tc.Enter += new System.EventHandler(this.tc_Enter);
            this.tc.Leave += new System.EventHandler(this.tc_Leave);
            // 
            // adres
            // 
            this.adres.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.adres.ForeColor = System.Drawing.Color.Silver;
            this.adres.Location = new System.Drawing.Point(156, 305);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(200, 27);
            this.adres.TabIndex = 17;
            this.adres.Text = "Adres";
            this.adres.Enter += new System.EventHandler(this.adres_Enter);
            this.adres.Leave += new System.EventHandler(this.adres_Leave);
            // 
            // cikiskayit
            // 
            this.cikiskayit.BackColor = System.Drawing.Color.Transparent;
            this.cikiskayit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikiskayit.FlatAppearance.BorderSize = 0;
            this.cikiskayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikiskayit.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikiskayit.ForeColor = System.Drawing.Color.Brown;
            this.cikiskayit.Location = new System.Drawing.Point(468, -2);
            this.cikiskayit.Name = "cikiskayit";
            this.cikiskayit.Size = new System.Drawing.Size(32, 36);
            this.cikiskayit.TabIndex = 18;
            this.cikiskayit.Text = "X";
            this.cikiskayit.UseVisualStyleBackColor = false;
            this.cikiskayit.Click += new System.EventHandler(this.cikiskayit_Click);
            // 
            // gerikayit
            // 
            this.gerikayit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gerikayit.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.gerikayit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gerikayit.Location = new System.Drawing.Point(12, 383);
            this.gerikayit.Name = "gerikayit";
            this.gerikayit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gerikayit.Size = new System.Drawing.Size(122, 39);
            this.gerikayit.TabIndex = 19;
            this.gerikayit.Text = "Geri";
            this.gerikayit.UseVisualStyleBackColor = false;
            this.gerikayit.Click += new System.EventHandler(this.gerikayit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(-6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 47);
            this.label2.TabIndex = 20;
            this.label2.Text = "Üye Ol";
            // 
            // sifretekrar
            // 
            this.sifretekrar.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.sifretekrar.ForeColor = System.Drawing.Color.Silver;
            this.sifretekrar.Location = new System.Drawing.Point(156, 185);
            this.sifretekrar.Name = "sifretekrar";
            this.sifretekrar.Size = new System.Drawing.Size(200, 27);
            this.sifretekrar.TabIndex = 22;
            this.sifretekrar.Text = "Parola-Tekrar";
            this.sifretekrar.Enter += new System.EventHandler(this.sifretekrar_Enter);
            this.sifretekrar.Leave += new System.EventHandler(this.sifretekrar_Leave);
            // 
            // kayit_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(498, 473);
            this.Controls.Add(this.sifretekrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gerikayit);
            this.Controls.Add(this.cikiskayit);
            this.Controls.Add(this.adres);
            this.Controls.Add(this.tc);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.email);
            this.Controls.Add(this.kullanici_adi);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.kayit_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kayit_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.Load += new System.EventHandler(this.kayit_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox kullanici_adi;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.TextBox tc;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Button cikiskayit;
        private System.Windows.Forms.Button gerikayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifretekrar;
    }
}