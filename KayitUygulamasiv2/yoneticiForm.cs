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

        string[] turkceIsimler = {
            "Ahmet", "Mehmet", "Mustafa", "Ali", "Zeynep",
            "Sultan", "Osman", "Selim", "Nur", "Kemal",
            "Gizem", "Esra", "Tolga", "Can", "Aysel", "Berk",
            "Damla", "Efe", "Rabia", "Cem", "Melike", "Onur", "Elif", "Murat",
            "Umut", "Dilara", "Burak", "Ezgi", "Serkan", "Selin", "Oktay",
            "Sude", "Sema", "Kaan", "Arda", "Buse", "Kadir"
        };

        string[] turkceSoyadlari = {
            "Kaya", "Demir","Tekin","Acar", "Aksu", "Kurt","Toprak", "Turan", "Aydos", "Erdem", "Arslan","Kara","Eren", "Kaplan","Yavuz", "Kartal"
        };
        public yoneticiForm(Yonetici yonetici)
        {
            InitializeComponent();
            this.yonetici = yonetici;
            for (int i = 0; i < Program.ilgialanlari.Count; i++)
            {
                ilgiAlanlariListBox.Items.Add(Program.ilgialanlari[i].ilgialaniadi);
            }
            
        }

        public static int[] RastgeleFarkliIndisler(List<İlgiAlani> dizi, int adet)
        {
            if (adet > dizi.Count || adet < 1)
            {
                throw new ArgumentException("Geçersiz indis sayısı");
            }

            Random random = new Random();
            int[] rastgeleIndisler = new int[adet];

            for (int i = 0; i < adet; i++)
            {
                int rastgeleIndis;
                do
                {
                    rastgeleIndis = random.Next(0, dizi.Count);
                } while (rastgeleIndisler.Contains(rastgeleIndis));

                rastgeleIndisler[i] = rastgeleIndis;
            }

            return rastgeleIndisler;
        }

        public static String HarfNotuOlustur(int sayisalnot)
        {
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
            return harfnot;
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

        private void rastgeleogrenciekleButton_Click(object sender, EventArgs e)
        {
            if (int.Parse(rastgeleogrencisayisiTextBox.Text) > 0 && int.Parse(rastgeleogrencisayisiTextBox.Text)<50)
            {
                for(int tekrarsayisi= 0;tekrarsayisi< int.Parse(rastgeleogrencisayisiTextBox.Text); tekrarsayisi++)
                {
                    int verilecek_ID = 0;
                    while (true)
                    {
                        Boolean idvarmi = false;
                        for (int i = 0; i < Program.ogrenciler.Count; i++)
                        {
                            if (Program.ogrenciler[i].ID == verilecek_ID)
                            {
                                idvarmi = true;
                                break;
                            }
                        }
                        if (idvarmi)
                        {
                            verilecek_ID++;
                        }
                        else
                        {
                           //ÖĞRENCİ OLUŞTURMA İŞİ BURADA YAPILACAK
                           Ogrenci ogrenci = new Ogrenci();
                            ogrenci.ID = verilecek_ID;
                            ogrenci.isim = turkceIsimler[Program.random.Next(turkceIsimler.Length)];
                            ogrenci.soyisim= turkceSoyadlari[Program.random.Next(turkceSoyadlari.Length)];
                            ogrenci.sifre = ogrenci.isim.ToLower()+ogrenci.soyisim.ToLower()+ogrenci.ID;
                            ogrenci.AGNO =Math.Round(1.0 + (Program.random.NextDouble() * (4.0 - 1.0)), 2);
                            ogrenci.talepsayisi = 0;
                            int rastgelediziboyutu=Program.random.Next(1,Program.ilgialanlari.Count);
                            int[] rastgeleindisdizisi = RastgeleFarkliIndisler(Program.ilgialanlari, rastgelediziboyutu);
                            for(int i = 0; i < rastgeleindisdizisi.Length; i++)
                            {
                                ogrenci.ilgialanlari.Add(Program.ilgialanlari[rastgeleindisdizisi[i]].ilgialaniadi);
                            }
                            for(int i = 0; i < 3; i++)
                            {
                                DersNotlari eklenebilecekDersNotlari = new DersNotlari();
                                if (ogrenci.alinandersler.Count > 0)
                                {
                                    while (true) {
                                        Ders eklenebilecekders = Program.dersler[Program.random.Next(Program.dersler.Count)];
                                        Boolean derseklenebilirmi = true;
                                        for (int j = 0; j < ogrenci.alinandersler.Count; j++)
                                        {
                                            if (ogrenci.alinandersler[j].dersID.Equals(eklenebilecekders.dersID))
                                            {
                                                derseklenebilirmi= false;
                                            }
                                        }
                                        if (derseklenebilirmi)
                                        {
                                            eklenebilecekDersNotlari.dersID = eklenebilecekders.dersID;
                                            eklenebilecekDersNotlari.dersadi = eklenebilecekders.dersadi;
                                            eklenebilecekDersNotlari.dersiverenhocaID = eklenebilecekders.dersiverenhocaID;
                                            eklenebilecekDersNotlari.sayisalnot = Program.random.Next(101);
                                            eklenebilecekDersNotlari.harfnotu = HarfNotuOlustur(eklenebilecekDersNotlari.sayisalnot);
                                            ogrenci.alinandersler.Add(eklenebilecekDersNotlari);
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Ders eklenebilecekders = Program.dersler[Program.random.Next(Program.dersler.Count)];
                                    eklenebilecekDersNotlari.dersID = eklenebilecekders.dersID;
                                    eklenebilecekDersNotlari.dersadi = eklenebilecekders.dersadi;
                                    eklenebilecekDersNotlari.dersiverenhocaID = eklenebilecekders.dersiverenhocaID;
                                    eklenebilecekDersNotlari.sayisalnot = Program.random.Next(101);
                                    eklenebilecekDersNotlari.harfnotu = HarfNotuOlustur(eklenebilecekDersNotlari.sayisalnot);
                                    ogrenci.alinandersler.Add(eklenebilecekDersNotlari);
                                }
                            }

                            Console.WriteLine("RASTGELE OLUŞTURULAN OGRENCİ ->" + (tekrarsayisi + 1));
                            Console.WriteLine(ogrenci.ToString());
                            /*Console.WriteLine("RASTGELE ILGIALANLARI:");
                            for(int i=0; i < ogrenci.ilgialanlari.Count; i++)
                            {
                                Console.WriteLine(ogrenci.ilgialanlari[i]);
                            }
                            Console.WriteLine("RASTGELE ALINAN DERSLER:");
                            for (int i = 0; i < ogrenci.alinandersler.Count; i++)
                            {
                                Console.WriteLine(ogrenci.alinandersler[i].ToString());
                            }
                            Console.WriteLine();*/
                            //Program.baglanti.Close();
                            //Program.baglanti.Open();
                            NpgsqlCommand ogrencitabloeklemekomut = new NpgsqlCommand("INSERT INTO ogrenci (ogrenci_id,ogrenci_isim,ogrenci_soyisim,ogrenci_parola,agno,talepsayisi) VALUES(" + ogrenci.ID + ",'" + ogrenci.isim + "','" + ogrenci.soyisim + "','" + ogrenci.sifre + "'," + ogrenci.AGNO.ToString().Replace(',','.') + "," + ogrenci.talepsayisi + ");", Program.baglanti);
                            ogrencitabloeklemekomut.ExecuteNonQuery();
                            Console.WriteLine("Ilgi Alanlari:");
                            for (int i = 0; i < ogrenci.ilgialanlari.Count; i++)
                            {
                                for (int j = 0; j < Program.ilgialanlari.Count; j++)
                                {
                                    if (ogrenci.ilgialanlari[i].Equals(Program.ilgialanlari[j].ilgialaniadi))
                                    {
                                        NpgsqlCommand ilgialanlaribaglakomut = new NpgsqlCommand("INSERT INTO ogrenci_ilgialani (ogrenci_id,ilgialani_id) VALUES (" + ogrenci.ID + "," + Program.ilgialanlari[j].ID + ");", Program.baglanti);
                                        Console.WriteLine(ogrenci.ilgialanlari[i]);
                                        ilgialanlaribaglakomut.ExecuteNonQuery();
                                        break;
                                    }
                                }
                            }
                            Console.WriteLine("Alinan Dersler:");
                            for (int i = 0; i < ogrenci.alinandersler.Count; i++)
                            {
                                NpgsqlCommand ogrencialinanderslerkomut = new NpgsqlCommand("INSERT INTO alinandersler (ogrenci_id,ders_id,sayisalnot,harfnot,dersiverenhoca_id) VALUES(" + ogrenci.ID + ",'" + ogrenci.alinandersler[i].dersID + "'," + ogrenci.alinandersler[i].sayisalnot + ",'" + ogrenci.alinandersler[i].harfnotu + "'," + ogrenci.alinandersler[i].dersiverenhocaID + ");", Program.baglanti);
                                Console.WriteLine(ogrenci.alinandersler[i].ToString());
                                ogrencialinanderslerkomut.ExecuteNonQuery();
                            }
                            //Program.baglanti.Close();
                            Program.ogrenciler.Add(ogrenci);
                            
                            break;
                        }

                    }

                }
            }
            else
            {
                MessageBox.Show("0-50 arasında bir değer giriniz (0 ve 50 dahil değil)", "Hatalı Değer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void yeniogretmenkaydetButton_Click(object sender, EventArgs e)
        {
            Boolean ogretmenIDtekmi=true;
            for(int i=0;i<Program.ogretmenler.Count;i++) 
            {
                if (int.Parse(ogretmen_IDtextBox.Text) == Program.ogretmenler[i].ID)
                {
                    ogretmenIDtekmi = false;
                    break;
                }
            }
            if (ogretmenIDtekmi)
            {
                Ogretmen ogretmen = new Ogretmen();
                ogretmen.ID = int.Parse(ogretmen_IDtextBox.Text);
                ogretmen.isim = ogretmen_isimTextBox.Text;
                ogretmen.soyisim=ogretmen_soyisimTextBox.Text;
                ogretmen.sifre=ogretmen_sifreTextBox.Text;
                ogretmen.sicilno=int.Parse(ogretmen_sicilnoTextBox.Text);
                ogretmen.kontenjan = int.Parse(ogretmen_kontenjanTextBox.Text);
                String[] ogretmenilgialanlariArray = ilgialanlariTextBox.Text.Split('\n');

                for(int i = 0; i < ogretmenilgialanlariArray.Length; i++)
                {
                    for(int j = 0; j < Program.ilgialanlari.Count; j++)
                    {
                        if (Program.ilgialanlari[j].ilgialaniadi == ogretmenilgialanlariArray[i].Trim())
                        {
                            ogretmen.ilgialanlari.Add(Program.ilgialanlari[j].ilgialaniadi);
                            break;
                        }
                    }
                    
                }
                String[] kritikderslerbilgileri = kritikderslerTextBox.Text.Split('\n');
                String[] verilenderslerbilgileri = verilenderslerTextBox.Text.Split('\n');
                for (int i = 0; i < verilenderslerbilgileri.Length; i++)
                {
                    Ders ders = new Ders();
                    
                    for(int j = 0; j < Program.dersler.Count; j++)
                    {
                        if (Program.dersler[j].dersID == verilenderslerbilgileri[i].Trim())
                        {
                            ders.dersID = verilenderslerbilgileri[i].Trim();
                            ders.dersadi = Program.dersler[j].dersadi;
                            ders.dersiverenhocaID = ogretmen.ID;
                            Console.WriteLine("EKLENİLEN DERS :" + ders.ToString());
                            ogretmen.verilendersler.Add(ders);
                            if (kritikderslerbilgileri.Contains(ders.dersID))
                            {
                                ogretmen.kritikdersler.Add(ders);
                            }
                            break;
                        }
                    }
                }

                Console.WriteLine("OGRETMEN EKLEME =>"+ogretmen.ToString()+"\nVerilen Dersler");
                for(int i=0;i<ogretmen.verilendersler.Count;i++) {
                    Console.WriteLine(ogretmen.verilendersler[i].ToString());
                }
                Console.WriteLine("Kritik Dersler");
                for (int i = 0; i < ogretmen.kritikdersler.Count; i++)
                {
                    Console.WriteLine(ogretmen.kritikdersler[i].ToString());
                }
                Console.WriteLine("İLGİ ALANLARİ");
                for(int i=0;i<ogretmen.ilgialanlari.Count;i++)
                {
                    Console.WriteLine(ogretmen.ilgialanlari[i]);
                }

                NpgsqlCommand ogretmenkomut = new NpgsqlCommand("INSERT INTO ogretmen (ogretmen_id,sicilno,ogretmen_isim,ogretmen_soyisim,ogretmen_parola,kontenjan) VALUES (" + ogretmen.ID + "," + ogretmen.sicilno + ",'" + ogretmen.isim + "','" + ogretmen.soyisim + "','" + ogretmen.sifre + "'," + ogretmen.kontenjan + ");", Program.baglanti);
                ogretmenkomut.ExecuteNonQuery();
                
                for (int i = 0; i < ogretmen.ilgialanlari.Count; i++)
                {
                    for (int j = 0; j < Program.ilgialanlari.Count; j++)
                    {
                        if (Program.ilgialanlari[j].ilgialaniadi == ogretmen.ilgialanlari[i])
                        {
                            NpgsqlCommand ogretmenilgialanlarikomut = new NpgsqlCommand("INSERT INTO ogretmen_ilgialani (ogretmen_id,ilgialani_id) VALUES (" + ogretmen.ID + "," + Program.ilgialanlari[j].ID +");", Program.baglanti);
                            ogretmenilgialanlarikomut.ExecuteNonQuery() ;
                            break;
                        }
                    }

                }
                for(int i=0;i< ogretmen.verilendersler.Count; i++)
                {
                    NpgsqlCommand verilenderslerkomut = new NpgsqlCommand("INSERT INTO dersler (ogretmen_id,ders_id) VALUES (" + ogretmen.ID + ",'" + ogretmen.verilendersler[i].dersID +"');", Program.baglanti);
                    verilenderslerkomut.ExecuteNonQuery() ;
                }
                for (int i = 0; i < ogretmen.kritikdersler.Count; i++)
                {
                    NpgsqlCommand kritikderslerkomut = new NpgsqlCommand("INSERT INTO ogretmen_kritikdersler (ogretmen_id,ders_id) VALUES (" + ogretmen.ID + ",'" + ogretmen.kritikdersler[i].dersID + "');", Program.baglanti);
                    kritikderslerkomut.ExecuteNonQuery();
                }


                Program.ogretmenler.Add(ogretmen);
            }
            
        }
    }
}
