namespace Proje_Ödevi
{
    partial class para_ist_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(para_ist_frm));
            this.admin_label = new System.Windows.Forms.Label();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.istekler = new System.Windows.Forms.ComboBox();
            this.onaylama_btn = new System.Windows.Forms.Button();
            this.onay_btn = new System.Windows.Forms.Button();
            this.paralisteleme = new System.Windows.Forms.DataGridView();
            this.filtre_lbl = new System.Windows.Forms.Label();
            this.cikisanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paralisteleme)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.admin_label.Font = new System.Drawing.Font("Georgia", 15F);
            this.admin_label.Location = new System.Drawing.Point(20, 20);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(136, 24);
            this.admin_label.TabIndex = 0;
            this.admin_label.Text = "Para İstekleri:";
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cikis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.cikis_btn.Location = new System.Drawing.Point(616, 325);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(117, 37);
            this.cikis_btn.TabIndex = 3;
            this.cikis_btn.Text = "Geri";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // istekler
            // 
            this.istekler.BackColor = System.Drawing.Color.Silver;
            this.istekler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.istekler.FormattingEnabled = true;
            this.istekler.Items.AddRange(new object[] {
            "Onaylanan Kullanıclar",
            "Onaylanmayan Kullanıcılar",
            "Onay Bekleyen Kullanıcılar"});
            this.istekler.Location = new System.Drawing.Point(583, 20);
            this.istekler.Name = "istekler";
            this.istekler.Size = new System.Drawing.Size(142, 21);
            this.istekler.TabIndex = 4;
            this.istekler.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.istekler.Enter += new System.EventHandler(this.istekler_Enter);
            this.istekler.Leave += new System.EventHandler(this.istekler_Leave);
            // 
            // onaylama_btn
            // 
            this.onaylama_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onaylama_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onaylama_btn.Location = new System.Drawing.Point(325, 325);
            this.onaylama_btn.Name = "onaylama_btn";
            this.onaylama_btn.Size = new System.Drawing.Size(117, 37);
            this.onaylama_btn.TabIndex = 5;
            this.onaylama_btn.Text = "Onaylama";
            this.onaylama_btn.UseVisualStyleBackColor = false;
            this.onaylama_btn.Click += new System.EventHandler(this.onaylama_btn_Click);
            // 
            // onay_btn
            // 
            this.onay_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.onay_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.onay_btn.Location = new System.Drawing.Point(18, 325);
            this.onay_btn.Name = "onay_btn";
            this.onay_btn.Size = new System.Drawing.Size(117, 37);
            this.onay_btn.TabIndex = 6;
            this.onay_btn.Text = "Onayla";
            this.onay_btn.UseVisualStyleBackColor = false;
            this.onay_btn.Click += new System.EventHandler(this.onay_btn_Click);
            // 
            // paralisteleme
            // 
            this.paralisteleme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paralisteleme.BackgroundColor = System.Drawing.Color.LightGray;
            this.paralisteleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paralisteleme.Location = new System.Drawing.Point(18, 66);
            this.paralisteleme.Name = "paralisteleme";
            this.paralisteleme.Size = new System.Drawing.Size(715, 226);
            this.paralisteleme.TabIndex = 7;
            // 
            // filtre_lbl
            // 
            this.filtre_lbl.AutoSize = true;
            this.filtre_lbl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filtre_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtre_lbl.Location = new System.Drawing.Point(525, 19);
            this.filtre_lbl.Name = "filtre_lbl";
            this.filtre_lbl.Size = new System.Drawing.Size(55, 22);
            this.filtre_lbl.TabIndex = 8;
            this.filtre_lbl.Text = "Filtre:";
            // 
            // cikisanasayfa
            // 
            this.cikisanasayfa.BackColor = System.Drawing.Color.Transparent;
            this.cikisanasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisanasayfa.FlatAppearance.BorderSize = 0;
            this.cikisanasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisanasayfa.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisanasayfa.ForeColor = System.Drawing.Color.Brown;
            this.cikisanasayfa.Location = new System.Drawing.Point(730, -5);
            this.cikisanasayfa.Name = "cikisanasayfa";
            this.cikisanasayfa.Size = new System.Drawing.Size(32, 36);
            this.cikisanasayfa.TabIndex = 9;
            this.cikisanasayfa.Text = "X";
            this.cikisanasayfa.UseVisualStyleBackColor = false;
            this.cikisanasayfa.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // para_ist_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(758, 402);
            this.Controls.Add(this.cikisanasayfa);
            this.Controls.Add(this.filtre_lbl);
            this.Controls.Add(this.paralisteleme);
            this.Controls.Add(this.onay_btn);
            this.Controls.Add(this.onaylama_btn);
            this.Controls.Add(this.istekler);
            this.Controls.Add(this.cikis_btn);
            this.Controls.Add(this.admin_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "para_ist_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İstekleri";
            this.Load += new System.EventHandler(this.admin_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paralisteleme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.ComboBox istekler;
        private System.Windows.Forms.Button onaylama_btn;
        private System.Windows.Forms.Button onay_btn;
        private System.Windows.Forms.DataGridView paralisteleme;
        private System.Windows.Forms.Label filtre_lbl;
        private System.Windows.Forms.Button cikisanasayfa;
    }
}