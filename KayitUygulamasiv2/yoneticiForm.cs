using Npgsql;
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
            for (int i = 0; i < Program.ilgialanlari.Count; i++)
            {
                ilgiAlanlariListBox.Items.Add(Program.ilgialanlari[i].ilgialaniadi);
            }
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

        private void ilgiAlanlariListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ilgialanieklebutton_Click(object sender, EventArgs e)
        {
            Boolean yeniilgialanimi = true;
            for (int i = 0; i < Program.ilgialanlari.Count; i++)
            {
                if (Program.ilgialanlari[i].ilgialaniadi.Equals(ilgialaniekleTextBox.Text))
                {
                    yeniilgialanimi=false;
                    MessageBox.Show("İlgi Alanı veri tabanında var", "VERİTABANI DOLU", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            if(yeniilgialanimi)
            {
                int verilecek_ID = 0;
                while(true){
                    Boolean idvarmi = false;
                    for(int i = 0; i < Program.ilgialanlari.Count; i++)
                    {
                        if (Program.ilgialanlari[i].ID == verilecek_ID)
                        {
                            idvarmi=true;
                            break;
                        }
                    }
                    if (idvarmi)
                    {
                        verilecek_ID++;
                    }
                    else
                    {
                        // Yeni İlgi alanı ekleme
                        Program.ilgialanlari.Add(new İlgiAlani(verilecek_ID, ilgialaniekleTextBox.Text));
                        Console.WriteLine("VERİLECEK ID=" + verilecek_ID + "    İLGİ ALANİ = " + ilgialaniekleTextBox.Text);
                        ilgiAlanlariListBox.Items.Add(ilgialaniekleTextBox.Text);

                        Program.baglanti.Open();
                        //NpgsqlCommand ilgialaniekle = new NpgsqlCommand("INSERT INTO ilgialani_isimler (ilgialani_id, ilgialani_isimler) VALUES ("+verilecek_ID+", '"+ilgialaniekleTextBox.Text+"') ;" , Program.baglanti);
                        NpgsqlCommand ilgialanieklemekomutu = new NpgsqlCommand("INSERT INTO ilgialani_isimler (ilgialani_id, ilgialani_isimler) VALUES (" + verilecek_ID + ", '" + ilgialaniekleTextBox.Text + "') ;", Program.baglanti);
                        ilgialanieklemekomutu.ExecuteNonQuery();
                        MessageBox.Show("İlgi Alanı veri tabanına eklendi", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    
                }
               // Program.ilgialanlari.Add(new İlgiAlani())
            }
        }
    }
}
