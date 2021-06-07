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
    
    public partial class ana_fr : Form
    {
        public String Kullanici_adi;
        public string Para;
        
        public ana_fr()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        DataTable tablo = new DataTable();
       
           

        private void ana_fr_Load(object sender, EventArgs e)
        {
            kullanici_lbl.Text = Kullanici_adi;
            para_lbl.Text = Para;
            baglanti.Open();
            OleDbDataAdapter fiyat_liste = new OleDbDataAdapter("select  *from Satis ORDER BY UrunFiyat ASC", baglanti);
            baglanti.Close();
            listele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select UrunAdi,UrunMiktar,UrunBirim from kUrun where KullaniciU = '"+Kullanici_adi+"'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }

        private void para_ekle_btn_Click(object sender, EventArgs e)
        {
            para_ekle_frm para_ekle = new para_ekle_frm();
            para_ekle.kullanici_adi = Kullanici_adi;
            para_ekle.ShowDialog();
           
            
        }

        private void para_lbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            satis_frm satis = new satis_frm();
            satis.Kullanici_adi = Kullanici_adi;
            satis.Urun_id = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            satis.ShowDialog();
            tablo.Clear();
            listele();
            
        }

        private void ürün_al_btn_Click(object sender, EventArgs e)
        {
            satin_al_frm ürün_al = new satin_al_frm();
            ürün_al.alici_kullanici_adi = Kullanici_adi;
            ürün_al.para = Para;
            ürün_al.Show();
            this.Hide();
        }

        private void kullanici_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
