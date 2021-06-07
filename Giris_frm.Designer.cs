namespace Proje_Ödevi
{
    partial class Giris_frm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris_frm));
            this.label2 = new System.Windows.Forms.Label();
            this.kullacini_txt = new System.Windows.Forms.TextBox();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.gris_btn = new System.Windows.Forms.Button();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.cikisgiris = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(139, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sinence";
            // 
            // kullacini_txt
            // 
            this.kullacini_txt.BackColor = System.Drawing.SystemColors.Window;
            this.kullacini_txt.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullacini_txt.ForeColor = System.Drawing.Color.Silver;
            this.kullacini_txt.Location = new System.Drawing.Point(118, 276);
            this.kullacini_txt.Name = "kullacini_txt";
            this.kullacini_txt.Size = new System.Drawing.Size(255, 27);
            this.kullacini_txt.TabIndex = 2;
            this.kullacini_txt.Text = "Kullanıcı-Adı";
            this.kullacini_txt.Enter += new System.EventHandler(this.kullacini_txt_Enter);
            this.kullacini_txt.Leave += new System.EventHandler(this.kullacini_txt_Leave);
            // 
            // sifre_txt
            // 
            this.sifre_txt.BackColor = System.Drawing.SystemColors.Window;
            this.sifre_txt.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.sifre_txt.ForeColor = System.Drawing.Color.Silver;
            this.sifre_txt.Location = new System.Drawing.Point(118, 340);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.Size = new System.Drawing.Size(255, 27);
            this.sifre_txt.TabIndex = 3;
            this.sifre_txt.Text = "Parola";
            this.sifre_txt.Enter += new System.EventHandler(this.sifre_txt_Enter);
            this.sifre_txt.Leave += new System.EventHandler(this.sifre_txt_Leave);
            // 
            // gris_btn
            // 
            this.gris_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.gris_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gris_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.gris_btn.Location = new System.Drawing.Point(118, 390);
            this.gris_btn.Name = "gris_btn";
            this.gris_btn.Size = new System.Drawing.Size(117, 37);
            this.gris_btn.TabIndex = 4;
            this.gris_btn.Text = "Giriş Yap";
            this.gris_btn.UseVisualStyleBackColor = false;
            this.gris_btn.Click += new System.EventHandler(this.gris_btn_Click);
            // 
            // kayit_btn
            // 
            this.kayit_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kayit_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.kayit_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.kayit_btn.Location = new System.Drawing.Point(256, 390);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(117, 37);
            this.kayit_btn.TabIndex = 5;
            this.kayit_btn.Text = "Kayıt Ol";
            this.kayit_btn.UseVisualStyleBackColor = false;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // cikisgiris
            // 
            this.cikisgiris.BackColor = System.Drawing.Color.Transparent;
            this.cikisgiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisgiris.FlatAppearance.BorderSize = 0;
            this.cikisgiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisgiris.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisgiris.ForeColor = System.Drawing.Color.Brown;
            this.cikisgiris.Location = new System.Drawing.Point(468, -2);
            this.cikisgiris.Name = "cikisgiris";
            this.cikisgiris.Size = new System.Drawing.Size(32, 36);
            this.cikisgiris.TabIndex = 6;
            this.cikisgiris.Text = "X";
            this.cikisgiris.UseVisualStyleBackColor = false;
            this.cikisgiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(185, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 120);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(127, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "BORSASI";
            // 
            // Giris_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cikisgiris);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.gris_btn);
            this.Controls.Add(this.sifre_txt);
            this.Controls.Add(this.kullacini_txt);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Giris_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            this.Load += new System.EventHandler(this.Giris_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullacini_txt;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.Button gris_btn;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.Button cikisgiris;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

