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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_frm));
            this.para_list_btn = new System.Windows.Forms.Button();
            this.satis_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.cikisadmin = new System.Windows.Forms.Button();
            this.tumkullanicilar = new System.Windows.Forms.DataGridView();
            this.adminpnl = new System.Windows.Forms.Label();
            this.kullanici_sayisi = new System.Windows.Forms.Label();
            this.tkullanicisay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tumkullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // para_list_btn
            // 
            this.para_list_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.para_list_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.para_list_btn.Location = new System.Drawing.Point(18, 329);
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
            this.satis_btn.Location = new System.Drawing.Point(310, 329);
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
            this.cikis_btn.Location = new System.Drawing.Point(616, 329);
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
            // tumkullanicilar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tumkullanicilar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tumkullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tumkullanicilar.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tumkullanicilar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tumkullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tumkullanicilar.DefaultCellStyle = dataGridViewCellStyle3;
            this.tumkullanicilar.GridColor = System.Drawing.Color.Black;
            this.tumkullanicilar.Location = new System.Drawing.Point(18, 66);
            this.tumkullanicilar.Name = "tumkullanicilar";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tumkullanicilar.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tumkullanicilar.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tumkullanicilar.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tumkullanicilar.Size = new System.Drawing.Size(715, 226);
            this.tumkullanicilar.TabIndex = 17;
            // 
            // adminpnl
            // 
            this.adminpnl.AutoSize = true;
            this.adminpnl.BackColor = System.Drawing.Color.Transparent;
            this.adminpnl.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminpnl.ForeColor = System.Drawing.Color.Wheat;
            this.adminpnl.Location = new System.Drawing.Point(196, 9);
            this.adminpnl.Name = "adminpnl";
            this.adminpnl.Size = new System.Drawing.Size(365, 57);
            this.adminpnl.TabIndex = 18;
            this.adminpnl.Text = "Admin Paneli";
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
            // tkullanicisay
            // 
            this.tkullanicisay.AutoSize = true;
            this.tkullanicisay.BackColor = System.Drawing.Color.Transparent;
            this.tkullanicisay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tkullanicisay.ForeColor = System.Drawing.Color.White;
            this.tkullanicisay.Location = new System.Drawing.Point(13, 34);
            this.tkullanicisay.Name = "tkullanicisay";
            this.tkullanicisay.Size = new System.Drawing.Size(116, 26);
            this.tkullanicisay.TabIndex = 20;
            this.tkullanicisay.Text = "Toplam Kullanıcı  \r\n       Sayısı            ";
            // 
            // admin_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.tkullanicisay);
            this.Controls.Add(this.kullanici_sayisi);
            this.Controls.Add(this.adminpnl);
            this.Controls.Add(this.tumkullanicilar);
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
            ((System.ComponentModel.ISupportInitialize)(this.tumkullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button para_list_btn;
        private System.Windows.Forms.Button satis_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.Button cikisadmin;
        private System.Windows.Forms.DataGridView tumkullanicilar;
        private System.Windows.Forms.Label adminpnl;
        private System.Windows.Forms.Label kullanici_sayisi;
        private System.Windows.Forms.Label tkullanicisay;
    }
}