using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Ödevi
{
    public partial class rapor : Form
    {
        public rapor()
        {
            InitializeComponent();
        }

        private void gerirapor_Click(object sender, EventArgs e)
        {
            hesap hesap = new hesap();
            hesap.Show();
            this.Hide();
        }

        private void cikisrapor_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void raporal_Click(object sender, EventArgs e)
        {

        }
    }
}
