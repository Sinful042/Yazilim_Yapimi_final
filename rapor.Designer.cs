namespace Proje_Ödevi
{
    partial class rapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rapor));
            this.raporal = new System.Windows.Forms.Button();
            this.raporturu = new System.Windows.Forms.ComboBox();
            this.urunler = new System.Windows.Forms.ComboBox();
            this.Btarih = new System.Windows.Forms.ComboBox();
            this.Starih = new System.Windows.Forms.ComboBox();
            this.gerirapor = new System.Windows.Forms.Button();
            this.cikisrapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // raporal
            // 
            this.raporal.Location = new System.Drawing.Point(110, 334);
            this.raporal.Name = "raporal";
            this.raporal.Size = new System.Drawing.Size(100, 38);
            this.raporal.TabIndex = 0;
            this.raporal.Text = "rapor oluştur";
            this.raporal.UseVisualStyleBackColor = true;
            // 
            // raporturu
            // 
            this.raporturu.FormattingEnabled = true;
            this.raporturu.Items.AddRange(new object[] {
            "Alış Raporu",
            "Satış Raporu",
            "Alış-Satış Raporu"});
            this.raporturu.Location = new System.Drawing.Point(108, 215);
            this.raporturu.Name = "raporturu";
            this.raporturu.Size = new System.Drawing.Size(121, 21);
            this.raporturu.TabIndex = 1;
            this.raporturu.Text = "Rapor Tipi Seçiniz";
            // 
            // urunler
            // 
            this.urunler.FormattingEnabled = true;
            this.urunler.Items.AddRange(new object[] {
            "kullanıcı adına göre ürünleri comboboxlara at"});
            this.urunler.Location = new System.Drawing.Point(108, 102);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(121, 21);
            this.urunler.TabIndex = 3;
            this.urunler.Text = "Ürün Seçiniz";
            // 
            // Btarih
            // 
            this.Btarih.FormattingEnabled = true;
            this.Btarih.Items.AddRange(new object[] {
            "Yukarda seçilen ürüne göre"});
            this.Btarih.Location = new System.Drawing.Point(108, 151);
            this.Btarih.Name = "Btarih";
            this.Btarih.Size = new System.Drawing.Size(135, 21);
            this.Btarih.TabIndex = 4;
            this.Btarih.Text = "Başlangıç Tarih Seçiniz";
            // 
            // Starih
            // 
            this.Starih.FormattingEnabled = true;
            this.Starih.Items.AddRange(new object[] {
            "Yukarda seçilen ürüne göre"});
            this.Starih.Location = new System.Drawing.Point(249, 151);
            this.Starih.Name = "Starih";
            this.Starih.Size = new System.Drawing.Size(109, 21);
            this.Starih.TabIndex = 5;
            this.Starih.Text = "Bitiş Tarih Seçiniz";
            // 
            // gerirapor
            // 
            this.gerirapor.Location = new System.Drawing.Point(242, 334);
            this.gerirapor.Name = "gerirapor";
            this.gerirapor.Size = new System.Drawing.Size(112, 38);
            this.gerirapor.TabIndex = 6;
            this.gerirapor.Text = "geri";
            this.gerirapor.UseVisualStyleBackColor = true;
            this.gerirapor.Click += new System.EventHandler(this.gerirapor_Click);
            // 
            // cikisrapor
            // 
            this.cikisrapor.BackColor = System.Drawing.Color.Transparent;
            this.cikisrapor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisrapor.FlatAppearance.BorderSize = 0;
            this.cikisrapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisrapor.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisrapor.ForeColor = System.Drawing.Color.Brown;
            this.cikisrapor.Location = new System.Drawing.Point(573, -1);
            this.cikisrapor.Name = "cikisrapor";
            this.cikisrapor.Size = new System.Drawing.Size(26, 35);
            this.cikisrapor.TabIndex = 9;
            this.cikisrapor.Text = "X";
            this.cikisrapor.UseVisualStyleBackColor = false;
            this.cikisrapor.Click += new System.EventHandler(this.cikisrapor_Click);
            // 
            // rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(182)))), ((int)(((byte)(209)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.cikisrapor);
            this.Controls.Add(this.gerirapor);
            this.Controls.Add(this.Starih);
            this.Controls.Add(this.Btarih);
            this.Controls.Add(this.urunler);
            this.Controls.Add(this.raporturu);
            this.Controls.Add(this.raporal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rapor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button raporal;
        private System.Windows.Forms.ComboBox raporturu;
        private System.Windows.Forms.ComboBox urunler;
        private System.Windows.Forms.ComboBox Btarih;
        private System.Windows.Forms.ComboBox Starih;
        private System.Windows.Forms.Button gerirapor;
        private System.Windows.Forms.Button cikisrapor;
    }
}