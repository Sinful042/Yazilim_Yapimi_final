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
        //satici kullanici bilgisi 
        string Kullanici_adi;
        //satilacak ürün bilgisi
        string Urunid;
        //satilacak ürün birimi
        string urun_birim;
        //satis durumu bilgisi 
        string durum;
        //isteninlen filitre bilgisi
        string filitre;
        //satilmak istenen fiyat alınıyor
        double Fiyat;
        //toplam miktar ve satilacak miktar bilgisi
        double total_miktar,miktar;
        //toplam para ve harcanan para bilgisi (otomatik alım için)
        double total_para, harcanan_para;
        //otomatik alım olursa muhasebe ücreti
        double muhasebe_ucret,olan_miktar;
        //satisa çıkıcak ürün miktari
        double urun_miktar;
        //alinan ürünün alıcıda daha once olup olmadıgının kontrolü
        bool urunu_var = false;
        public satis_ist_frm()
        {
            InitializeComponent();
        }

        //veri tabani baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //satis istekleri icin dataTable olusturuluyor
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
                    Fiyat = Convert.ToDouble(oku["UrunFiyat"].ToString().Replace(".",","));
                    urun_birim = oku["UrunBirim"].ToString();
                    urun_miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".", ","));
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
                    Fiyat = Convert.ToDouble(oku["UrunFiyat"].ToString().Replace(".",","));
                    miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".", ","));
                    durum = "Onaylanmadi";
                    baglanti.Close();
                    durum_güncelle(Kullanici_adi, Urunid, Fiyat,durum);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    ürün_iptal(Kullanici_adi, Urunid, miktar);
                    break;
                }
            }
        }
        private void durum_güncelle(string KullaniU,string Urunid,double fiyat,string durum)
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

        private void ürün_iptal(string KullaniU,string Urunid,double miktar)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from kUrun where KullaniciU= '" + KullaniU + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString()==Urunid)
                {
                    total_miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".", ","));
                    total_miktar += miktar;
                    break;
                }
            }
            OleDbCommand komut_2 = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString()+ "'where KullaniciU = '" + KullaniU + "' and UrunAdi='" + Urunid + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Alis_istek_kntrl(string satici,string urun,double fiyat,double satilan_miktar,string birim)
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
                    if (Convert.ToDouble(oku["istekMiktar"].ToString().Replace(".",",")) <= satilan_miktar)
                    {
                        satilan_miktar = Convert.ToDouble(oku["istekMiktar"].ToString().Replace(".", ","));
                        istek_alim(satici, oku["KullaniciAdi"].ToString(), urun, fiyat, satilan_miktar, birim);

                    }
                }
            }
            baglanti.Close();

        }
        private void istek_alim(string satici,string alici,string urun,double fiyat,double miktar,string birim)
        {
            OleDbCommand sorgu = new OleDbCommand("select *from Kullanici where KullaniciAdi ='"+alici+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if ((fiyat*miktar)<=Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",",")))
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
                    satistan_cikar(urun,satici,miktar,fiyat);
                    //alınan ürün alıcının hesabına aktarılıyor.
                    urun_ekle(alici, miktar.ToString(), urun,birim);
                    alis_durum(alici,urun,fiyat);
                }
            }


        }
        private void Para_gonder(string satici_Kullanici_adi, double gelen_para)
        {


            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == satici_Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();



        }
        private void Para_cikar(string Kullanici_adi, double giden_para)
        {

            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".", ","));
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
            //Onceden bu urune sahip mi kontrol ediyoruz.
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU='"+Kullanici_adi+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["UrunAdi"].ToString() == urunAd)
                {
                    olan_miktar = Convert.ToDouble(oku["UrunMiktar"].ToString().Replace(".",","));
                    total_miktar = olan_miktar + Convert.ToDouble(alinan_miktar.Replace(".", ","));
                    urunu_var = true;
                    break;
                }

            }



            if (!urunu_var)
            {
                OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
                komut.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("update kUrun set UrunMiktar = '" + total_miktar.ToString() + "' where KullaniciU ='" + Kullanici_adi + "' AND UrunAdi = '" + urunAd + "'", baglanti);
                komut.ExecuteNonQuery();
            }
            
        }
        private void satistan_cikar(string Urunadi, string Kullanici_Adi, double alinan_miktar, double alinan_fiyat)
        {

            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '" + Urunadi + "'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_Adi)
                {
                    olan_miktar = Convert.ToDouble(oku["SUrunMiktar"].ToString().Replace(",",","));
                    break;
                }
            }
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='" + alinan_fiyat.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }
        private void alis_durum(string kullanici_adi,string urun,double istek_miktar)
        {
            OleDbCommand komut = new OleDbCommand("update Alis set AlisDurum = '" + durum + "' where KullaniciAdi = '" + kullanici_adi + "' and UrunAdi = '" + urun + "' and istekMiktar= '" + istek_miktar.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();

        }


    }
}
