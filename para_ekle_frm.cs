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
    public partial class para_ekle_frm : Form
    {
        public string kullanici_adi;
        string para_tipi;
        public string Kullanici_adi;
        public string Para;
        public para_ekle_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            if (istek_para.Text== "Lütfen Miktarı giriniz")
            {
                MessageBox.Show("Lütfen miktar Giriniz.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (paratip.SelectedItem==null)
            {
                MessageBox.Show("Lütfen para tipini şeçiniz", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                para_tipi = paratip.SelectedItem.ToString();
                Para_ekle(istek_para.Text,para_tipi);
            }


        }


        private void Para_ekle(string miktar,string para_tipi)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Paraekle(KullaniciPekle,İstekPekle,ParaTip) values('"+kullanici_adi+"','"+miktar+ "','" +para_tipi + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para İsteme Alınmıştır","Tamam");
            this.Hide();
            
        }

        

        private void cikisparaekle_Click(object sender, EventArgs e)
        {
            ana_fr anasayfa = new ana_fr();
            anasayfa.Kullanici_adi = Kullanici_adi;
            anasayfa.Para = Para;
            anasayfa.Show();
            this.Hide();

        }

        private void istek_para_Enter(object sender, EventArgs e)
        {
            if (istek_para.Text == "Lütfen Miktarı giriniz")
            {
                istek_para.Text = "";
                istek_para.ForeColor = Color.Black;
            }
        }

        private void istek_para_Leave(object sender, EventArgs e)
        {
            if (istek_para.Text == "")
            {
                istek_para.Text = "Lütfen Miktarı giriniz";
                istek_para.ForeColor = Color.Silver;
            }
        }

        private void paratip_Enter(object sender, EventArgs e)
        {
            if (paratip.Text== "Para Tipini Seçiniz")
            {
                paratip.Text = "";
                paratip.ForeColor = Color.Black;
            }
        }

        private void paratip_Leave(object sender, EventArgs e)
        {
            if (paratip.Text == "")
            {
                paratip.Text = "Para Tipini Seçiniz";
                paratip.ForeColor = Color.Silver;
            }
        }
    }
}
