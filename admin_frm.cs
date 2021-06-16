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
    public partial class admin_frm : Form
    {
        public int Kullanici_sayi;

        public admin_frm()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = Giris_frm.baglanti_kur();
        DataTable tablo = new DataTable();
        private void para_list_btn_Click(object sender, EventArgs e)
        {
            para_ist_frm admin_sayfa = new para_ist_frm();
            admin_sayfa.Show();
            this.Hide();
        }
        public void listele()
        {
            baglanti.Open();
            OleDbDataAdapter liste = new OleDbDataAdapter("select * from Kullanici where Yetki='" + "Kullanici" + "'", baglanti);
      
            liste.Fill(tablo);
            tumkullanicilar.DataSource = tablo;
            tumkullanicilar.DefaultCellStyle.SelectionBackColor = Color.White;
            tumkullanicilar.DefaultCellStyle.SelectionForeColor = Color.Red;
            baglanti.Close();

        }

        private void cikis_btn_Click(object sender, EventArgs e)
        {
            Giris_frm giris = new Giris_frm();
            giris.Show();
            this.Hide();

        }

        private void satis_btn_Click(object sender, EventArgs e)
        {
            satis_ist_frm satis = new satis_ist_frm();
            satis.Show();
            this.Hide();
        }

        private void admin_frm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kullanicisay = new OleDbCommand("SELECT COUNT(*) AS ToplamKayit FROM Kullanici WHERE Yetki='"+ "Kullanici" +"'", baglanti);

            OleDbDataReader oku = kullanicisay.ExecuteReader();
             if (oku.Read())
             {
                 
                 kullanici_sayisi.Text = oku["ToplamKayit"].ToString();
             }
            baglanti.Close();

            listele();
        }

        private void cikisadmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
