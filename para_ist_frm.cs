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
    public partial class para_ist_frm : Form
    {
        private string para;
        private int şuanki_para;
        private int total_para;
        private int istek_para;
        private string durum;
        private string filitre;
        
        
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


        public void para_güncelle(int para)
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
                istek_para = Int32.Parse(para);
            }
            baglanti.Close();

            baglanti.Open();
            OleDbCommand komut_2 = new OleDbCommand("Select *from Kullanici where KullaniciAdi= '" + dataGridView1.CurrentRow.Cells["KullaniciPekle"].Value.ToString() + "'", baglanti);
            OleDbDataReader oku_2 = komut_2.ExecuteReader();
            while (oku_2.Read())
            {
                para = oku_2["Cuzdan"].ToString();
                şuanki_para = Int32.Parse(para);
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
    }
}
