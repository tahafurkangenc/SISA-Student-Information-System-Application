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
    public partial class OgrenciForm : Form
    {


        public Ogretmen IDdenOgretmenBul(int arananID)
        {
            for(int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (Program.ogretmenler[i].ID == arananID)
                {
                    return Program.ogretmenler[i];
                }
            }
            return null;    
        }

        Ogrenci ogrenci;
        public OgrenciForm(Ogrenci ogrenci)
        {
            this.ogrenci = ogrenci;
            InitializeComponent();

            // DataGridView'i hazırla
            ogrenciDersdataGridView.ColumnCount = 6; // Kaç sütun olacağını belirleyin

            // Sütun başlıklarını belirleyin
            ogrenciDersdataGridView.Columns[0].Name = "Ders ID";
            ogrenciDersdataGridView.Columns[1].Name = "Ders Adı";
            ogrenciDersdataGridView.Columns[2].Name = "Dersin Hocasının ID'si";
            ogrenciDersdataGridView.Columns[3].Name = "Dersin Hocası";
            ogrenciDersdataGridView.Columns[4].Name = "Alınan Not";
            ogrenciDersdataGridView.Columns[5].Name = "Harf Notu";

            OgrenciIDlabel.Text = "Öğrenci ID = " + ogrenci.ID;
            OgrenciİsimSoyisimLabel.Text = "Öğrenci İsim - Soy isim = " + ogrenci.isim + " " + ogrenci.soyisim;
            AGNOLabel.Text = "AGNO = " + ogrenci.AGNO;
            talepsayisiLabel.Text = "Talep Sayısı = " + ogrenci.talepsayisi;

        }

        private void OgrenciİsimSoyisimLabel_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            //ilgiAlanlariListBox.DataSource = ogrenci.ilgialanlari;
            for(int i = 0; i<ogrenci.ilgialanlari.Count; i++)
            {
                ilgiAlanlariListBox.Items.Add(ogrenci.ilgialanlari[i]);
            }
            for(int i=0; i < ogrenci.alinandersler.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ogrenciDersdataGridView);
                row.Cells[0].Value = ogrenci.alinandersler[i].dersID;
                row.Cells[1].Value = ogrenci.alinandersler[i].dersadi;
                row.Cells[2].Value = ogrenci.alinandersler[i].dersiverenhocaID;
                row.Cells[3].Value = IDdenOgretmenBul(ogrenci.alinandersler[i].dersiverenhocaID).isim + " " + IDdenOgretmenBul(ogrenci.alinandersler[i].dersiverenhocaID).soyisim;
                row.Cells[4].Value = ogrenci.alinandersler[i].sayisalnot;
                row.Cells[5].Value = ogrenci.alinandersler[i].harfnotu;
                ogrenciDersdataGridView.Rows.Add(row);
            }

        }
    }
}
