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
    public partial class satis_ist_frm : Form
    {
        string Kullanici_adi;
        string Urunid;
        int Fiyat;
        string durum;
        string filitre;
        int total_miktar,miktar;
        int total_para, harcanan_para;
        int muhasebe_ucret,olan_miktar;
        string urun_birim;
        int urun_miktar;
        public satis_ist_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        DataTable tablo = new DataTable();
        private void satis_ist_frm_Load(object sender, EventArgs e)
        {
            
            listele();
        }
        private void listele()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Satis ORDER BY KullaniciAdi ASC", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            dataGridView1.ReadOnly = true;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();
        }
        private void filitre_liste(string Satis_onay)
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Satis where SatisOnay = '" + Satis_onay + "'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            admin_frm ana_sayfa = new admin_frm();
            ana_sayfa.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                tablo.Clear();
                filitre = "Onaylandi";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex==1)
            {
                tablo.Clear();
                filitre = "Onaylanmadi";
                filitre_liste(filitre);
            }
            else
            {
                tablo.Clear();
                filitre = "Bekleniyor";
                filitre_liste(filitre);
            }
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Satis where SatisOnay= '" + dataGridView1.CurrentRow.Cells["SatisOnay"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["SatisOnay"].ToString() == "Onaylandi")
                {
                    MessageBox.Show("Şatış isteği daha önce onaylamış", "Tamam");
                    baglanti.Close();
                    break;
                }
                else if (oku["SatisOnay"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Şatış isteği daha önce reddedilmiş", "Tamam");
                    baglanti.Close();
                    break;
                }
                else
                {
                    Kullanici_adi = oku["KullaniciAdi"].ToString();
                    Urunid = oku["UrunAdi"].ToString();
                    Fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                    urun_birim = oku["UrunBirim"].ToString();
                    urun_miktar = Int32.Parse(oku["sUrunMiktar"].ToString());
                    durum = "Onaylandi";
                    baglanti.Close();
                    durum_güncelle(Kullanici_adi,Urunid,Fiyat,durum);
                    Alis_istek_kntrl(Kullanici_adi,Urunid,Fiyat,urun_miktar,urun_birim);
                    MessageBox.Show("Onaylama başarılı", "Tamam");
                    break;
                }
            }

        }

        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Satis where SatisOnay= '" + dataGridView1.CurrentRow.Cells["SatisOnay"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["SatisOnay"].ToString() == "Onaylandi")
                {
                    MessageBox.Show("Şatış isteği daha önce onaylamış", "Tamam");
                    baglanti.Close();
                    break;
                }
                else if (oku["SatisOnay"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Şatış isteği daha önce reddedilmiş", "Tamam");
                    baglanti.Close();
                    break;
                }
                else
                {
                    Kullanici_adi = oku["KullaniciAdi"].ToString();
                    Urunid = oku["UrunAdi"].ToString();
                    Fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                    miktar = Convert.ToInt32(oku["sUrunMiktar"].ToString());
                    durum = "Onaylanmadi";
                    baglanti.Close();
                    durum_güncelle(Kullanici_adi, Urunid, Fiyat,durum);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    ürün_iptal(Kullanici_adi, Urunid, miktar);
                    break;
                }
            }
        }
        private void durum_güncelle(string KullaniU,string Urunid,int fiyat,string durum)
        {
            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("update Satis set SatisOnay = '" + durum + "' where KullaniciAdi = '" + Kullanici_adi + "' and UrunAdi='"+Urunid+"' and UrunFiyat='"+fiyat.ToString()+"'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            filitre_liste(filitre);
            

        }

        private void cikissatisistek_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ürün_iptal(string KullaniU,string Urunid,int miktar)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from kUrun where KullaniciU= '" + KullaniU + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString()==Urunid)
                {
                   total_miktar = Convert.ToInt32(oku["UrunMiktar"].ToString());
                   total_miktar += miktar;
                    break;
                }
            }
            OleDbCommand komut_2 = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString()+ "'where KullaniciU = '" + KullaniU + "' and UrunAdi='" + Urunid + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Alis_istek_kntrl(string satici,string urun,int fiyat,int satilan_miktar,string birim)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *from Alis where UrunAdi = '" + urun + "'  AND NOT KullaniciAdi='" + satici + "'ORDER BY istekFiyat ASC");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["AlisDurum"].ToString() == "Bekleniyor")
                {
                    if (Int32.Parse(oku["istekMiktar"].ToString())<=satilan_miktar)
                    {
                        satilan_miktar = Int32.Parse(oku["istekMiktar"].ToString());
                        istek_alim(satici, oku["KullaniciAdi"].ToString(), urun, fiyat,satilan_miktar, birim);
                        
                    }
                }
            }
            baglanti.Close();

        }
        private void istek_alim(string satici,string alici,string urun,int fiyat,int miktar,string birim)
        {
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici where KullaniciAdi ='"+alici+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if ((fiyat*miktar)<=Int32.Parse(oku["Cuzdan"].ToString()))
                {
                    //Satıcıya parası gönderiliyor.
                    Para_gonder(satici,(miktar*fiyat));
                    //muhasebe ücreti hesaplanıyor
                    muhasebe_ucret = (fiyat * miktar) / 100;
                    //muhasebe ücreti gönderiliyor.
                    Para_gonder("Muhasebe", muhasebe_ucret);
                    //alıcıdan toplam harcanan para hesaplanıyor.
                    harcanan_para = (fiyat*miktar) + muhasebe_ucret;
                    //Alıcının parası güncelleniyor.
                    Para_cikar(alici, harcanan_para);
                    //satılan ürün satış listesinden çıkarılıyor.
                    satistan_cikar(urun,satici, miktar,fiyat);
                    //alınan ürün alıcının hesabına aktarılıyor.
                    urun_ekle(alici, miktar.ToString(), urun,birim);
                }
            }


        }
        private void Para_gonder(string satici_Kullanici_adi, int gelen_para)
        {


            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == satici_Kullanici_adi)
                {

                    total_para = Convert.ToInt32(oku["Cuzdan"].ToString());
                    break;
                }

            }
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();



        }
        private void Para_cikar(string Kullanici_adi, int giden_para)
        {

            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {

                    total_para = Convert.ToInt32(oku["Cuzdan"].ToString());
                    break;
                }

            }
            total_para -= giden_para;
            //yenipara = total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            
        }
        private void urun_ekle(string Kullanici_adi, string alinan_miktar, string urunAd, string Birim)
        {

            OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
            komut.ExecuteNonQuery();
        }
        private void satistan_cikar(string Urunadi, string Kullanici_Adi, int alinan_miktar, int alinan_fiyat)
        {

            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '" + Urunadi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_Adi)
                {
                    olan_miktar = Convert.ToInt32(oku["SUrunMiktar"].ToString());
                    break;
                }
            }
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='" + alinan_fiyat.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }


    }
}
