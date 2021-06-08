namespace Proje_Ödevi
{
    partial class fiyatbelirle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fiyatbelirle));
            this.fiyatb_txt = new System.Windows.Forms.TextBox();
            this.fiyatbelirle_btn = new System.Windows.Forms.Button();
            this.cikisfiyatbelirle = new System.Windows.Forms.Button();
            this.fiyatb_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fiyatb_txt
            // 
            this.fiyatb_txt.Location = new System.Drawing.Point(188, 140);
            this.fiyatb_txt.Name = "fiyatb_txt";
            this.fiyatb_txt.Size = new System.Drawing.Size(166, 20);
            this.fiyatb_txt.TabIndex = 0;
            // 
            // fiyatbelirle_btn
            // 
            this.fiyatbelirle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fiyatbelirle_btn.Location = new System.Drawing.Point(213, 252);
            this.fiyatbelirle_btn.Name = "fiyatbelirle_btn";
            this.fiyatbelirle_btn.Size = new System.Drawing.Size(117, 37);
            this.fiyatbelirle_btn.TabIndex = 3;
            this.fiyatbelirle_btn.Text = "Onayla";
            this.fiyatbelirle_btn.UseVisualStyleBackColor = true;
            this.fiyatbelirle_btn.Click += new System.EventHandler(this.fiyatbelirle_btn_Click);
            // 
            // cikisfiyatbelirle
            // 
            this.cikisfiyatbelirle.BackColor = System.Drawing.Color.Transparent;
            this.cikisfiyatbelirle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cikisfiyatbelirle.FlatAppearance.BorderSize = 0;
            this.cikisfiyatbelirle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisfiyatbelirle.Font = new System.Drawing.Font("Forte", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisfiyatbelirle.ForeColor = System.Drawing.Color.Brown;
            this.cikisfiyatbelirle.Location = new System.Drawing.Point(373, -5);
            this.cikisfiyatbelirle.Name = "cikisfiyatbelirle";
            this.cikisfiyatbelirle.Size = new System.Drawing.Size(32, 36);
            this.cikisfiyatbelirle.TabIndex = 9;
            this.cikisfiyatbelirle.Text = "X";
            this.cikisfiyatbelirle.UseVisualStyleBackColor = false;
            this.cikisfiyatbelirle.Click += new System.EventHandler(this.cikisfiyatbelirle_Click);
            // 
            // fiyatb_lbl
            // 
            this.fiyatb_lbl.AutoSize = true;
            this.fiyatb_lbl.Location = new System.Drawing.Point(185, 98);
            this.fiyatb_lbl.Name = "fiyatb_lbl";
            this.fiyatb_lbl.Size = new System.Drawing.Size(169, 13);
            this.fiyatb_lbl.TabIndex = 10;
            this.fiyatb_lbl.Text = "Hangi Fiyattan almak istiyorsunuz?";
            // 
            // fiyatbelirle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.fiyatb_lbl);
            this.Controls.Add(this.cikisfiyatbelirle);
            this.Controls.Add(this.fiyatbelirle_btn);
            this.Controls.Add(this.fiyatb_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fiyatbelirle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fiyatbelirle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fiyatb_txt;
        private System.Windows.Forms.Button fiyatbelirle_btn;
        private System.Windows.Forms.Button cikisfiyatbelirle;
        private System.Windows.Forms.Label fiyatb_lbl;
    }
}