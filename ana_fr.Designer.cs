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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ana_fr));
            this.kullanici_lbl = new System.Windows.Forms.Label();
            this.para_lbl = new System.Windows.Forms.Label();
            this.satis_btn = new System.Windows.Forms.Button();
            this.ürün_al_btn = new System.Windows.Forms.Button();
            this.para_ekle_btn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cikisanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // kullanici_lbl
            // 
            this.kullanici_lbl.AutoSize = true;
            this.kullanici_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_lbl.Font = new System.Drawing.Font("Stencil", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.kullanici_lbl.ForeColor = System.Drawing.Color.Cornsilk;
            this.kullanici_lbl.Location = new System.Drawing.Point(64, 18);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(171, 26);
            this.kullanici_lbl.TabIndex = 0;
            this.kullanici_lbl.Text = "Kullanıcı Adı";
            this.kullanici_lbl.Click += new System.EventHandler(this.kullanici_lbl_Click);
            // 
            // para_lbl
            // 
            this.para_lbl.AutoSize = true;
            this.para_lbl.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.para_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.para_lbl.ForeColor = System.Drawing.Color.DarkGreen;
            this.para_lbl.Location = new System.Drawing.Point(670, 21);
            this.para_lbl.Name = "para_lbl";
            this.para_lbl.Size = new System.Drawing.Size(53, 25);
            this.para_lbl.TabIndex = 1;
            this.para_lbl.Text = "Para";
            this.para_lbl.Click += new System.EventHandler(this.para_lbl_Click);
            // 
            // satis_btn
            // 
            this.satis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satis_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.satis_btn.Location = new System.Drawing.Point(25, 338);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(117, 37);
            this.satis_btn.TabIndex = 2;
            this.satis_btn.Text = "Satış Yap";
            this.satis_btn.UseVisualStyleBackColor = false;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // ürün_al_btn
            // 
            this.ürün_al_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ürün_al_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ürün_al_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.ürün_al_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ürün_al_btn.Location = new System.Drawing.Point(214, 338);
            this.ürün_al_btn.Name = "ürün_al_btn";
            this.ürün_al_btn.Size = new System.Drawing.Size(117, 37);
            this.ürün_al_btn.TabIndex = 3;
            this.ürün_al_btn.Text = "Ürün Al";
            this.ürün_al_btn.UseVisualStyleBackColor = false;
            this.ürün_al_btn.Click += new System.EventHandler(this.ürün_al_btn_Click);
            // 
            // para_ekle_btn
            // 
            this.para_ekle_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.para_ekle_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.para_ekle_btn.Location = new System.Drawing.Point(426, 338);
            this.para_ekle_btn.Name = "para_ekle_btn";
            this.para_ekle_btn.Size = new System.Drawing.Size(117, 37);
            this.para_ekle_btn.TabIndex = 4;
            this.para_ekle_btn.Text = "Para Ekle";
            this.para_ekle_btn.UseVisualStyleBackColor = false;
            this.para_ekle_btn.Click += new System.EventHandler(this.para_ekle_btn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.button4.Location = new System.Drawing.Point(607, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 37);
            this.button4.TabIndex = 5;
            this.button4.Text = "Çıkış Yap";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 236);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(640, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "$";
            // 
            // cikisanasayfa
            // 
            this.cikisanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.cikisanasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisanasayfa.FlatAppearance.BorderSize = 0;
            this.cikisanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisanasayfa.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisanasayfa.ForeColor = System.Drawing.Color.Brown;
            this.cikisanasayfa.Location = new System.Drawing.Point(744, -3);
            this.cikisanasayfa.Name = "cikisanasayfa";
            this.cikisanasayfa.Size = new System.Drawing.Size(32, 36);
            this.cikisanasayfa.TabIndex = 8;
            this.cikisanasayfa.Text = "X";
            this.cikisanasayfa.UseVisualStyleBackColor = false;
            this.cikisanasayfa.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // ana_fr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.cikisanasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.para_ekle_btn);
            this.Controls.Add(this.ürün_al_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_lbl);
            this.Controls.Add(this.kullanici_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ana_fr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.ana_fr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.Label para_lbl;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button ürün_al_btn;
        private System.Windows.Forms.Button para_ekle_btn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cikisanasayfa;
    }
}