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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Proje_Ödevi
{
    public partial class rapor : Form
    {
        //raporunu çıkaracagımız kullanıcının bilgilerini tutuyoruz
        public string Kullanici_adi;
        public string Para;
        string islem_turu;
        int durum, durum_2;
        public rapor()
        {
            InitializeComponent();
        }
        //baglantiyi kuruyoruz
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        
        private void gerirapor_Click(object sender, EventArgs e)
        {
            //hesap formunu açıp bu formu kapatıyoruz
            hesap hesap = new hesap();
            hesap.Show();
            hesap.Kullanici_adi = Kullanici_adi;
            hesap.Para = Para;
            this.Hide();
        }

        private void cikisrapor_Click(object sender, EventArgs e)
        {
            //uygulamadan çıkıs yapıyoruz
            Application.Exit();
        }

        private void raporal_Click(object sender, EventArgs e)
        {
            //Raporun tipini comboboxdan alıyoruz
            if(islem.SelectedIndex == 0)
            {
                islem_turu = "Alis";
            }
            else if(islem.SelectedIndex ==1)
            {
                islem_turu = "Satis";
            }
            else
            {
                //eger kullanıcı alis satis yaptıysa değeri null yapıyoruz
                islem_turu = null;
            }
            //rapor cikar fonksiyonuna gerekli değerleri gönderiyoruz
            rapor_cikar(Kullanici_adi,urunler.SelectedItem.ToString(),Btarih.SelectedItem.ToString(),Starih.SelectedItem.ToString(),islem_turu);
        }

        private void rapor_Load(object sender, EventArgs e)
        {
            //comboboxa item eklemek için gerekli fonksiyonları çagırıyoruz
            uruntur();
            tarih_ekle();
        }

        private void rapor_cikar(string kullanici,string urun,string baslangic,string bitis,string islem_turu)
        {
            //pdf için yeni document olusturuyoruz
            iTextSharp.text.Document  rapor = new iTextSharp.text.Document();
            //pdfin nereye oluşturulucagını bellirliyoruz
            PdfWriter.GetInstance(rapor, new FileStream("C:Rapor.Pdf", FileMode.Create));
            //pdf açık olup olamdıgını kontrol ediyoruz
            if (rapor.IsOpen() == false)
            {
                rapor.Open();
            }
            //gelen string tarihleri tarih türüne dönüştürüyoruz
            DateTime ilk = Convert.ToDateTime(baslangic);
            DateTime son = Convert.ToDateTime(bitis);
            
            //islem turune göre İslemler tablosunu okuyoruz
            if(islem_turu != null)
            {
                //baglantiyi aciyoruz
                baglanti.Open();
                //İslemler tablosunun girilen değerlere göre okuyoruz
                OleDbCommand komut = new OleDbCommand("select *from İslemler where KullaniciAdi = '" + kullanici + "' AND İslemTuru = '" + islem_turu + "'ORDER BY islemTarih ASC", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    //girilen tarihler ile verideki tarihleri kıyaslıyoruz
                    durum = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), ilk);
                    durum_2 = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), son);
                    //eger ilk tarih girilen tarihden büyükse ve son tarih girilen tarihden küçükse bu islem istenilen tarihler arasındadır
                    if (durum >= 0 && durum_2 <= 0)
                    {
                       // İslemler tablosunda ki bilgeri pdfe yazdırıyoruz
                        rapor.Add(new Paragraph("Tarih : " + oku["islemTarih"].ToString() + ""));
                        rapor.Add(new Paragraph("Ürün Tipi : " + oku["urunAdi"].ToString() + " "));
                        rapor.Add(new Paragraph("Tutar : " + oku["UrunFiyat"].ToString() + " TL"));
                        rapor.Add(new Paragraph("Miktar : " + oku["UrunMiktar"].ToString() + " Kg "));
                        rapor.Add(new Paragraph(""));

                    }


                }
                baglanti.Close();
                rapor.Close();
                MessageBox.Show("Rapor olusturuldu", "Tamam");
            }
            else
            {
                //eger islem türü null değilse kullanıcı alis ve ya satis islemlerini şeçmistir
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("select *from İslemler where KullaniciAdi = '" + kullanici + "'ORDER BY islemTarih ASC", baglanti);
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    durum = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), ilk);
                    durum_2 = DateTime.Compare(Convert.ToDateTime(oku["islemTarih"].ToString()), son);
                    if (durum >= 0 && durum_2 <= 0)
                    {
                        rapor.Add(new Paragraph("Islem Türü : " + oku["İslemTuru"].ToString() + ""));
                        rapor.Add(new Paragraph("Tarih : " + oku["islemTarih"].ToString() + ""));
                        rapor.Add(new Paragraph("Ürün Tipi : " + oku["urunAdi"].ToString() + " "));
                        rapor.Add(new Paragraph("Tutar : " + oku["UrunFiyat"].ToString() + " TL"));
                        rapor.Add(new Paragraph("Miktar : " + oku["UrunMiktar"].ToString() + " kg "));
                        rapor.Add(new Paragraph(""));

                    }


                }
                baglanti.Close();
                rapor.Close();
                MessageBox.Show("Rapor olusturuldu", "Tamam");
            }
            

        }
        private void uruntur()
        {

            //ürün raporu  icin comboboxa veri tabanından itemler çekiliyor.
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from kUrun where KullaniciU = '"+Kullanici_adi+"'", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                urunler.Items.Add(oku["UrunAdi"].ToString());
            }
            baglanti.Close();
        }
        private void tarih_ekle()
        {
            //Rapor  icin comboboxa veri tabanından itemler çekiliyor.
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from İslemler where KullaniciAdi = '" + Kullanici_adi + "' ORDER BY islemTarih ASC", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                Btarih.Items.Add(oku["islemTarih"].ToString());
                Starih.Items.Add(oku["islemTarih"].ToString());
            }
            baglanti.Close();
        }
    }
}
