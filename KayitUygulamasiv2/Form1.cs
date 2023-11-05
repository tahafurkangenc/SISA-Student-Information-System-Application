using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace KayitUygulamasiv2
{
    public partial class Form1 : Form
    {
        String totalsonuc="";
        public Form1()
        {
            InitializeComponent();
            
        }

        private void OCRveriislebutton_Click(object sender, EventArgs e)
        {
            String[] totalsonucStringArray = totalsonuc.Split('\n');
            String tmp=null;
            for(int i = 0; i < totalsonucStringArray.Length; i++)
            {
                Console.WriteLine(i+"-)"+totalsonucStringArray[i]);
                if (totalsonucStringArray[i].StartsWith(":") && OgrenciIDTextBox.Text.Equals(""))
                {
                    tmp = totalsonucStringArray[i].Substring(1).Trim();
                    OgrenciIDTextBox.Text = totalsonucStringArray[i].Substring(1).Trim();
                    OgrenciisimTextBox.Text = totalsonucStringArray[i+2].Substring(1).Trim();
                    OgrencisoyisimTextBox.Text = totalsonucStringArray[i + 3].Substring(1).Trim();
                    //break;
                    Console.WriteLine("Ogrenci ID ADDED: " + tmp + "---");
                }
                if (totalsonucStringArray[i].StartsWith("(ype of Educatior)") && AgnoTextBox.Text.Equals(""))
                {
                    tmp = totalsonucStringArray[i].Substring(totalsonucStringArray[i].IndexOf(":")+1).Trim();
                    AgnoTextBox.Text = totalsonucStringArray[i].Substring(totalsonucStringArray[i].IndexOf(":")+1).Trim(); 
                    //break;
                    Console.WriteLine("AGNO ADDED: " + tmp + "---");
                }
                if (totalsonucStringArray[i].StartsWith("(2021—2022 Fall Term)") && AlinanderskodlaririchTextBox.Text.Equals(""))
                {
                    int j = 1;
                    while (!(totalsonucStringArray[i + j].StartsWith("DNO")))
                    {
                        AlinanderskodlaririchTextBox.Text += totalsonucStringArray[i + j].Substring(0, 6).Trim();
                        j=j+2;
                        if((totalsonucStringArray[i + j].StartsWith("DNO")))
                        {
                            break;
                        }
                        else
                        {
                            AlinanderskodlaririchTextBox.Text += "\n";
                        }
                    }
                }
                if (totalsonucStringArray[i].StartsWith("(2021—2022 Spring Term)"))
                {
                    int j = 1;
                    while (!(totalsonucStringArray[i + j].StartsWith("DNO")))
                    {
                        AlinanderskodlaririchTextBox.Text += totalsonucStringArray[i + j].Substring(0, 6).Trim();
                        j = j + 2;
                        if ((totalsonucStringArray[i + j].StartsWith("DNO")))
                        {
                            break;
                        }
                        else
                        {
                            AlinanderskodlaririchTextBox.Text += "\n";
                        }
                    }
                }
            }
            
        }

        private void OCRverieklebutton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                // var img = Pix.LoadFromFile(openFileDialog1.FileName);
                var ocr = new TesseractEngine("./tr", "tur");
                var sonuc = ocr.Process(img);
                totalsonuc = totalsonuc + "NEWFILE" + sonuc.GetText().ToString();
                Console.WriteLine(totalsonuc);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OCRverisilbutton_Click(object sender, EventArgs e)
        {
            totalsonuc = "";
        }

        private void OgrenciSifreLabel_Click(object sender, EventArgs e)
        {

        }

        private void AlinanderskodlaririchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OgrenciEkleButton_Click(object sender, EventArgs e)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.isim = OgrenciisimTextBox.Text;
            ogrenci.soyisim = OgrencisoyisimTextBox.Text;
            ogrenci.ID = int.Parse(OgrenciIDTextBox.Text);
            ogrenci.sifre = OgrencisifreTextBox.Text;
            ogrenci.AGNO = double.Parse(AgnoTextBox.Text)/100.0;
            ogrenci.talepsayisi = 0;
            String[] derslerinisimleri_ID = AlinanderskodlaririchTextBox.Text.Split('\n');
            for(int i = 0;i < derslerinisimleri_ID.Length; i++)
            {
                int sayisalnot = Program.random.Next(101);
                String harfnot;
                if (sayisalnot < 30)
                {
                    harfnot = "FF";
                }
                else if (sayisalnot >= 30 && sayisalnot <= 39)
                {
                    harfnot = "FD";
                }
                else if (sayisalnot >= 40 && sayisalnot <= 49)
                {
                    harfnot = "DD";
                }
                else if (sayisalnot >= 50 && sayisalnot <= 59)
                {
                    harfnot = "CD";
                }
                else if (sayisalnot >= 60 && sayisalnot <= 69)
                {
                    harfnot = "CC";
                }
                else if (sayisalnot >= 70 && sayisalnot <= 74)
                {
                    harfnot = "CB";
                }
                else if (sayisalnot >= 75 && sayisalnot <= 79)
                {
                    harfnot = "BB";
                }
                else if (sayisalnot >= 80 && sayisalnot <= 89)
                {
                    harfnot = "BA";
                }
                else // sayisalnot 90-100 arasında
                {
                    harfnot = "AA";
                }
                List<Ders> dersihtimalleri = new List<Ders>();
                for(int j = 0; j < Program.dersler.Count; j++)
                {
                    if (Program.dersler[j].dersID.Equals(derslerinisimleri_ID[i].Trim()))
                    {
                        dersihtimalleri.Add(Program.dersler[j]);
                    }
                }
                if(dersihtimalleri.Count > 0)
                {
                    int rastgeleindis = Program.random.Next(dersihtimalleri.Count);
                    DersNotlari eklenecekdersnotlari= new DersNotlari();
                    eklenecekdersnotlari.dersID = dersihtimalleri[rastgeleindis].dersID;
                    eklenecekdersnotlari.dersadi = dersihtimalleri[rastgeleindis].dersadi;
                    eklenecekdersnotlari.dersiverenhocaID = dersihtimalleri[rastgeleindis].dersiverenhocaID;
                    eklenecekdersnotlari.sayisalnot= sayisalnot;
                    eklenecekdersnotlari.harfnotu = harfnot;
                    ogrenci.alinandersler.Add(eklenecekdersnotlari);
                }
                
            }

            String[] eklenenilgialanlari = richTextBox1.Text.Split('\n');
            Console.WriteLine("ILGI ALANLARI:");
            for(int i = 0; i < eklenenilgialanlari.Length; i++)
            {
                for(int j = 0; j < Program.ilgialanlari.Count; j++)
                {
                    if (Program.ilgialanlari[j].ilgialaniadi.Equals(eklenenilgialanlari[i].Trim()))
                    {
                        ogrenci.ilgialanlari.Add(eklenenilgialanlari[i].Trim());
                        break;
                    }
                }
            }

            Console.WriteLine("AGNO DENEMESİ :" + ogrenci.AGNO);
            NpgsqlCommand ogrencitabloeklemekomut = new NpgsqlCommand("INSERT INTO ogrenci (ogrenci_id,ogrenci_isim,ogrenci_soyisim,ogrenci_parola,agno,talepsayisi) VALUES(" + ogrenci.ID + ",'" + ogrenci.isim + "','" + ogrenci.soyisim + "','" + ogrenci.sifre + "'," + ogrenci.AGNO.ToString().Replace(',','.') + "," + ogrenci.talepsayisi + ");", Program.baglanti);
            ogrencitabloeklemekomut.ExecuteNonQuery();


            Console.WriteLine(ogrenci.ToString());
            Console.WriteLine("Ilgi Alanlari:");
            for(int i = 0; i < ogrenci.ilgialanlari.Count; i++)
            {
                for (int j = 0; j < Program.ilgialanlari.Count; j++)
                {
                    if (ogrenci.ilgialanlari[i].Equals(Program.ilgialanlari[j].ilgialaniadi))
                    {
                        NpgsqlCommand ilgialanlaribaglakomut = new NpgsqlCommand("INSERT INTO ogrenci_ilgialani (ogrenci_id,ilgialani_id) VALUES (" + ogrenci.ID + "," + Program.ilgialanlari[j].ID +");", Program.baglanti);
                        Console.WriteLine(ogrenci.ilgialanlari[i]);
                        ilgialanlaribaglakomut.ExecuteNonQuery();
                        break;
                    }
                }
            }
            Console.WriteLine("Alinan Dersler:");
            for (int i = 0; i < ogrenci.alinandersler.Count; i++)
            {
                NpgsqlCommand ogrencialinanderslerkomut = new NpgsqlCommand("INSERT INTO alinandersler (ogrenci_id,ders_id,sayisalnot,harfnot,dersiverenhoca_id) VALUES(" + ogrenci.ID + ",'" + ogrenci.alinandersler[i].dersID + "'," + ogrenci.alinandersler[i].sayisalnot + ",'" + ogrenci.alinandersler[i].harfnotu + "'," + ogrenci.alinandersler[i].dersiverenhocaID +");", Program.baglanti);
                Console.WriteLine(ogrenci.alinandersler[i].ToString());
                ogrencialinanderslerkomut.ExecuteNonQuery();
            }

            Program.ogrenciler.Add(ogrenci);
            
        }
    }
}
