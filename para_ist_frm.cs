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
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
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
                dataGridView1.DataSource = tablo;
                dataGridView1.ReadOnly = true;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Red;
                baglanti.Close();

            
        }
        public void Filitre_Liste(string durum)
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select  *from Paraekle where Durum = '" + durum + "'", baglanti);
            liste.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void onay_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + dataGridView1.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
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
            



        }
        private void onaylama_btn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where Durum= '" + dataGridView1.CurrentRow.Cells["Durum"].Value.ToString() + "'", baglanti);
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
                    string istek = dataGridView1.CurrentRow.Cells["İstekPekle"].Value.ToString();
                    Durum_güncelle(durum,istek);
                    MessageBox.Show("Reddetme Başarılı", "Tamam");
                    break;
                }
            }
        }


        public void para_güncelle(double para)
        {
            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("update Kullanici set Cuzdan = '" + para.ToString() + "' where KullaniciAdi = '" + dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            komut_2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Onaylama Başarılı", "Tamam");
        }
        public void Durum_güncelle(string durum,string istek)
        {
            baglanti.Open();
            OleDbCommand sorgu = new OleDbCommand("update Paraekle set Durum= '" + durum + "' where İstekPekle=  '" + istek + "'", baglanti);
            sorgu.ExecuteReader();
            baglanti.Close();
            tablo.Clear();
            Filitre_Liste(filitre);
            

        }
        public void Para_ekle()
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from Paraekle where İstekPekle= '" + dataGridView1.CurrentRow.Cells["İstekPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                para = oku["İstekPekle"].ToString();
                tl = kur_hesabı(double.Parse(para),oku["KullaniciPekle"].ToString());
                istek_para = tl;
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("Select *from Kullanici where KullaniciAdi= '" + dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
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
            string istek = dataGridView1.CurrentRow.Cells["İstekPekle"].Value.ToString();
            Durum_güncelle(durum,istek);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                filitre = "Onaylandı";
                tablo.Clear();
                Filitre_Liste(filitre);
            }
            else if (comboBox1.SelectedIndex==1)
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
        private double kur_hesabı(double para,string kullanici)
        {
            string kurlar = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xml = new XmlDocument();
            xml.Load(kurlar);
            OleDbCommand komut_2 = new OleDbCommand("Select *from Paraekle where KullaniciPekle= '" + kullanici + "' and İstekPekle= '"+para.ToString()+"'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {
                if (oku_2["ParaTip"].ToString() == "TRY")
                {
                    tl = para;

                }
                else if (oku_2["ParaTip"].ToString() == "EUR")
                {
                    //euroya cevir
                    string euro = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml;
                    tl = para * double.Parse(euro);
                   
                }
                else if (oku_2["ParaTip"].ToString() == "USD")
                {
                    //dolara çevir
                    string usd = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml;
                    tl = para * double.Parse(usd);
                }
                else
                {
                    //rubleye çevir
                    string rub = xml.SelectSingleNode("Tarih_Date/Currency[@Kod ='RUB']/BanknoteSelling").InnerXml;
                    tl = para * double.Parse(rub);
                    

                }
            }


            return tl;

        }
    }
}
