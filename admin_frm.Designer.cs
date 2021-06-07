namespace Proje_Ödevi
{
    partial class admin_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_frm));
            this.para_list_btn = new System.Windows.Forms.Button();
            this.satis_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.cikisadmin = new System.Windows.Forms.Button();
            this.dataGridViewSo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.kullanici_sayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).BeginInit();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.para_list_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.para_list_btn.Location = new System.Drawing.Point(36, 316);
            this.para_list_btn.Name = "para_list_btn";
            this.para_list_btn.Size = new System.Drawing.Size(138, 37);
            this.para_list_btn.TabIndex = 0;
            this.para_list_btn.Text = "Para İstekleri";
            this.para_list_btn.UseVisualStyleBackColor = true;
            this.para_list_btn.Click += new System.EventHandler(this.para_list_btn_Click);
            // 
            // satis_btn
            // 
            this.satis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.satis_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.satis_btn.Location = new System.Drawing.Point(310, 316);
            this.satis_btn.Name = "satis_btn";
            this.satis_btn.Size = new System.Drawing.Size(138, 37);
            this.satis_btn.TabIndex = 1;
            this.satis_btn.Text = "Satış İstekleri";
            this.satis_btn.UseVisualStyleBackColor = true;
            this.satis_btn.Click += new System.EventHandler(this.satis_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.cikis_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cikis_btn.Location = new System.Drawing.Point(589, 316);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(117, 37);
            this.cikis_btn.TabIndex = 2;
            this.cikis_btn.Text = "Çıkış";
            this.cikis_btn.UseVisualStyleBackColor = true;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // cikisadmin
            // 
            this.cikisadmin.BackColor = System.Drawing.Color.Transparent;
            this.cikisadmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisadmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisadmin.FlatAppearance.BorderSize = 0;
            this.cikisadmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisadmin.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisadmin.ForeColor = System.Drawing.Color.Brown;
            this.cikisadmin.Location = new System.Drawing.Point(730, -5);
            this.cikisadmin.Name = "cikisadmin";
            this.cikisadmin.Size = new System.Drawing.Size(32, 36);
            this.cikisadmin.TabIndex = 11;
            this.cikisadmin.Text = "X";
            this.cikisadmin.UseVisualStyleBackColor = false;
            this.cikisadmin.Click += new System.EventHandler(this.cikisadmin_Click);
            // 
            // dataGridViewSo
            // 
            this.dataGridViewSo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSo.Location = new System.Drawing.Point(18, 66);
            this.dataGridViewSo.Name = "dataGridViewSo";
            this.dataGridViewSo.Size = new System.Drawing.Size(715, 226);
            this.dataGridViewSo.TabIndex = 17;
            this.dataGridViewSo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSo_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 57);
            this.label2.TabIndex = 18;
            this.label2.Text = "Admin Paneli";
            // 
            // kullanici_sayisi
            // 
            this.kullanici_sayisi.AutoSize = true;
            this.kullanici_sayisi.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_sayisi.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanici_sayisi.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.kullanici_sayisi.Location = new System.Drawing.Point(125, 32);
            this.kullanici_sayisi.Name = "kullanici_sayisi";
            this.kullanici_sayisi.Size = new System.Drawing.Size(126, 24);
            this.kullanici_sayisi.TabIndex = 19;
            this.kullanici_sayisi.Text = "Kullanicisayi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Toplam Kullanıcı  \r\n       Sayısı            ";
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanici_sayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSo);
            this.Controls.Add(this.cikisadmin);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.satis_btn);
            this.Controls.Add(this.para_list_btn);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "admin_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button cikisadmin;
        private System.Windows.Forms.DataGridView dataGridViewSo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kullanici_sayisi;
        private System.Windows.Forms.Label label1;
    }
}