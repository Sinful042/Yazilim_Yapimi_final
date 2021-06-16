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
    public partial class hesap : Form
    {
        public string Kullanici_adi;
        public string Para;
        public hesap()
        {
            InitializeComponent();
        }

        private void gerihesap_Click(object sender, EventArgs e)
        {
            ana_fr anasayfa = new ana_fr();
            anasayfa.Kullanici_adi = Kullanici_adi;
            anasayfa.Para = Para;
            anasayfa.Show();
            this.Hide();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            rapor rapor = new rapor();
            rapor.Show();
            this.Hide();
        }

        private void cikishesap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesap_Load(object sender, EventArgs e)
        {

        }
    }
}
