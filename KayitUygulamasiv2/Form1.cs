using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            
            String[] derslerinisimleri_notlari = AlinanderskodlaririchTextBox.Text.Split('\n');
            for(int i = 0;i < derslerinisimleri_notlari.Length; i++)
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
                    
                    Console.WriteLine("DERS ID = " + derslerinisimleri_notlari[i]);
                    Console.WriteLine("SAYISAL NOT = "+sayisalnot);
                    Console.WriteLine("HARF NOT = " +harfnot);
                    Console.WriteLine();
                
            }

            String[] ilgialanlari = richTextBox1.Text.Split('\n');
            Console.WriteLine("ILGI ALANLARI:");
            for(int i = 0; i < ilgialanlari.Length; i++)
            {
                Console.WriteLine(ilgialanlari[i]);
            }
        }
    }
}
