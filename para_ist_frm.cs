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
using System.Xml;

namespace Proje_Ödevi
{
    public partial class para_ist_frm : Form
    {
        private string para;
        private double şuanki_para;
        private double total_para;
        private double istek_para;
        private string durum;
        private string filitre;
        private double tl;

        public para_ist_frm()
        {
            InitializeComponent();
        }
        //veri tabanı baglantisi kuruluyor
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        //para istekleri için dataTable olusturuluyor.
        DataTable tablo = new DataTable();
        private void cikis_btn_Click(object sender, EventArgs e)
        {
            admin_frm admingeri = new admin_frm();
            admingeri.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter fiyat_liste = new OleDbDataAdapter("select  *from Satis ORDER BY UrunFiyat ASC", baglanti);
            baglanti.Close();
            Listeleme();

        }
        public void Listeleme()
        {
                baglanti.Open();
                OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle", baglanti);
                liste.Fill(tablo);
                paralisteleme.DataSource = tablo;
                paralisteleme.ReadOnly = true;
                paralisteleme.DefaultCellStyle.SelectionBackColor = Color.White;
                paralisteleme.DefaultCellStyle.SelectionForeColor = Color.Red;
                baglanti.Close();

            
        }
        public void Filitre_Liste(string durum)
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle where Durum = '" + durum + "'", baglanti);
            liste.Fill(tablo);
            paralisteleme.DataSource = tablo;
            baglanti.Close();
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + paralisteleme.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["Durum"].ToString()=="Onaylandı")
                {
                    MessageBox.Show("Para isteği daha önce onaylamış", "Tamam");
                    baglanti.Close();
                    break;
                }
                else if (oku["Durum"].ToString()=="Onaylanmadi")
                {
                    MessageBox.Show("Para isteği daha önce reddedilmiş", "Tamam");
                    baglanti.Close();
                    break;
                }
                else
                {
                    baglanti.Close();
                    Para_ekle();
                    break;

                }
            }

            tablo.Clear();
            Listeleme();

        }
        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + paralisteleme.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (oku["Durum"].ToString() == "Onaylandı")
                {
                    MessageBox.Show("Para isteği daha önce onaylamış", "Tamam");
                    baglanti.Close();
                    break;
                    
                }
                else if (oku["Durum"].ToString() == "Onaylanmadi")
                {
                    MessageBox.Show("Para isteği daha önce reddedilmiş", "Tamam");
                    baglanti.Close();
                    break;
                    
                }
                else
                {
                    baglanti.Close();
                    durum = "Onaylanmadi";
                    string istek = paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString();
                    string kullanici = paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString();
                    Durum_güncelle(durum,istek,kullanici);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    break;
                    
                }
            }
            tablo.Clear();
            Listeleme();

        }


        public void para_güncelle(double para)
        {
            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + para.ToString() + "' where KullaniciAdi = '" + paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylama Başarılı", "Tamam");
        }
        public void Durum_güncelle(string durum,string istek,string kullanici)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("update Paraekle set Durum= '" + durum + "' where İstekPekle=  '" + istek + "' and KullaniciPekle = '"+kullanici+"'", baglanti);
            sorgu.ExecuteReader();
            baglanti.Close();
            tablo.Clear();
            Filitre_Liste(filitre);
            

        }
        public void Para_ekle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where İstekPekle= '" + paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                para = oku["İstekPekle"].ToString();
                tl = kur_hesabı(Int32.Parse(para),oku["KullaniciPekle"].ToString());
                istek_para = tl;
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("Select *from Kullanici where KullaniciAdi= '" + paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {
                para = oku_2["Cuzdan"].ToString();
                şuanki_para = double.Parse(para);
                total_para = istek_para + şuanki_para;
            }
            baglanti.Close();
            para_güncelle(total_para);
            durum = "Onaylandı";
            string istek = paralisteleme.CurrentRow.Cells["İstekPekle"].Value.ToString();
            string kullanici = paralisteleme.CurrentRow.Cells["KullaniciPekle"].Value.ToString();
            Durum_güncelle(durum,istek,kullanici);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (istekler.SelectedIndex==0)
            {
                filitre = "Onaylandı";
                tablo.Clear();
                Filitre_Liste(filitre);
            }
            else if (istekler.SelectedIndex==1)
            {
                tablo.Clear();
                filitre= "Onaylanmadi";
                Filitre_Liste(filitre);
            }
            else
            {
                tablo.Clear();
                filitre = "Bekleniyor";
                Filitre_Liste(filitre);
            }
        }

        private void cikisanasayfa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private double kur_hesabı(int  istek_para,string kullanici)
        {
            string kurlar = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();
            xml.Load(kurlar);
            OleDbCommand komut_2 = new OleDbCommand("Select *from Paraekle where KullaniciPekle= '" + kullanici + "' and İstekPekle= '"+istek_para.ToString()+"'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())

            {   //Tl'ye cevir
                if (oku_2["ParaTip"].ToString() == "TRY")
                {
                    tl = istek_para;

                }
                else if (oku_2["ParaTip"].ToString() == "EUR")
                {
                    //euroya cevir
                    string euro_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml;
                    double euro = Convert.ToDouble(euro_kur.Replace(".", ","));
                    tl = istek_para * euro;
                    tl = Math.Round(tl, 2);
                    



                }
                else if (oku_2["ParaTip"].ToString() == "USD")
                {
                    //dolara çevir
                    string usd_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml;
                    double usd = Convert.ToDouble(usd_kur.Replace(".", ","));
                    tl = istek_para * usd;
                    tl = Math.Round(tl, 2);
                }
                else if (oku_2["ParaTip"].ToString() == "GBP")
                {
                    //rubleye çevir
                    string gbp_kur = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='GBP']/BanknoteSelling").InnerXml;
                    double gbp = Convert.ToDouble(gbp_kur.Replace(".", ","));
                    tl = istek_para * gbp;
                    tl = Math.Round(tl, 2);
                }
            }


            return tl;

        }

        private void istekler_Leave(object sender, EventArgs e)
        {
           
        }

        private void istekler_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
