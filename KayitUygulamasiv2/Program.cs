using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KayitUygulamasiv2
{
    public class Ogrenci
    {
       public String isim;
       public String soyisim;
       public int ID;
       public String sifre;
       public List<DersNotlari> alinandersler = new List<DersNotlari>();
       public List<String> ilgialanlari = new List<string>();
       public double AGNO;
        public int talepsayisi;
        
        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int ıD, string sifre, double aGNO, int talepsayisi)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            ID = ıD;
            this.sifre = sifre;
            AGNO = aGNO;
            this.talepsayisi = talepsayisi;
        }

        public override string ToString()
        {
            return $"ID: {ID}, İsim: {isim}, Soyisim: {soyisim}, Şifre: {sifre}, AGNO: {AGNO}, Talep Sayısı: {talepsayisi}";
        }
       
        public void setTalepsayisi(int talepsayisi_yeni)
        {
            this.talepsayisi=talepsayisi_yeni;
            Program.baglanti.Open();
            NpgsqlCommand talepsayisi_update = new NpgsqlCommand("UPDATE public.ogrenci SET talepsayisi = " + talepsayisi + " WHERE ogrenci_id = " + ID + ";", Program.baglanti);
            talepsayisi_update.ExecuteNonQuery();
        }

    }

    public class Ogretmen
    {
       public String isim;
       public String soyisim;
       public int ID;
       public String sifre;
       public List<Ders> verilendersler = new List<Ders>();
       public List<Ders> kritikdersler= new List<Ders>();
       public List<String> ilgialanlari= new List<string>();
       public int sicilno;
       public int kontenjan;
        public Ogretmen() { }
        public Ogretmen(string isim, string soyisim, int ıD, string sifre, int sicilno, int kontenjan)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            ID = ıD;
            this.sifre = sifre;
            this.sicilno = sicilno;
            this.kontenjan = kontenjan;
        }

        public override string ToString()
        {
            return $"ID: {ID}, İsim: {isim}, Soyisim: {soyisim}, Şifre: {sifre}, Sicil No: {sicilno}, Kontenjan: {kontenjan}";
        }

        public void setKontenjan(int kontenjan_yeni)
        {
            this.kontenjan = kontenjan_yeni;
            Program.baglanti.Open();
            NpgsqlCommand talepsayisi_update = new NpgsqlCommand("UPDATE public.ogretmen SET kontenjan = "+kontenjan+" WHERE ogretmen_id = "+ID+"; ", Program.baglanti);
            talepsayisi_update.ExecuteNonQuery();
        }
    }

    public class Ders
    {
        public String dersID;
        public String dersadi;
        public int dersiverenhocaID;
        public Ders() { }
        public Ders(string dersID, string dersadi, int dersiverenhocaID)
        {
            this.dersID = dersID;
            this.dersadi = dersadi;
            this.dersiverenhocaID = dersiverenhocaID;
        }

        public override string ToString()
        {
            return $"dersID: {dersID}, dersadi: {dersadi}, dersiverenhoca: {dersiverenhocaID}";
        }
    }

    public class DersNotlari : Ders
    {
       public int sayisalnot;
       public String harfnotu;

        public DersNotlari() { }   

        public DersNotlari(string dersID, string dersadi, int dersiverenhocaID,int sayisalnot, string harfnotu):base(dersID, dersadi ,dersiverenhocaID)
        {
            this.dersID = dersID;
            this.dersadi = dersadi;
            this.dersiverenhocaID = dersiverenhocaID;
            this.sayisalnot = sayisalnot;
            this.harfnotu = harfnotu;
        }

        public override string ToString()
        {
            return $"dersID: {dersID}, dersadi: {dersadi}, dersiverenhoca: {dersiverenhocaID}, sayisalnot: {sayisalnot}, harfnotu: {harfnotu}";
        }
    }

    public class Talep
    {
        public Ogrenci ogrenci;
        public Ogretmen ogretmen;
        public Ders ders;
        public String durum;
        public int TalepID;

        public Talep() { }

        public Talep(Ogrenci ogrenci, Ogretmen ogretmen, Ders ders, string durum, int talepID)
        {
            this.ogrenci = ogrenci;
            this.ogretmen = ogretmen;
            this.ders = ders;
            this.durum = durum;
            TalepID = talepID;
        }

        public override string ToString()
        {
            return $"Ogrenci: {ogrenci.isim} {ogrenci.soyisim}, Ogretmen: {ogretmen.isim} {ogretmen.soyisim}, Ders: {ders.dersID} {ders.dersadi}, Durum: {durum}, TalepID: {TalepID}";
        }
    }

    public class Yonetici
    {
        public int ID;
        public String isim;
        public String soyisim;
        public String Parola;
        public Yonetici() { }

        public override string ToString()
        {
            return $"ID: {ID}, İsim: {isim}, Soyisim: {soyisim}, Parola: {Parola}";
        }

    }

    public class İlgiAlani
    {
        public int ID;
        public String ilgialaniadi;
        public İlgiAlani() { }
        public İlgiAlani(int ID, String ilgialaniadi)
        {
            this.ID = ID ;
            this.ilgialaniadi= ilgialaniadi ;
        }
    }
    

    internal static class Program
    {
        public static NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost;port=5432; Database=postgres; user ID=postgres; password=furkan254");
        public static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        public static List<Ogretmen> ogretmenler = new List<Ogretmen>();
        public static List<Ders> dersler = new List<Ders>();
        public static List<Talep> talepler = new List<Talep>();
        public static Yonetici yonetici = new Yonetici();
        public static List<İlgiAlani> ilgialanlari = new List<İlgiAlani> ();
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // ÖĞRENCİ BAĞLANTISI ---------------------------------------------
            
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("select * from ogrenci", baglanti);
            DataSet ds_ogrenci = new DataSet();
            da.Fill(ds_ogrenci);
           
            foreach (DataRow row in ds_ogrenci.Tables[0].Rows)
                {
                //Console.WriteLine($"ID: {row["ogrenciID"]}, Name: {row["ogrenci_isim"]}");
                Ogrenci ogrenci = new Ogrenci();
                ogrenci.isim = (string)row["ogrenci_isim"];
                ogrenci.soyisim = (string)row["ogrenci_soyisim"];
                ogrenci.ID = (int)row["ogrenci_id"];
                ogrenci.sifre = (string)row["ogrenci_parola"];
                ogrenci.AGNO = (double)row["agno"];
                ogrenci.talepsayisi = (int)row["talepsayisi"];
                Console.WriteLine(ogrenci.ToString());
                ogrenciler.Add(ogrenci);
                //string isim, string soyisim, int ıD, string sifre, double aGNO, int talepsayisi
                //ogrenciler.Add(new Ogrenci((row["ogrenci_isim"]).ToString, row["ogrenci_soyisim"], row["ogrenciID"], row["ogrenci_parola"], row["agno"], row["talepsayisi"])); 
            }
            Console.WriteLine("\n\n");

            // ÖĞRETMEN BAĞLANTISI ---------------------------------------------

            da = new NpgsqlDataAdapter("select * from ogretmen", baglanti);
            DataSet ds_ogretmen = new DataSet();
            da.Fill(ds_ogretmen);
            
            foreach (DataRow row in ds_ogretmen.Tables[0].Rows)
            {
                Ogretmen ogretmen = new Ogretmen();
                ogretmen.isim = (string)row["ogretmen_isim"];
                ogretmen.soyisim = (string)row["ogretmen_soyisim"];
                ogretmen.ID = (int)row["ogretmen_id"];
                ogretmen.sifre = (string)row["ogretmen_parola"];
                ogretmen.sicilno = (int)row["sicilno"];
                ogretmen.kontenjan =(int) row["kontenjan"];
                Console.WriteLine(ogretmen.ToString());
                ogretmenler.Add(ogretmen);
            }

            // DERSLER BAĞLANTISI ---------------------------------------------

            da = new NpgsqlDataAdapter("select dersler.ders_id , dersler.ogretmen_id , derslerinisimleri.ders_isim from dersler , derslerinisimleri where dersler.ders_id=derslerinisimleri.ders_id", baglanti);
            DataSet ds_ders = new DataSet();
            da.Fill(ds_ders);
            
            foreach (DataRow row in ds_ders.Tables[0].Rows)
            {
                Ders ders = new Ders();
                ders.dersID = (String)row["ders_id"];
                ders.dersadi=(String)row["ders_isim"];
                ders.dersiverenhocaID=(int)row["ogretmen_id"];
                Console.WriteLine(ders.ToString());
                for(int i = 0; i < ogretmenler.Count; i++) // dersi veren hocayı ara
                {
                    if (ogretmenler[i].ID == ders.dersiverenhocaID) // hocayı bulduk
                    {
                        ogretmenler[i].verilendersler.Add(ders);
                        break;
                    }
                }
                dersler.Add(ders);
            }

            // YONETİCİ BAĞLANTISI ----------------------------------------------------------------

            da = new NpgsqlDataAdapter("select * from yonetici", baglanti);
            DataSet ds_yonetici = new DataSet();
            da.Fill(ds_yonetici);

            foreach (DataRow row in ds_yonetici.Tables[0].Rows)
            {
                yonetici.ID = (int)row["yonetici_id"];
                yonetici.isim = (String)row["yonetici_isim"];
                yonetici.soyisim = (String)row["yonetici_soyisim"];
                yonetici.Parola = (String)row["yonetici_parola"];
            }

            Console.WriteLine(yonetici.ToString());

            // NOTLU DERSLERİN BAĞLANTISI ----------------------------------------------------------

            da = new NpgsqlDataAdapter("select *from alinandersler", baglanti);
            DataSet ds_alinandersler = new DataSet();
            da.Fill(ds_alinandersler);
            foreach(DataRow row in ds_alinandersler.Tables[0].Rows)
            {
                for(int i = 0; i < ogrenciler.Count; i++) // tüm öğrencilere bak
                {
                    if (ogrenciler[i].ID == (int)row["ogrenci_id"]) // öğrenciyi bulduk "i"
                    {
                        Console.WriteLine("BULUNAN OGRENCİ :" + ogrenciler[i].isim+ " " + ogrenciler[i].soyisim);
                        for (int j = 0; j < dersler.Count; j++) // derslere bak
                        {
                            if (dersler[j].dersID.Equals((String)row["ders_id"])) // dersi bulduk "j"
                            {
                                DersNotlari dersNotlari = new DersNotlari();
                                dersNotlari.dersID = dersler[j].dersID;
                                dersNotlari.dersadi = dersler[j].dersadi;
                                dersNotlari.dersiverenhocaID =dersler[j].dersiverenhocaID;
                                dersNotlari.sayisalnot = (int)row["sayisalnot"];
                                dersNotlari.harfnotu = (String)row["harfnot"];
                                Console.WriteLine(dersNotlari.ToString());
                                ogrenciler[i].alinandersler.Add(dersNotlari);
                                break;
                            }
                        }
                        break;
                    }
                }
            }


            //ÖĞRETMENLERİN KRİTİK DERSLERİNİN BAĞLANTILARI ---------------------------------------------

            da = new NpgsqlDataAdapter("select* from ogretmen_kritikdersler",baglanti);
            DataSet ds_ogretmen_kritikdersler = new DataSet();
            da.Fill(ds_ogretmen_kritikdersler);
            foreach(DataRow row in ds_ogretmen_kritikdersler.Tables[0].Rows)
            {
                for(int i =0;i<ogretmenler.Count;i++)
                {
                    if (ogretmenler[i].ID == (int)row["ogretmen_id"]) // öğretmeni bulduk
                    {
                        for(int j = 0; j < dersler.Count; j++)
                        {
                            if (dersler[j].dersID.Equals((String)row["ders_id"])) // dersi bulduk
                            {
                                ogretmenler[i].kritikdersler.Add(dersler[j]);
                                break;
                            }
                        }
                        break;
                    }
                }
            }

            // ÖĞRENCİLERİN İLGİ ALANLARININ BAĞLANMASI

            da = new NpgsqlDataAdapter("select ogrenci_id,ilgialani_isimler from ogrenci_ilgialani inner join ilgialani_isimler on ilgialani_isimler.ilgialani_id=ogrenci_ilgialani.ilgialani_id", baglanti);
            DataSet ds_ogrenci_ilgialani = new DataSet();
            da.Fill(ds_ogrenci_ilgialani);
            foreach(DataRow row in ds_ogrenci_ilgialani.Tables[0].Rows)
            {
                for(int i = 0; i < ogrenciler.Count; i++)
                {
                    if (ogrenciler[i].ID == (int)row["ogrenci_id"]) // ogrenciyi bulduk
                    {
                        ogrenciler[i].ilgialanlari.Add((String)row["ilgialani_isimler"]);
                        break;
                    }
                }
            }

            da = new NpgsqlDataAdapter("Select * from ilgialani_isimler", baglanti);
            DataSet ds_ilgialani_ids = new DataSet();
            da.Fill(ds_ilgialani_ids);
            foreach (DataRow row in ds_ilgialani_ids.Tables[0].Rows)
            {
                ilgialanlari.Add(new İlgiAlani((int)row["ilgialani_id"], (String)row["ilgialani_isimler"]));   
            }

            // ÖĞRETMENLERİN İLGİ ALANLARININ BAĞLANMASI

            da = new NpgsqlDataAdapter("select ogretmen_id,ilgialani_isimler from ogretmen_ilgialani inner join ilgialani_isimler on ilgialani_isimler.ilgialani_id=ogretmen_ilgialani.ilgialani_id", baglanti);
            DataSet ds_ogretmen_ilgialani = new DataSet();
            da.Fill(ds_ogretmen_ilgialani);
            foreach (DataRow row in ds_ogretmen_ilgialani.Tables[0].Rows)
            {
                for (int i = 0; i < ogretmenler.Count; i++)
                {
                    if (ogretmenler[i].ID == (int)row["ogretmen_id"]) // ogretmeni bulduk
                    {
                        ogretmenler[i].ilgialanlari.Add((String)row["ilgialani_isimler"]);
                        break;
                    }
                }
            }

            // TALEPLERİN BAĞLANMASI
            da = new NpgsqlDataAdapter("select * from talep",baglanti);
            DataSet ds_talep = new DataSet();
            da.Fill(ds_talep);
            
            foreach(DataRow row in ds_talep.Tables[0].Rows)
            {
                Talep talep = new Talep();
                for (int i = 0; i < ogretmenler.Count; i++)
                {
                    if (ogretmenler[i].ID == (int)row["ogretmen_id"]) // ogretmeni ulduk
                    {
                        talep.ogretmen = ogretmenler[i];
                        break;
                    }
                }
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    if (ogrenciler[i].ID == (int)row["ogrenci_id"]) // ogrenciyi bulduk
                    {
                        talep.ogrenci = ogrenciler[i];
                        break;
                    }
                }
                for (int i = 0; i < ogrenciler.Count; i++)
                {
                    if (dersler[i].dersID.Equals((String)row["ders_id"])) // dersi bulduk
                    {
                        talep.ders = dersler[i];
                        break;
                    }
                }
                talep.durum = (String)row["durum"];
                talep.TalepID = (int)row["talep_id"];
                talepler.Add( talep );
            }

            for (int i = 0; i< ogrenciler.Count; i++)
            {
                Console.WriteLine("\n"+ogrenciler[i].isim + " " + ogrenciler[i].soyisim + " İSİMLİ OGRENCİNİN DERSİ:");
                for (int j = 0; j < ogrenciler[i].alinandersler.Count; j++)
                {
                    Console.WriteLine(ogrenciler[i].alinandersler[j].ToString());
                }
            }
            for (int i = 0; i < ogretmenler.Count; i++)
            {
                Console.WriteLine("\n" + ogretmenler[i].isim + " " + ogretmenler[i].soyisim + " İSİMLİ OGRETMENİN DERSİ:");
                for (int j = 0; j < ogretmenler[i].verilendersler.Count; j++)
                {
                    Console.WriteLine(ogretmenler[i].verilendersler[j].ToString());
                }
            }
            for (int i = 0; i < ogretmenler.Count; i++)
            {
                Console.WriteLine("\n" + ogretmenler[i].isim + " " + ogretmenler[i].soyisim + " İSİMLİ OGRETMENİN KRİTİK DERSİ:");
                for (int j = 0; j < ogretmenler[i].kritikdersler.Count; j++)
                {
                    Console.WriteLine(ogretmenler[i].kritikdersler[j].ToString());
                }
            }
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Console.WriteLine("\n" + ogrenciler[i].isim + " " + ogrenciler[i].soyisim + " İSİMLİ OGRENCİNİN İLGİ ALANLARİ:");
                for (int j = 0; j < ogrenciler[i].ilgialanlari.Count; j++)
                {
                    Console.WriteLine(ogrenciler[i].ilgialanlari[j].ToString());
                }
            }
            for (int i = 0; i < ogretmenler.Count; i++)
            {
                Console.WriteLine("\n" + ogretmenler[i].isim + " " + ogretmenler[i].soyisim + " İSİMLİ OGRETMENİN İLGİ ALANLARİ:");
                for (int j = 0; j < ogretmenler[i].ilgialanlari.Count; j++)
                {
                    Console.WriteLine(ogretmenler[i].ilgialanlari[j].ToString());
                }
            }
            Console.WriteLine("TALEPLER:");
            for(int i = 0; i < talepler.Count; i++)
            {
                Console.WriteLine(talepler[i].ToString()+"\n");
            }

           // ogrenciler[0].setTalepsayisi(15);
           // Console.WriteLine("setTalepsayisi returns talepsayisi="+ ogrenciler[0].talepsayisi);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisEkrani());
        }
    }
}
