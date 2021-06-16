namespace Proje_Ödevi
{
    partial class hesap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesap));
            this.gerihesap = new System.Windows.Forms.Button();
            this.rapor = new System.Windows.Forms.Button();
            this.cikishesap = new System.Windows.Forms.Button();
            this.kullanicibilgileri = new System.Windows.Forms.DataGridView();
            this.avatar = new System.Windows.Forms.Button();
            this.kullanici_lbl = new System.Windows.Forms.Label();
            this.para_lbl = new System.Windows.Forms.Label();
            this.hosgeldiniz_lbl = new System.Windows.Forms.Label();
            this.tl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibilgileri)).BeginInit();
            this.SuspendLayout();
            // 
            // gerihesap
            // 
            this.gerihesap.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.gerihesap.Location = new System.Drawing.Point(388, 460);
            this.gerihesap.Name = "gerihesap";
            this.gerihesap.Size = new System.Drawing.Size(147, 57);
            this.gerihesap.TabIndex = 7;
            this.gerihesap.Text = "geri";
            this.gerihesap.UseVisualStyleBackColor = true;
            this.gerihesap.Click += new System.EventHandler(this.gerihesap_Click);
            // 
            // rapor
            // 
            this.rapor.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold);
            this.rapor.Location = new System.Drawing.Point(12, 460);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(147, 57);
            this.rapor.TabIndex = 10;
            this.rapor.Text = "Rapor al";
            this.rapor.UseVisualStyleBackColor = true;
            this.rapor.Click += new System.EventHandler(this.rapor_Click);
            // 
            // cikishesap
            // 
            this.cikishesap.BackColor = System.Drawing.Color.Transparent;
            this.cikishesap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikishesap.FlatAppearance.BorderSize = 0;
            this.cikishesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikishesap.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikishesap.ForeColor = System.Drawing.Color.Brown;
            this.cikishesap.Location = new System.Drawing.Point(516, -4);
            this.cikishesap.Name = "cikishesap";
            this.cikishesap.Size = new System.Drawing.Size(26, 35);
            this.cikishesap.TabIndex = 11;
            this.cikishesap.Text = "X";
            this.cikishesap.UseVisualStyleBackColor = false;
            this.cikishesap.Click += new System.EventHandler(this.cikishesap_Click);
            // 
            // kullanicibilgileri
            // 
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kullanicibilgileri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.kullanicibilgileri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kullanicibilgileri.BackgroundColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicibilgileri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.kullanicibilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kullanicibilgileri.DefaultCellStyle = dataGridViewCellStyle28;
            this.kullanicibilgileri.GridColor = System.Drawing.Color.Black;
            this.kullanicibilgileri.Location = new System.Drawing.Point(13, 156);
            this.kullanicibilgileri.Name = "kullanicibilgileri";
            this.kullanicibilgileri.ReadOnly = true;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kullanicibilgileri.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.kullanicibilgileri.RowHeadersVisible = false;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kullanicibilgileri.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.kullanicibilgileri.Size = new System.Drawing.Size(522, 67);
            this.kullanicibilgileri.TabIndex = 12;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.Transparent;
            this.avatar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("avatar.BackgroundImage")));
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Enabled = false;
            this.avatar.ForeColor = System.Drawing.Color.Transparent;
            this.avatar.Location = new System.Drawing.Point(13, 13);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(81, 94);
            this.avatar.TabIndex = 13;
            this.avatar.UseVisualStyleBackColor = false;
            // 
            // kullanici_lbl
            // 
            this.kullanici_lbl.AutoSize = true;
            this.kullanici_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kullanici_lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanici_lbl.ForeColor = System.Drawing.Color.White;
            this.kullanici_lbl.Location = new System.Drawing.Point(138, 74);
            this.kullanici_lbl.Name = "kullanici_lbl";
            this.kullanici_lbl.Size = new System.Drawing.Size(181, 33);
            this.kullanici_lbl.TabIndex = 14;
            this.kullanici_lbl.Text = "Kullanıcı Adı";
            // 
            // para_lbl
            // 
            this.para_lbl.AutoSize = true;
            this.para_lbl.BackColor = System.Drawing.Color.Transparent;
            this.para_lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.para_lbl.ForeColor = System.Drawing.Color.White;
            this.para_lbl.Location = new System.Drawing.Point(437, 74);
            this.para_lbl.Name = "para_lbl";
            this.para_lbl.Size = new System.Drawing.Size(77, 33);
            this.para_lbl.TabIndex = 15;
            this.para_lbl.Text = "Para";
            // 
            // hosgeldiniz_lbl
            // 
            this.hosgeldiniz_lbl.AutoSize = true;
            this.hosgeldiniz_lbl.BackColor = System.Drawing.Color.Transparent;
            this.hosgeldiniz_lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hosgeldiniz_lbl.ForeColor = System.Drawing.Color.White;
            this.hosgeldiniz_lbl.Location = new System.Drawing.Point(118, 27);
            this.hosgeldiniz_lbl.Name = "hosgeldiniz_lbl";
            this.hosgeldiniz_lbl.Size = new System.Drawing.Size(172, 33);
            this.hosgeldiniz_lbl.TabIndex = 16;
            this.hosgeldiniz_lbl.Text = "Hoşgeldiniz";
            // 
            // tl
            // 
            this.tl.AutoSize = true;
            this.tl.BackColor = System.Drawing.Color.Transparent;
            this.tl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.tl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tl.Location = new System.Drawing.Point(411, 74);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(32, 33);
            this.tl.TabIndex = 17;
            this.tl.Text = "₺";
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 542);
            this.Controls.Add(this.tl);
            this.Controls.Add(this.hosgeldiniz_lbl);
            this.Controls.Add(this.para_lbl);
            this.Controls.Add(this.kullanici_lbl);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.kullanicibilgileri);
            this.Controls.Add(this.cikishesap);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.gerihesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hesap";
            this.Load += new System.EventHandler(this.hesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanicibilgileri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerihesap;
        private System.Windows.Forms.Button rapor;
        private System.Windows.Forms.Button cikishesap;
        private System.Windows.Forms.DataGridView kullanicibilgileri;
        private System.Windows.Forms.Button avatar;
        private System.Windows.Forms.Label kullanici_lbl;
        private System.Windows.Forms.Label para_lbl;
        private System.Windows.Forms.Label hosgeldiniz_lbl;
        private System.Windows.Forms.Label tl;
    }
}