using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitUygulamasiv2
{
    public partial class yoneticiForm : Form
    {
        Yonetici yonetici;
        public yoneticiForm(Yonetici yonetici)
        {
            InitializeComponent();
            this.yonetici = yonetici;
        }

        private void ogrencikayitbutton_Click(object sender, EventArgs e)
        {
            Form1 Form = new Form1();
            Form.Visible = true;
        }

        private void yoneticiForm_Load(object sender, EventArgs e)
        {
            yoneticiIDLabel.Text="Yönetici ID = "+yonetici.ID;
            yoneticiİsimLabel.Text = "Yönetici İsim = " + yonetici.isim;
            yoneticiSoyisimLabel.Text = "Yönetici Soy İsim = " + yonetici.soyisim;
        }
    }
}
