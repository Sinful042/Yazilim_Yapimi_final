namespace Proje_Ödevi
{
    partial class satin_al_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(satin_al_frm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.admin_label = new System.Windows.Forms.Label();
            this.satın_al_btn = new System.Windows.Forms.Button();
            this.cikis_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_para = new System.Windows.Forms.Label();
            this.cikisanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(521, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(699, 236);
            this.dataGridView1.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yiyecek",
            "Giysi",
            "Hammadde",
            "Kırtasiye",
            "Elektronik",
            "Aksesuar",
            "Mutfak"});
            this.comboBox1.Location = new System.Drawing.Point(582, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // admin_label
            // 
            this.admin_label.AutoSize = true;
            this.admin_label.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.admin_label.Font = new System.Drawing.Font("Georgia", 15F);
            this.admin_label.Location = new System.Drawing.Point(26, 23);
            this.admin_label.Name = "admin_label";
            this.admin_label.Size = new System.Drawing.Size(87, 24);
            this.admin_label.TabIndex = 17;
            this.admin_label.Text = "Ürünler:";
            this.admin_label.Click += new System.EventHandler(this.admin_label_Click);
            // 
            // satın_al_btn
            // 
            this.satın_al_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.satın_al_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.satın_al_btn.Location = new System.Drawing.Point(337, 385);
            this.satın_al_btn.Name = "satın_al_btn";
            this.satın_al_btn.Size = new System.Drawing.Size(102, 37);
            this.satın_al_btn.TabIndex = 15;
            this.satın_al_btn.Text = "Satın Al";
            this.satın_al_btn.UseVisualStyleBackColor = false;
            this.satın_al_btn.Click += new System.EventHandler(this.satın_al_btn_Click);
            // 
            // cikis_btn
            // 
            this.cikis_btn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cikis_btn.Font = new System.Drawing.Font("Book Antiqua", 14.25F);
            this.cikis_btn.Location = new System.Drawing.Point(607, 338);
            this.cikis_btn.Name = "cikis_btn";
            this.cikis_btn.Size = new System.Drawing.Size(117, 37);
            this.cikis_btn.TabIndex = 14;
            this.cikis_btn.Text = "Geri";
            this.cikis_btn.UseVisualStyleBackColor = false;
            this.cikis_btn.Click += new System.EventHandler(this.cikis_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Font = new System.Drawing.Font("Georgia", 15F);
            this.label2.Location = new System.Drawing.Point(257, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ne kadar almak istiyorsunuz?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(25, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "$";
            // 
            // lbl_para
            // 
            this.lbl_para.AutoSize = true;
            this.lbl_para.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_para.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_para.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_para.Location = new System.Drawing.Point(54, 341);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(53, 25);
            this.lbl_para.TabIndex = 23;
            this.lbl_para.Text = "Para";
            this.lbl_para.Click += new System.EventHandler(this.lbl_para_Click);
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
            this.cikisanasayfa.TabIndex = 25;
            this.cikisanasayfa.Text = "X";
            this.cikisanasayfa.UseVisualStyleBackColor = false;
            this.cikisanasayfa.Click += new System.EventHandler(this.cikisanasayfa_Click);
            // 
            // satin_al_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(774, 441);
            this.Controls.Add(this.cikisanasayfa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.admin_label);
            this.Controls.Add(this.satın_al_btn);
            this.Controls.Add(this.cikis_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "satin_al_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Al";
            this.Load += new System.EventHandler(this.satin_al_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label admin_label;
        private System.Windows.Forms.Button satın_al_btn;
        private System.Windows.Forms.Button cikis_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Button cikisanasayfa;
    }
}