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
        public string alici_kullanici_adi,satici_kullanici_adi;
        public string para;
        int harcanan_para,total_para,yenipara;
        string istek_ürün,urun_birim;
        int istek_miktar, alinan_fiyat;
        int olan_miktar,alinan_miktar;
        string filitre;
        bool alim_gerceklesti;
        int gonderilen_para;
       


        public satin_al_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
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
            
            dataGridView1.DataSource = tablo;

            dataGridView1.ReadOnly = true;
            
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
            baglanti.Close();

        }

        private void admin_label_Click(object sender, EventArgs e)
        {

        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filitre_liste(string UrunTuru)
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  UrunAdi,UrunBirim,UrunTuru from Urunler where UrunTuru = '" + UrunTuru + "'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tablo.Clear();
                filitre = "Yiyecek";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                tablo.Clear();
                filitre = "Giysi";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                tablo.Clear();
                filitre = "Hammadde";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                tablo.Clear();
                filitre = "Kırtasiye";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                tablo.Clear();
                filitre = "Elektronik";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                tablo.Clear();
                filitre = "Aksesuar";
                filitre_liste(filitre);
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                tablo.Clear();
                filitre = "Mutfak";
                filitre_liste(filitre);
            }

            else
            {
                tablo.Clear();
                filitre = "Bekleniyor";
                filitre_liste(filitre);
            }
        }

        private void satin_al_piyasa_Click(object sender, EventArgs e)
        {
            fiyatbelirle fiyatbelirle = new fiyatbelirle();
            fiyatbelirle.Show();
            
        }

        private void lbl_para_Click(object sender, EventArgs e)
        {

        }

        private void satın_al_btn_Click(object sender, EventArgs e)
        {

            alim_gerceklesti = false;
            harcanan_para = 0;
            alinan_miktar = 0;
            gonderilen_para = 0;
            istek_miktar = Convert.ToInt32(textBox1.Text);
            istek_ürün = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglanti;
            komut.CommandText = ("Select *from Satis where UrunAdi = '" + istek_ürün + "'  AND NOT KullaniciAdi='"+alici_kullanici_adi+"'ORDER BY UrunFiyat ASC");
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
             {
                        if (istek_miktar <= Convert.ToInt32(oku["sUrunMiktar"].ToString()) && Convert.ToInt32(oku["sUrunMiktar"].ToString()) > 0)
                        {
                            alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                            gonderilen_para = istek_miktar * alinan_fiyat;
                            harcanan_para += gonderilen_para;
                            satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                            urun_birim = oku["UrunBirim"].ToString();

                        if (Convert.ToInt32(para)>=harcanan_para)
                        {
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, istek_miktar, alinan_fiyat);
                            istek_miktar += alinan_miktar;
                            alim_gerceklesti = true;
                            MessageBox.Show("Satın Alım Gerçekleştirilmiştir", "Tamam");
                       
                        textBox1.Clear();
                        break;

                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Tamam");
                            break;
                        }
                            
                        
                            
                        }
                        else if (istek_miktar > Convert.ToInt32(oku["sUrunMiktar"].ToString()) && Convert.ToInt32(oku["sUrunMiktar"].ToString()) >0)
                        {
                            alinan_miktar = Convert.ToInt32(oku["sUrunMiktar"].ToString());
                            satici_kullanici_adi = oku["KullaniciAdi"].ToString();
                            alinan_fiyat = Convert.ToInt32(oku["UrunFiyat"].ToString());
                            gonderilen_para = alinan_miktar * alinan_fiyat;
                            harcanan_para += gonderilen_para;
                        if (Convert.ToInt32(para) >= harcanan_para)
                        {
                            urun_birim = oku["UrunBirim"].ToString();
                            Para_gonder(satici_kullanici_adi, gonderilen_para);
                            satistan_cikar(istek_ürün, satici_kullanici_adi, alinan_miktar, alinan_fiyat);

                            istek_miktar -= alinan_miktar;
                            
                        }
                        else
                        {
                            MessageBox.Show("Bakiyeniz Yeterli değildir!", "Tamam");
                            break;
                        }
                        
                            
                            
                            


                        }


             }
                if (alim_gerceklesti)
                {
                    urun_ekle(alici_kullanici_adi,istek_miktar.ToString(),istek_ürün,urun_birim);
                    Para_cikar(alici_kullanici_adi, harcanan_para);
                

                }
                 baglanti.Close();


        }
        
        private void Para_gonder(string satici_Kullanici_adi,int gelen_para)
        {
            
            
            OleDbCommand komut = new OleDbCommand("select *from Kullanici", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==satici_Kullanici_adi)
                {

                    total_para = Convert.ToInt32(oku["Cuzdan"].ToString());
                    break;
                }

            }
            gelen_para += total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + gelen_para.ToString() + "' where KullaniciAdi = '" + satici_Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();
            
            

        }
        private void Para_cikar(string Kullanici_adi,int para)
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
            total_para -= para;
            yenipara = total_para;
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + total_para.ToString() + "' where KullaniciAdi = '" + Kullanici_adi + "'", baglanti);
            komut_2.ExecuteNonQuery();

            paraguncelle(total_para.ToString());

            
        }
        private void urun_ekle(string Kullanici_adi,string alinan_miktar,string urunAd,string Birim)
        {
            
            OleDbCommand komut = new OleDbCommand("insert into kUrun(UrunAdi,UrunMiktar,KullaniciU,UrunBirim) values('" + urunAd + "','" + alinan_miktar + "','" + Kullanici_adi + "','" + Birim + "')", baglanti);
            komut.ExecuteNonQuery();
            
            

        }
        private void satistan_cikar(string Urunadi,string Kullanici_Adi,int alinan_miktar,int alinan_fiyat)
        {
            
            OleDbCommand sorgu = new OleDbCommand("select *from Satis where UrunAdi= '"+Urunadi+"'",baglanti);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                if (oku["KullaniciAdi"].ToString()==Kullanici_Adi)
                {
                    olan_miktar = Convert.ToInt32(oku["SUrunMiktar"].ToString());
                    break;
                }
            }
            olan_miktar -= alinan_miktar;
            OleDbCommand komut = new OleDbCommand("update Satis set sUrunMiktar='" + olan_miktar.ToString() + "' where KullaniciAdi='" + Kullanici_Adi + "' and UrunAdi='" + Urunadi + "' and UrunFiyat ='"+alinan_fiyat.ToString()+"'", baglanti);
            komut.ExecuteNonQuery();
            
        }
    }
}
