namespace Proje_Ödevi
{
    partial class para_ekle_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(para_ekle_frm));
            this.istek_para_lbl = new System.Windows.Forms.Label();
            this.istek_para = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.cikisparaekle = new System.Windows.Forms.Button();
            this.paratip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // istek_para_lbl
            // 
            this.istek_para_lbl.AutoSize = true;
            this.istek_para_lbl.BackColor = System.Drawing.Color.Transparent;
            this.istek_para_lbl.Font = new System.Drawing.Font("Georgia", 8F);
            this.istek_para_lbl.Location = new System.Drawing.Point(90, 208);
            this.istek_para_lbl.Name = "istek_para_lbl";
            this.istek_para_lbl.Size = new System.Drawing.Size(110, 28);
            this.istek_para_lbl.TabIndex = 2;
            this.istek_para_lbl.Text = "Ne kadar eklemek\r\n    istiyorsunuz?";
            // 
            // istek_para
            // 
            this.istek_para.Location = new System.Drawing.Point(58, 269);
            this.istek_para.Name = "istek_para";
            this.istek_para.Size = new System.Drawing.Size(174, 20);
            this.istek_para.TabIndex = 3;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.ekle_btn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ekle_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekle_btn.Location = new System.Drawing.Point(83, 330);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(117, 37);
            this.ekle_btn.TabIndex = 4;
            this.ekle_btn.Text = "Para Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // cikisparaekle
            // 
            this.cikisparaekle.BackColor = System.Drawing.Color.Transparent;
            this.cikisparaekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisparaekle.FlatAppearance.BorderSize = 0;
            this.cikisparaekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisparaekle.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisparaekle.ForeColor = System.Drawing.Color.Brown;
            this.cikisparaekle.Location = new System.Drawing.Point(420, -2);
            this.cikisparaekle.Name = "cikisparaekle";
            this.cikisparaekle.Size = new System.Drawing.Size(32, 36);
            this.cikisparaekle.TabIndex = 7;
            this.cikisparaekle.Text = "X";
            this.cikisparaekle.UseVisualStyleBackColor = false;
            this.cikisparaekle.Click += new System.EventHandler(this.cikisparaekle_Click);
            // 
            // paratip
            // 
            this.paratip.FormattingEnabled = true;
            this.paratip.Location = new System.Drawing.Point(83, 139);
            this.paratip.Name = "paratip";
            this.paratip.Size = new System.Drawing.Size(130, 21);
            this.paratip.TabIndex = 8;
            this.paratip.Text = "Para Tipini Seçiniz";
            // 
            // para_ekle_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.paratip);
            this.Controls.Add(this.cikisparaekle);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.istek_para);
            this.Controls.Add(this.istek_para_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "para_ekle_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para Ekle";
            this.Load += new System.EventHandler(this.para_ekle_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label istek_para_lbl;
        private System.Windows.Forms.TextBox istek_para;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button cikisparaekle;
        private System.Windows.Forms.ComboBox paratip;
    }
}