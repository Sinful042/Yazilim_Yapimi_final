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
        public para_ekle_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        private void ekle_btn_Click(object sender, EventArgs e)
        {
            
                if (istek_para.Text == "")
                {
                    MessageBox.Show("Lütfen miktar Giriniz.", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    


                }

            
            else
            {
                Para_ekle(istek_para.Text);
            }
        }


        public void Para_ekle(string miktar)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Paraekle(KullaniciPekle,İstekPekle) values('"+kullanici_adi+"','"+miktar+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Para İsteme Alınmıştır","Tamam");
            this.Hide();

        }

        private void para_ekle_frm_Load(object sender, EventArgs e)
        {

        }

        private void cikisparaekle_Click(object sender, EventArgs e)
        {
            ana_fr anasayfa = new ana_fr();
            anasayfa.Show();

        }
    }
}
