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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }


        private void ogrenciGirisButton_Click(object sender, EventArgs e)
        {
            Boolean ogrencigirisyapildimi = false;
            for (int i = 0; i < Program.ogrenciler.Count; i++)
            {
                if (int.Parse(girisIDtextBox.Text) == Program.ogrenciler[i].ID) // öğrenciyi bulduk
                {
                    ogrencigirisyapildimi = true;
                    Console.WriteLine("OGRENCİYİ BULDUK : " + Program.ogrenciler[i].ToString());
                    if (Program.ogrenciler[i].sifre.Equals(girisSifreTextBox.Text))
                    {
                        //this.Visible = false;
                        OgrenciForm ogrenciform = new OgrenciForm(Program.ogrenciler[i]);
                        ogrenciform.Visible= true;
                    }
                    else
                    {
                        MessageBox.Show("Tekrar Deneyiniz", "Şifre Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                }
              //Program.ogrenciler[i].ID.ToString)
            }if(!ogrencigirisyapildimi)
            {
               
                MessageBox.Show("Veri tabanında böyle bir öğrenci yok", "Ögrenci Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ogretmenGirisButton_Click(object sender, EventArgs e)
        {
            Boolean ogretmengirisyapildimi = false;
            for (int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (int.Parse(girisIDtextBox.Text) == Program.ogretmenler[i].ID) // öğretmeni bulduk
                {
                    ogretmengirisyapildimi = true;
                    Console.WriteLine("OGRETMENİ BULDUK : " + Program.ogretmenler[i].ToString());
                    if (Program.ogretmenler[i].sifre.Equals(girisSifreTextBox.Text))
                    {
                       // this.Visible = false;
                        OgretmenForm ogretmenform = new OgretmenForm(Program.ogretmenler[i]);
                        ogretmenform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Tekrar Deneyiniz", "Şifre Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                }
                //Program.ogrenciler[i].ID.ToString)
            }
            if (!ogretmengirisyapildimi)
            {
                
                MessageBox.Show("Veri tabanında böyle bir öğretmen yok", "Ögretmen Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void yoneticiGirisButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(girisIDtextBox.Text) == Program.yonetici.ID && Program.yonetici.Parola.Equals(girisSifreTextBox.Text))
            {
              // this.Visible=false;
               yoneticiForm yoneticiform = new yoneticiForm(Program.yonetici);
                yoneticiform.Show();
               
            }
            else 
            {
                MessageBox.Show("Veri tabanında böyle bir yönetici yok", "Yönetici Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
