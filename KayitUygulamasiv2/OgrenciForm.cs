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

            ogrencitalepgondermedataGridView.ColumnCount = 6;
            ogrencitalepgondermedataGridView.Columns[0].Name = "Öğretmen ID";
            ogrencitalepgondermedataGridView.Columns[1].Name = "İsim";
            ogrencitalepgondermedataGridView.Columns[2].Name = "Soy İsim";
            ogrencitalepgondermedataGridView.Columns[3].Name = "Kontenjan";
            ogrencitalepgondermedataGridView.Columns[4].Name = "Ders ID";
            ogrencitalepgondermedataGridView.Columns[5].Name = "Ders Adı";
        }

        private void OgrenciİsimSoyisimLabel_Click(object sender, EventArgs e)
        {

        }

        private void OgrenciForm_Load(object sender, EventArgs e)
        {
            ogrenciDersdataGridView.Rows.Clear();
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

            for(int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (Program.ogretmenler[i].kontenjan > 0) // öğretmenin kontenjanı varsa
                {
                    for(int j = 0; j < Program.ogretmenler[i].verilendersler.Count; j++) // her öğretmenin verdiği dersler
                    {
                        Boolean bu_dersi_daha_once_almis_mi = false;
                        for(int k = 0; k < ogrenci.alinandersler.Count; k++)
                        {
                            if (ogrenci.alinandersler[k].dersID.Equals(Program.ogretmenler[i].verilendersler[j].dersID))
                            {
                                bu_dersi_daha_once_almis_mi= true;
                                break;
                            }
                        }
                        if (!bu_dersi_daha_once_almis_mi) // i öğretmeninin j dersini daha önce almamışsa
                        {
                           
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(ogrencitalepgondermedataGridView);
                            row.Cells[0].Value = Program.ogretmenler[i].ID;
                            row.Cells[1].Value = Program.ogretmenler[i].isim;
                            row.Cells[2].Value = Program.ogretmenler[i].soyisim;
                            row.Cells[3].Value = Program.ogretmenler[i].kontenjan;
                            row.Cells[4].Value = Program.ogretmenler[i].verilendersler[j].dersID;
                            row.Cells[5].Value = Program.ogretmenler[i].verilendersler[j].dersadi;
                            ogrencitalepgondermedataGridView.Rows.Add(row);
                        }
                    }
                }
            }

        }

        private void talepgondertabloyenilebutton_Click(object sender, EventArgs e)
        {
            ogrenciDersdataGridView.Rows.Clear();
            for (int i = 0; i < ogrenci.alinandersler.Count; i++)
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
            ogrencitalepgondermedataGridView.Rows.Clear();
            for (int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (Program.ogretmenler[i].kontenjan > 0) // öğretmenin kontenjanı varsa
                {
                    for (int j = 0; j < Program.ogretmenler[i].verilendersler.Count; j++) // her öğretmenin verdiği dersler
                    {
                        Boolean bu_dersi_daha_once_almis_mi = false;
                        for (int k = 0; k < ogrenci.alinandersler.Count; k++)
                        {
                            if (ogrenci.alinandersler[k].dersID.Equals(Program.ogretmenler[i].verilendersler[j].dersID))
                            {
                                bu_dersi_daha_once_almis_mi = true;
                                break;
                            }
                        }
                        if (!bu_dersi_daha_once_almis_mi) // i öğretmeninin j dersini daha önce almamışsa
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.CreateCells(ogrencitalepgondermedataGridView);
                            row.Cells[0].Value = Program.ogretmenler[i].ID;
                            row.Cells[1].Value = Program.ogretmenler[i].isim;
                            row.Cells[2].Value = Program.ogretmenler[i].soyisim;
                            row.Cells[3].Value = Program.ogretmenler[i].kontenjan;
                            row.Cells[4].Value = Program.ogretmenler[i].verilendersler[j].dersID;
                            row.Cells[5].Value = Program.ogretmenler[i].verilendersler[j].dersadi;
                            ogrencitalepgondermedataGridView.Rows.Add(row);
                        }
                    }
                }
            }
        }

        private void ilgialanifiltreButton_Click(object sender, EventArgs e)
        {
            ogrencitalepgondermedataGridView.Rows.Clear();
            for (int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (Program.ogretmenler[i].kontenjan > 0) // öğretmenin kontenjanı varsa
                {
                    for (int j = 0; j < Program.ogretmenler[i].verilendersler.Count; j++) // her öğretmenin verdiği dersler
                    {
                        Boolean bu_dersi_daha_once_almis_mi = false;
                        for (int k = 0; k < ogrenci.alinandersler.Count; k++)
                        {
                            if (ogrenci.alinandersler[k].dersID.Equals(Program.ogretmenler[i].verilendersler[j].dersID))
                            {
                                bu_dersi_daha_once_almis_mi = true;
                                break;
                            }
                        }
                        if (!bu_dersi_daha_once_almis_mi) // i öğretmeninin j dersini daha önce almamışsa
                        {
                            if (Program.ogretmenler[i].ilgialanlari.Contains(filtreBox.Text))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(ogrencitalepgondermedataGridView);
                                row.Cells[0].Value = Program.ogretmenler[i].ID;
                                row.Cells[1].Value = Program.ogretmenler[i].isim;
                                row.Cells[2].Value = Program.ogretmenler[i].soyisim;
                                row.Cells[3].Value = Program.ogretmenler[i].kontenjan;
                                row.Cells[4].Value = Program.ogretmenler[i].verilendersler[j].dersID;
                                row.Cells[5].Value = Program.ogretmenler[i].verilendersler[j].dersadi;
                                ogrencitalepgondermedataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
            }
        }

        private void dersadifltreButton_Click(object sender, EventArgs e)
        {
            ogrencitalepgondermedataGridView.Rows.Clear();
            for (int i = 0; i < Program.ogretmenler.Count; i++)
            {
                if (Program.ogretmenler[i].kontenjan > 0) // öğretmenin kontenjanı varsa
                {
                    for (int j = 0; j < Program.ogretmenler[i].verilendersler.Count; j++) // her öğretmenin verdiği dersler
                    {
                        Boolean bu_dersi_daha_once_almis_mi = false;
                        for (int k = 0; k < ogrenci.alinandersler.Count; k++)
                        {
                            if (ogrenci.alinandersler[k].dersID.Equals(Program.ogretmenler[i].verilendersler[j].dersID))
                            {
                                bu_dersi_daha_once_almis_mi = true;
                                break;
                            }
                        }
                        if (!bu_dersi_daha_once_almis_mi) // i öğretmeninin j dersini daha önce almamışsa
                        {
                            if (Program.ogretmenler[i].verilendersler[j].dersadi.Equals(filtreBox.Text) || Program.ogretmenler[i].verilendersler[j].dersID.Equals(filtreBox.Text))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(ogrencitalepgondermedataGridView);
                                row.Cells[0].Value = Program.ogretmenler[i].ID;
                                row.Cells[1].Value = Program.ogretmenler[i].isim;
                                row.Cells[2].Value = Program.ogretmenler[i].soyisim;
                                row.Cells[3].Value = Program.ogretmenler[i].kontenjan;
                                row.Cells[4].Value = Program.ogretmenler[i].verilendersler[j].dersID;
                                row.Cells[5].Value = Program.ogretmenler[i].verilendersler[j].dersadi;
                                ogrencitalepgondermedataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
            }
        }

        private void talepgonderButton_Click(object sender, EventArgs e)
        {
            // SelectionChanged olayı gerçekleştiğinde çalışan kod

            // Seçilen satırın indeksini al
            int selectedRowIndex = ogrencitalepgondermedataGridView.SelectedCells[0].RowIndex;

            // Seçilen satırın değerlerini al
            DataGridViewRow selectedRow = ogrencitalepgondermedataGridView.Rows[selectedRowIndex];

            // Örnek olarak satırdaki hücrelerden birini al
            string Secili_DersID = selectedRow.Cells["Ders ID"].Value.ToString();
            int Secili_OgretmenID = int.Parse(selectedRow.Cells["Öğretmen ID"].Value.ToString());
            Console.WriteLine("Secili Ders ID :" + Secili_DersID + " Secili Ogretmen ID :" + Secili_OgretmenID);
            
            int verilecekTalepID = 0;
            if (Program.talepler.Count > 0)
            {
                
                while(true)
                {
                    Boolean idverildimi = true;
                    for(int i=0;i<Program.talepler.Count;i++) 
                    {
                        if (verilecekTalepID == Program.talepler[i].TalepID)
                        {
                            verilecekTalepID++;
                            idverildimi=false;
                            break;
                        }
                    }
                    if(idverildimi)
                    {
                        Console.WriteLine("Verilecek Talep ID:" + verilecekTalepID);
                        break;
                    }
                    //verilecekTalepID++;
                }
            }
            Boolean taleplerdeikilemevarmi=false;
            for(int i=0;i<Program.talepler.Count; i++)
            {
                if (Program.talepler[i].ders.dersID.Equals(Secili_DersID) && Program.talepler[i].ogretmen.ID == Secili_OgretmenID)
                {
                    taleplerdeikilemevarmi = true;
                    break;
                }
            }
            if (!taleplerdeikilemevarmi) // Talebi Talep listesine ekle
            {
                Talep talep = new Talep();

                talep.ogrenci = ogrenci;
                for(int i=0;i<Program.ogretmenler.Count;i++)
                {
                    if (Program.ogretmenler[i].ID == Secili_OgretmenID)
                    {
                        talep.ogretmen= Program.ogretmenler[i];
                        break;
                    }
                }
                for (int i = 0; i < Program.dersler.Count; i++)
                {
                    if (Program.dersler[i].dersID == Secili_DersID)
                    {
                        talep.ders = Program.dersler[i];
                        break;
                    }
                }
                talep.durum = "bekliyor";
                talep.TalepID = verilecekTalepID;
                NpgsqlCommand talepeklemekomut = new NpgsqlCommand("INSERT INTO talep (talep_id,ders_id,ogretmen_id,ogrenci_id,durum) VALUES ("+talep.TalepID+",'"+talep.ders.dersID+"',"+talep.ogretmen.ID+","+talep.ogrenci.ID+",'bekliyor');", Program.baglanti);
                talepeklemekomut.ExecuteNonQuery();
                Program.talepler.Add( talep );
                ogrenci.setTalepsayisi(ogrenci.talepsayisi + 1);
                talepsayisiLabel.Text = "Talep Sayısı = " + ogrenci.talepsayisi;
            }
            

        }
    }
}
