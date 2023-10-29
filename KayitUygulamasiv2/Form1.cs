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
    }
}
