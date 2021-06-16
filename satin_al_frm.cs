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
    public partial class satin_al_frm : Form
    {
        //alici ve satici kullanici bilgileri
        public string alici_kullanici_adi,satici_kullanici_adi;
        //istek ürün bilgileri
        string istek_ürün, urun_birim;
        //alicinin total parası
        public string para;
        //harcanıcak para ve kalıcak para
        double harcanan_para, total_para;
        //alım bilgileri
        double istek_miktar,olan_miktar,alinan_miktar;
        //alinicak fiyat
        int alinan_fiyat;
        //alım kontrol
        bool alim_gerceklesti;
        //aliciya gönderilicek para
        double gonderilen_para;
        //muhasebeye gönderilicek para
        double muhasebe_ucret;
       

        public satin_al_frm()
        {
            InitializeComponent();
        }
        //veri tabani baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //alinacak ürünler listesi icin dataTable olusturuluyor
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            ana_fr ana = new ana_fr();
            ana.Kullanici_adi = alici_kullanici_adi;
            if(alim_gerceklesti)
            {
                ana.Para = total_para.ToString();
                ana.Show();
                this.Hide();

            }
            else
            {
                ana.Para = para;
                ana.Show();
                this.Hide();
            }
          
        }

        private void satin_al_frm_Load(object sender, EventArgs e)
        {
            
            Listeleme();
            paraguncelle(para);
            uruntur();
           
        }
        private void paraguncelle(string para)
        {
            lbl_para.Text = para;




        }
        private void Listeleme()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select UrunAdi,UrunBirim,UrunTuru from Urunler", baglanti);
            liste.Fill(tablo);
            
            urunlersatinal.DataSource = tablo;

            urunlersatinal.ReadOnly = true;
            
            urunlersatinal.DefaultCellStyle.SelectionBackColor = Color.White;
            urunlersatinal.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
            baglanti.Close();

        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filitre_listeleme(string uruntur)
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter liste1 = new OleDbDataAdapter("select UrunAdi,UrunBirim,UrunTuru from Urunler where UrunTuru= '" + uruntur + "'", baglanti);
            liste1.Fill(tablo);
            urunlersatinal.DataSource = tablo;
            urunlersatinal.DefaultCellStyle.SelectionBackColor = Color.White;
            urunlersatinal.DefaultCellStyle.SelectionForeColor = Color.Green;
            baglanti.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < filtre_cmbx.Items.Count; i++)
            {
                if (filtre_cmbx.SelectedIndex == i)
                {
                    filitre_listeleme(filtre_cmbx.SelectedItem.ToString());
                }
            }
        }

        private void uruntur()
        {

            //filitreme icin comboboxa veri tabanından itemler çekiliyor.
            filtre_cmbx.Items.Clear();
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("select *from UrunTur", baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                filtre_cmbx.Items.Add(oku["UrunTuru"].ToString());
            }
            baglanti.Close();
        }
        private void satin_al_piyasa_Click(object sender, EventArgs e)
        {
            //istek birim girdisi kontrol ediliyor
            if (birim.Text== "Lütfen birim giriniz")
            {
               
               MessageBox.Show("Lütfen kaç birim almak istediğinizi belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //alici para bilgisi kontrol ediliyor
            else if (para == " ")
            {
                MessageBox.Show("Lütfen önce para yükleyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //fiyat belirleme formuna gidilip gerekli bilgiler gonderiliyor.
                fiyatbelirle fiyatbelirle = new fiyatbelirle();
                istek_ürün = urunlersatinal.CurrentRow.Cells["UrunAdi"].Value.ToString();
                fiyatbelirle.istek_birim = Convert.ToDouble(birim.Text.Replace(".",","));
                fiyatbelirle.alici_kullanici_adi = alici_kullanici_adi;
                fiyatbelirle.istek_ürün = istek_ürün;
                fiyatbelirle.alici_para = double.Parse(para);
                fiyatbelirle.Show();
                
            }
            

        }

        private void birim_Enter(object sender, EventArgs e)
        {
            if (birim.Text == "Lütfen birim giriniz")
            {
                birim.Text = "";
                birim.ForeColor = Color.Black;
            }
        }

        

        private void birim_Leave(object sender, EventArgs e)
        {
            if (birim.Text == "")
            {
                birim.Text = "Lütfen birim giriniz";
                birim.ForeColor = Color.Silver;
            }
        }

        
        

        private void satın_al_btn_Click(object sender, EventArgs e)
        {
            //İstek birim girdisi kontrol ediliyor
            if (birim.Text == "Lütfen birim giriniz")
            {
                MessageBox.Show("Lütfen kaç birim almak istediğinizi belirtiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                alim_gerceklesti = false;
                harcanan_para = 0;
                alinan_miktar = 0;
                gonderilen_para = 0;
                istek_miktar = Convert.ToDouble(birim.Text.Replace(".", ","));
                istek_ürün = urunlersatinal.CurrentRow.Cells["UrunAdi"].Value.ToString();
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("Select *from Satis where UrunAdi = '" + istek_ürün + "'  AND NOT KullaniciAdi='" + alici_kullanici_adi + "' AND SatisOnay ='"+"Onaylandi"+"'ORDER BY UrunFiyat ASC");
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    if (istek_miktar <= Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",",")) && Convert.ToDouble(oku["sUrunMiktar"].ToString()) > 0)
                    {
                        alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                        gonderilen_para = istek_miktar * alinan_fiyat;
                        harcanan_para += gonderilen_para;
                        muhasebe_ucret = harcanan_para / 100;
                        harcanan_para += muhasebe_ucret;
                        satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                        urun_birim = oku["UrunBirim"].ToString();

                        if (Convert.ToDouble(para.Replace(".", ",")) >= harcanan_para)
                        {
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            Para_gonder("Muhasebe",muhasebe_ucret);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, istek_miktar, alinan_fiyat);
                            istek_miktar += alinan_miktar;
                            alim_gerceklesti = true;
                            MessageBox.Show("Satın Alım Gerçekleştirilmiştir", "Tamam");

                            birim.Clear();
                            break;

                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }



                    }
                    else if (istek_miktar > Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",",")) && Convert.ToDouble(oku["sUrunMiktar"].ToString()) > 0)
                    {
                        alinan_miktar = Convert.ToDouble(oku["sUrunMiktar"].ToString().Replace(".",","));
                        satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                        alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                        gonderilen_para = alinan_miktar * alinan_fiyat;
                        harcanan_para += gonderilen_para;
                        if (Convert.ToDouble(para.Replace(".", ",")) >= harcanan_para)
                        {
                            urun_birim = oku["UrunBirim"].ToString();
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, alinan_miktar, alinan_fiyat);
                            istek_miktar -= alinan_miktar;

                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }



                    }


                }
                if (alim_gerceklesti)
                {
                    urun_ekle(alici_kullanici_adi, istek_miktar.ToString(), istek_ürün, urun_birim);
                    Para_cikar(alici_kullanici_adi, harcanan_para);


                }
                else
                {
                    MessageBox.Show("İstediginiz miktarda ürün şatışda bulunmamaktır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                baglanti.Close();
            }
            

        }
        
        private void Para_gonder(string satici_Kullanici_adi,double gelen_para)
        {
            
            
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==satici_Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            
            

        }
        private void Para_cikar(string Kullanici_adi,double para)
        {
            
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString() == Kullanici_adi)
                {

                    total_para = Convert.ToDouble(oku["Cuzdan"].ToString().Replace(".",","));
                    break;
                }

            }
            total_para -= para;
            
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();

            paraguncelle(total_para.ToString());

            
        }
        private void urun_ekle(string Kullanici_adi,string alinan_miktar,string urunAd,string Birim)
        {
            
            OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
            komut.ExecuteNonQuery();
            
            

        }
        private void  satistan_cikar(string Urunadi,string Kullanici_Adi,double alinan_miktar,int alinan_fiyat)
        {
            
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '"+Urunadi+"'",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==Kullanici_Adi)
                {
                    olan_miktar = Convert.ToDouble(oku["SUrunMiktar"].ToString().Replace(".",","));
                    break;
                }
            }
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='"+alinan_fiyat.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            
        }
    }
}
