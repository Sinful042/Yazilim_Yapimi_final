namespace Proje_Ödevi
{
    partial class ana_fr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_fr));
            this.kullanici_lbl = new System.Windows.Forms.Label();
            this.para_lbl = new System.Windows.Forms.Label();
            this.satis_btn = new System.Windows.Forms.Button();
            this.urun_al_btn = new System.Windows.Forms.Button();
            this.para_ekle_btn = new System.Windows.Forms.Button();
            this.hesapkapat = new System.Windows.Forms.Button();
            this.urunlistele = new System.Windows.Forms.DataGridView();
            this.tl = new System.Windows.Forms.Label();
            this.cikisanasayfa = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.urunlistele)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_lbl
            // 
            this.kullanici_lbl.AutoSize = true;
            this.kullanici_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.kullanici_lbl.ForeColor = System.Drawing.Color.White;
            this.kullanici_lbl.Location = new System.Drawing.Point(161, 125);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(129, 23);
            this.kullanici_lbl.TabIndex = 0;
            this.kullanici_lbl.Text = "Kullanıcı Adı";
            
            // 
            // para_lbl
            // 
            this.para_lbl.AutoSize = true;
            this.para_lbl.BackColor = System.Drawing.Color.Transparent;
            this.para_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.para_lbl.ForeColor = System.Drawing.Color.White;
            this.para_lbl.Location = new System.Drawing.Point(549, 125);
            this.para_lbl.Name = "para_lbl";
            this.para_lbl.Size = new System.Drawing.Size(52, 23);
            this.para_lbl.TabIndex = 1;
            this.para_lbl.Text = "Para";
            // 
            // satis_btn
            // 
            this.satis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satis_btn.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satis_btn.Location = new System.Drawing.Point(122, 439);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(138, 30);
            this.satis_btn.TabIndex = 2;
            this.satis_btn.Text = "Satış Yap";
            this.satis_btn.UseVisualStyleBackColor = false;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // urun_al_btn
            // 
            this.urun_al_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.urun_al_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.urun_al_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.urun_al_btn.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.urun_al_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.urun_al_btn.Location = new System.Drawing.Point(260, 439);
            this.urun_al_btn.Name = "urun_al_btn";
            this.urun_al_btn.Size = new System.Drawing.Size(138, 30);
            this.urun_al_btn.TabIndex = 3;
            this.urun_al_btn.Text = "Ürün Al";
            this.urun_al_btn.UseVisualStyleBackColor = false;
            this.urun_al_btn.Click += new System.EventHandler(this.ürün_al_btn_Click);
            // 
            // para_ekle_btn
            // 
            this.para_ekle_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.para_ekle_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.para_ekle_btn.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.para_ekle_btn.Location = new System.Drawing.Point(398, 439);
            this.para_ekle_btn.Name = "para_ekle_btn";
            this.para_ekle_btn.Size = new System.Drawing.Size(138, 30);
            this.para_ekle_btn.TabIndex = 4;
            this.para_ekle_btn.Text = "Para Ekle";
            this.para_ekle_btn.UseVisualStyleBackColor = false;
            this.para_ekle_btn.Click += new System.EventHandler(this.para_ekle_btn_Click);
            // 
            // hesapkapat
            // 
            this.hesapkapat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hesapkapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapkapat.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.hesapkapat.Location = new System.Drawing.Point(536, 439);
            this.hesapkapat.Name = "hesapkapat";
            this.hesapkapat.Size = new System.Drawing.Size(137, 30);
            this.hesapkapat.TabIndex = 5;
            this.hesapkapat.Text = "Çıkış Yap";
            this.hesapkapat.UseVisualStyleBackColor = false;
            this.hesapkapat.Click += new System.EventHandler(this.button4_Click);
            // 
            // urunlistele
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunlistele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.urunlistele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.urunlistele.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlistele.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.urunlistele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.urunlistele.DefaultCellStyle = dataGridViewCellStyle3;
            this.urunlistele.GridColor = System.Drawing.Color.Black;
            this.urunlistele.Location = new System.Drawing.Point(122, 151);
            this.urunlistele.Name = "urunlistele";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.urunlistele.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.urunlistele.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.urunlistele.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.urunlistele.Size = new System.Drawing.Size(551, 288);
            this.urunlistele.TabIndex = 6;
            
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.BackColor = System.Drawing.Color.Transparent;
            this.tl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.tl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tl.Location = new System.Drawing.Point(521, 125);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(22, 23);
            this.tl.TabIndex = 7;
            this.tl.Text = "₺";
            // 
            // cikisanasayfa
            // 
            this.cikisanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.cikisanasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisanasayfa.FlatAppearance.BorderSize = 0;
            this.cikisanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisanasayfa.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisanasayfa.ForeColor = System.Drawing.Color.Brown;
            this.cikisanasayfa.Location = new System.Drawing.Point(775, 0);
            this.cikisanasayfa.Name = "cikisanasayfa";
            this.cikisanasayfa.Size = new System.Drawing.Size(26, 35);
            this.cikisanasayfa.TabIndex = 8;
            this.cikisanasayfa.Text = "X";
            this.cikisanasayfa.UseVisualStyleBackColor = false;
            this.cikisanasayfa.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avatar.ForeColor = System.Drawing.Color.LightGray;
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(121, 118);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(38, 37);
            this.avatar.TabIndex = 9;
            this.avatar.UseVisualStyleBackColor = false;
            this.avatar.Click += new System.EventHandler(this.avatar_Click);
            // 
            // ana_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.cikisanasayfa);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.urunlistele);
            this.Controls.Add(this.hesapkapat);
            this.Controls.Add(this.para_ekle_btn);
            this.Controls.Add(this.urun_al_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_lbl);
            this.Controls.Add(this.kullanici_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ana_fr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.ana_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlistele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.Label para_lbl;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button urun_al_btn;
        private System.Windows.Forms.Button para_ekle_btn;
        private System.Windows.Forms.Button hesapkapat;
        private System.Windows.Forms.DataGridView urunlistele;
        private System.Windows.Forms.Label tl;
        private System.Windows.Forms.Button cikisanasayfa;
        private System.Windows.Forms.Button avatar;
    }
}