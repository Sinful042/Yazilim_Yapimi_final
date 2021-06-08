using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödevi
{
    public partial class fiyatbelirle : Form
    {
        public fiyatbelirle()
        {
            InitializeComponent();
        }

        private void cikisfiyatbelirle_Click(object sender, EventArgs e)
        {
            satin_al_frm satisform = new satin_al_frm();
            satisform.Show();
            this.Hide();
        }

        private void fiyatbelirle_btn_Click(object sender, EventArgs e)
        {
            //bekleniyor mesajı çıksın
        }
    }
}
