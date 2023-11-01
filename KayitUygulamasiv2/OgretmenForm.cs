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
    public partial class OgretmenForm : Form
    {
        Ogretmen ogretmen;
        public OgretmenForm(Ogretmen ogretmen)
        {
            this.ogretmen = ogretmen;
            InitializeComponent();
            ogretmenVerilenDerslerGridView.ColumnCount = 2; // Kaç sütun olacağını belirleyin
            ogretmenVerilenDerslerGridView.Columns[0].Name = "Ders ID";
            ogretmenVerilenDerslerGridView.Columns[1].Name = "Ders Adı";

            dersalabilecekogrencilerGridView.ColumnCount = 5;
            dersalabilecekogrencilerGridView.Columns[0].Name = "İsim";
            dersalabilecekogrencilerGridView.Columns[1].Name = "Soy isim";
            dersalabilecekogrencilerGridView.Columns[2].Name = "ID";
            dersalabilecekogrencilerGridView.Columns[3].Name = "AGNO";
            dersalabilecekogrencilerGridView.Columns[4].Name = "Kritik Değer";



            OgretmenIDlabel.Text = "Öğretmen ID = " + ogretmen.ID;
            OgretmenİsimSoyisimLabel.Text = "Öğretmen isim - soy isim = " + ogretmen.isim + " " + ogretmen.soyisim;
            SicilNoLabel.Text = "Sicil No = " + ogretmen.sicilno;
            kontenjanLabel.Text = "Kontenjan = " + ogretmen.kontenjan;
        }

        public double kritikDegerHesaplama(Ogretmen gelenogretmen,Ogrenci gelenogrenci)
        {
            double kritikdeger=0;
            int tumnotlar = 0;
            for(int i= 0;i<gelenogretmen.kritikdersler.Count;i++)
            {
                for(int j = 0; j < gelenogrenci.alinandersler.Count; j++)
                {
                    if (gelenogrenci.alinandersler[j].dersID.Equals(gelenogretmen.kritikdersler[j].dersID)) // dersler eşleşti
                    {
                        kritikdeger = kritikdeger + gelenogrenci.alinandersler[j].sayisalnot;
                        break;
                    }
                }
            }
            return kritikdeger/gelenogretmen.kritikdersler.Count;
        }

        private void OgretmenForm_Load(object sender, EventArgs e)
        {
            //ilgiAlanlariListBox.DataSource = ogretmen.ilgialanlari;
            for (int i = 0; i < ogretmen.ilgialanlari.Count; i++)
            {
                ilgiAlanlariListBox.Items.Add(ogretmen.ilgialanlari[i]);
            }
            for (int i=0; i<ogretmen.kritikdersler.Count; i++)
            {
                kritikDerslerListBox.Items.Add(ogretmen.kritikdersler[i].dersadi);
            }
            for (int i = 0; i < ogretmen.verilendersler.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ogretmenVerilenDerslerGridView);
                row.Cells[0].Value = ogretmen.verilendersler[i].dersID;
                row.Cells[1].Value = ogretmen.verilendersler[i].dersadi;
                ogretmenVerilenDerslerGridView.Rows.Add(row);
            }
            for(int i = 0; i < Program.ogrenciler.Count; i++)
            {
                for(int j = 0; j < Program.ogrenciler[i].ilgialanlari.Count; j++) 
                {
                    //  if (ogretmen.ilgialanlari.Contains(Program.ogrenciler[i].ilgialanlari[j])){ //ilgi alanları eşleşti
                    //if (){
                        DataGridViewRow dataGridViewRow = new DataGridViewRow();
                        dataGridViewRow.CreateCells(dersalabilecekogrencilerGridView);
                        dataGridViewRow.Cells[0].Value = Program.ogrenciler[i].isim;
                        dataGridViewRow.Cells[1].Value= Program.ogrenciler[i].soyisim;
                        dataGridViewRow.Cells[2].Value= Program.ogrenciler[i].ID;
                        dataGridViewRow.Cells[3].Value= Program.ogrenciler[i].AGNO;
                        dataGridViewRow.Cells[4].Value = kritikDegerHesaplama(ogretmen, Program.ogrenciler[i]);
                        dersalabilecekogrencilerGridView.Rows.Add(dataGridViewRow);
                    //}
                }
            }

            Program.baglanti.Open();
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
               // Program.baglanti.Open();
                for (int i = 0; i < Program.ilgialanlari.Count; i++)
                {
                    if (ilgiAlanlariListBox.Items[index].Equals(Program.ilgialanlari[i].ilgialaniadi))
                    {
                        
                        NpgsqlCommand ilgialanisilkomut = new NpgsqlCommand("Delete from ogretmen_ilgialani where ogretmen_id=" + ogretmen.ID + " and ilgialani_id=" + Program.ilgialanlari[i].ID +";", Program.baglanti);
                        ilgialanisilkomut.ExecuteNonQuery();
                        ilgiAlanlariListBox.Items.RemoveAt(index);
                        ogretmen.ilgialanlari.Remove(Program.ilgialanlari[i].ilgialaniadi);
                        Console.WriteLine("OGRETMEN İLGİ ALANLARİ");
                        for(int j =0; j < ogretmen.ilgialanlari.Count; j++)
                        {
                            Console.WriteLine(ogretmen.ilgialanlari[j] + "\n");
                        }
                        break;
                    }
                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ilgialanieklebutton_Click(object sender, EventArgs e)
        {
            // VERİ TABANINA BAĞLA
            for(int i= 0;i<Program.ilgialanlari.Count;i++)
            {
                if (Program.ilgialanlari[i].ilgialaniadi.Equals(ilgialaniekleTextBox.Text)) {
                    ilgiAlanlariListBox.Items.Add(ilgialaniekleTextBox.Text);
                    ogretmen.ilgialanlari.Add(Program.ilgialanlari[i].ilgialaniadi);
                    
                    NpgsqlCommand ilgialanieklemekomutu = new NpgsqlCommand("INSERT INTO ogretmen_ilgialani (ogretmen_id, ilgialani_id) VALUES (" + ogretmen.ID + "," + Program.ilgialanlari[i].ID + ") ;", Program.baglanti);
                    ilgialanieklemekomutu.ExecuteNonQuery();
                    break;
                }
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void SicilNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sıralaButton_Click(object sender, EventArgs e)
        {
            dersalabilecekogrencilerGridView.Rows.Clear(); 
            for (int i = 0; i < Program.ogrenciler.Count; i++)
            {
                Boolean dersialmismi = false;
                for (int j = 0; j < Program.ogrenciler[i].alinandersler.Count; j++)
                {
                    if (Program.ogrenciler[i].alinandersler[j].dersID.Equals(dersfiltresiTextBox.Text) || Program.ogrenciler[i].alinandersler[j].dersadi.Equals(dersfiltresiTextBox.Text))
                    {
                        dersialmismi = true;
                        break;
                    }
                    //  if (ogretmen.ilgialanlari.Contains(Program.ogrenciler[i].ilgialanlari[j])){ //ilgi alanları eşleşti
                }
                if (!dersialmismi)
                {
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dersalabilecekogrencilerGridView);
                    dataGridViewRow.Cells[0].Value = Program.ogrenciler[i].isim;
                    dataGridViewRow.Cells[1].Value = Program.ogrenciler[i].soyisim;
                    dataGridViewRow.Cells[2].Value = Program.ogrenciler[i].ID;
                    dataGridViewRow.Cells[3].Value = Program.ogrenciler[i].AGNO;
                    dataGridViewRow.Cells[4].Value = kritikDegerHesaplama(ogretmen, Program.ogrenciler[i]);
                    dersalabilecekogrencilerGridView.Rows.Add(dataGridViewRow);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dersalabilecekogrencilerGridView.Rows.Clear();
            for (int i = 0; i < Program.ogrenciler.Count; i++)
            {
                for (int j = 0; j < Program.ogrenciler[i].ilgialanlari.Count; j++)
                {
                     if (ogretmen.ilgialanlari.Contains(Program.ogrenciler[i].ilgialanlari[j])){ //ilgi alanları eşleşti
                    // if({
                    DataGridViewRow dataGridViewRow = new DataGridViewRow();
                    dataGridViewRow.CreateCells(dersalabilecekogrencilerGridView);
                    dataGridViewRow.Cells[0].Value = Program.ogrenciler[i].isim;
                    dataGridViewRow.Cells[1].Value = Program.ogrenciler[i].soyisim;
                    dataGridViewRow.Cells[2].Value = Program.ogrenciler[i].ID;
                    dataGridViewRow.Cells[3].Value = Program.ogrenciler[i].AGNO;
                    dataGridViewRow.Cells[4].Value = kritikDegerHesaplama(ogretmen, Program.ogrenciler[i]);
                    dersalabilecekogrencilerGridView.Rows.Add(dataGridViewRow);
                        break;
                    }
                }
            }
        }

        private void kritikderseklebutton_Click(object sender, EventArgs e)
        {
            // VERİ TABANINA BAĞLA
            for (int i = 0; i < ogretmen.verilendersler.Count; i++)
            {
                if (ogretmen.verilendersler[i].dersID.Equals(kritikdersekleTextBox.Text) || ogretmen.verilendersler[i].dersadi.Equals(kritikdersekleTextBox.Text))
                {
                    kritikDerslerListBox.Items.Add(ogretmen.verilendersler[i].dersadi);
                    ogretmen.kritikdersler.Add(ogretmen.verilendersler[i]);

                    NpgsqlCommand kritikderseklemekomutu = new NpgsqlCommand("INSERT INTO ogretmen_kritikdersler (ogretmen_id, ders_id) VALUES (" + ogretmen.ID + ",'" + ogretmen.verilendersler[i].dersID + "') ;", Program.baglanti);
                    kritikderseklemekomutu.ExecuteNonQuery();
                    break;
                }
            }
        }

        private void kritikderssilbutton_Click(object sender, EventArgs e)
        {
            //VERİ TABANINA BAĞLA
            int index = kritikDerslerListBox.SelectedIndex;
            if (index == -1) // Herhangi bir öğe seçilmiş mi kontrol et
            {
                // Seçili öğeyi sil
                MessageBox.Show("Kritik Ders Seç", "İşlem Hatalı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Program.baglanti.Open();
                for (int i = 0; i < ogretmen.kritikdersler.Count; i++)
                {
                    if (kritikDerslerListBox.Items[index].Equals(ogretmen.kritikdersler[i].dersadi))
                    {

                        NpgsqlCommand kritikderssilkomut = new NpgsqlCommand("Delete from ogretmen_kritikdersler where ogretmen_id=" + ogretmen.ID + " and ders_id= '" + ogretmen.kritikdersler[i].dersID + "';", Program.baglanti);
                        kritikderssilkomut.ExecuteNonQuery();
                        kritikDerslerListBox.Items.RemoveAt(index);
                        ogretmen.kritikdersler.Remove(ogretmen.kritikdersler[i]);
                        Console.WriteLine("OGRETMEN KRİTİK DERSLER");
                        for (int j = 0; j < ogretmen.kritikdersler.Count; j++)
                        {
                            Console.WriteLine(ogretmen.kritikdersler[j].ToString());
                        }
                        break;
                    }
                }

            }
        }
    }
}
