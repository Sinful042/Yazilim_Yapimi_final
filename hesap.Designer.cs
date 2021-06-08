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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hesap));
            this.gerihesap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rapor = new System.Windows.Forms.Button();
            this.cikishesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gerihesap
            // 
            this.gerihesap.Location = new System.Drawing.Point(389, 338);
            this.gerihesap.Name = "gerihesap";
            this.gerihesap.Size = new System.Drawing.Size(147, 57);
            this.gerihesap.TabIndex = 7;
            this.gerihesap.Text = "geri";
            this.gerihesap.UseVisualStyleBackColor = true;
            this.gerihesap.Click += new System.EventHandler(this.gerihesap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı bilgilerini koycam buraya";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "belki güncelleme yaparız zaman kalırsa";
            // 
            // rapor
            // 
            this.rapor.Location = new System.Drawing.Point(124, 338);
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
            this.cikishesap.Location = new System.Drawing.Point(548, 2);
            this.cikishesap.Name = "cikishesap";
            this.cikishesap.Size = new System.Drawing.Size(26, 35);
            this.cikishesap.TabIndex = 11;
            this.cikishesap.Text = "X";
            this.cikishesap.UseVisualStyleBackColor = false;
            this.cikishesap.Click += new System.EventHandler(this.cikishesap_Click);
            // 
            // hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 450);
            this.Controls.Add(this.cikishesap);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gerihesap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hesap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gerihesap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rapor;
        private System.Windows.Forms.Button cikishesap;
    }
}