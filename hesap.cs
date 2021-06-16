using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proje_Ödevi
{
    public partial class hesap : Form
    {
        public string Kullanici_adi;
        public string Para;

        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        DataTable tablo = new DataTable();
        public hesap()
        {
            InitializeComponent();
        }

        private void gerihesap_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            hesap.Kullanici_adi = Kullanici_adi;
            hesap.Para = Para;
            hesap.Show();
            this.Hide();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            rapor rapor = new rapor();
            
            rapor.Kullanici_adi = Kullanici_adi;
            rapor.Para = Para;
            rapor.Show();
            this.Hide();
        }

        private void cikishesap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hesap_Load(object sender, EventArgs e)
        {
            kullanici_lbl.Text = Kullanici_adi;
            para_lbl.Text = Para;

            listele();
        }
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select Ad,Soyad,Parola,TC,ePosta,Adres,Telefon from Kullanici where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            liste.Fill(tablo);
            kullanicibilgileri.DataSource = tablo;
            kullanicibilgileri.DefaultCellStyle.SelectionBackColor = Color.White;
            kullanicibilgileri.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }
    }
}
