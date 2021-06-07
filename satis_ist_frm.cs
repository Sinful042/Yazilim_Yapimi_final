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
                    durum = "Onaylandi";
                    baglanti.Close();
                    durum_güncelle(Kullanici_adi,Urunid,Fiyat,durum);
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
    }
}
