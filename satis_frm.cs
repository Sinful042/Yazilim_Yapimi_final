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
    
    public partial class satis_frm : Form
    {
        public string Kullanici_adi;
        public string Urun_id;
        public int istek_miktar;
        int olan_miktar;
        int birim_fiyat;
        string birim;
        string UrunTuru;
        public satis_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        private void onay_btn_Click(object sender, EventArgs e)
        {
            istek_miktar = Convert.ToInt32(textBox1.Text);
            birim_fiyat = Convert.ToInt32(textBox2.Text);
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU= '" + Kullanici_adi + "'and UrunAdi='"+Urun_id+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                olan_miktar = Convert.ToInt32(oku["UrunMiktar"].ToString());
                if (istek_miktar>olan_miktar)
                {
                   MessageBox.Show("Bu miktarda ürününüz bulunmamaktadır", "Tamam");
                   baglanti.Close();
                   break;
                }
               else
               {
                   olan_miktar -= istek_miktar;
                   birim = oku["UrunBirim"].ToString();
                   baglanti.Close();
                   MiktarGüncelle(Kullanici_adi, olan_miktar, Urun_id);
                   satisa_ekle(Kullanici_adi, Urun_id, istek_miktar, birim_fiyat,birim);
                   break;
               }
            }

        }
        private void MiktarGüncelle(string KullaniciU,int miktar,string UrunAdi)
        {
            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("update kUrun set UrunMiktar = '" + miktar.ToString() + "' where KullaniciU = '" + KullaniciU + "' and  UrunAdi='"+UrunAdi+"'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
        }
        private void satisa_ekle(string kullaniU,string Urunid,int miktar,int fiyat,string birim)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Satis(KullaniciAdi,UrunAdi,sUrunMiktar,UrunBirim,UrunFiyat) values('" + kullaniU + "','" + Urunid + "','" + miktar.ToString() + "','" + birim + "','" + fiyat.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şatış Onayı Bekleniyor", "Tamam");
            this.Hide();
        }

        private void cikisparaekle_Click(object sender, EventArgs e)
        {
            ana_fr anasayfa = new ana_fr();
            anasayfa.Show();
        }

        private void satis_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
