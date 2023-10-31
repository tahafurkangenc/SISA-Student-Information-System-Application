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
    public partial class OgretmenForm : Form
    {
        Ogretmen ogretmen;
        public OgretmenForm(Ogretmen ogretmen)
        {
            this.ogretmen = ogretmen;
            InitializeComponent();
            ogretmenVerilenDerslerGridView.ColumnCount = 3; // Kaç sütun olacağını belirleyin
            ogretmenVerilenDerslerGridView.Columns[0].Name = "Ders ID";
            ogretmenVerilenDerslerGridView.Columns[1].Name = "Ders Adı";
            ogretmenVerilenDerslerGridView.Columns[2].Name = "Kritik mi?";

            OgretmenIDlabel.Text = "Öğretmen ID = " + ogretmen.ID;
            OgretmenİsimSoyisimLabel.Text = "Öğretmen isim - soy isim = " + ogretmen.isim + " " + ogretmen.soyisim;
            SicilNoLabel.Text = "Sicil No = " + ogretmen.sicilno;
            kontenjanLabel.Text = "Kontenjan = " + ogretmen.kontenjan;
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            //ilgiAlanlariListBox.DataSource = ogretmen.ilgialanlari;
            for (int i = 0; i < ogretmen.ilgialanlari.Count; i++)
            {
                ilgiAlanlariListBox.Items.Add(ogretmen.ilgialanlari[i]);
            }
            for (int i = 0; i < ogretmen.verilendersler.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ogretmenVerilenDerslerGridView);
                row.Cells[0].Value = ogretmen.verilendersler[i].dersID;
                row.Cells[1].Value = ogretmen.verilendersler[i].dersadi;
                if (ogretmen.kritikdersler.Contains(ogretmen.verilendersler[i]))
                {
                    row.Cells[2].Value = "Evet";
                }
                else
                {
                    row.Cells[2].Value = "Hayır";
                }
                ogretmenVerilenDerslerGridView.Rows.Add(row);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ilgialanisil_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA BAĞLA
            int index = ilgiAlanlariListBox.SelectedIndex;
            if (index == -1) // Herhangi bir öğe seçilmiş mi kontrol et
            {
                // Seçili öğeyi sil
                MessageBox.Show("İlgi Alanı Seç", "İşlem Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ilgiAlanlariListBox.Items.RemoveAt(index);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilgialanieklebutton_Click(object sender, EventArgs e)
        {
            // VERİ TABANINA BAĞLA
            ilgiAlanlariListBox.Items.Add(ilgialaniekleTextBox.Text);
        }
    }
}
