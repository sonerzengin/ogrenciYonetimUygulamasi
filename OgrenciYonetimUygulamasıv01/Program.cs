using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasıv01
{
    class Program
    {

        static List<Ogrenci> Ogrenciler = new List<Ogrenci>();

        static void Main(string[] args)
        {
            Uygulama();

        }

        static void Uygulama()
        {
            //Console.WriteLine(DenemelerYapıyorum());
            SahteVeriGir();
            Menu();

            int sayac = 0;
            do
            {


                Console.WriteLine("Seciminiz: ");
                string secim = Console.ReadLine();

                switch (secim)
                {

                    case "1":
                    case "E":
                        OgrenciEkle();
                        break;
                    case "2":
                    case "L":
                        OgrenciListele();
                        break;
                    case "3":
                    case "S":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        Console.WriteLine("Çıkış Yaptiniz");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Yanlis giris yaptiniz.");
                        sayac++;
                        break;


                }


            } while (sayac < 10);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
            Console.WriteLine("--------------------------------------------------");


        }

        static void Menu()
        {

            Console.WriteLine("Öğrenci Yönetim Uygulaması v01");
            Console.WriteLine("1 - Öğrenci Ekle(E)");
            Console.WriteLine("2 - Öğrenci Listele(L)");
            Console.WriteLine("3 - Öğrenci Sil(S)");
            Console.WriteLine("4 - Çıkış(X)");
            Console.WriteLine();




        }


        static void SahteVeriGir()
        {

            Ogrenci a = new Ogrenci(12, "Yunus", "Emre", "A");
            Ogrenciler.Add(a);



            Ogrenci b = new Ogrenci();

            b.Sube = "B";
            b.Ad = "Ahmet";
            b.Soyad = "Mehmet";
            b.No = 684;
            Ogrenciler.Add(b);

            Ogrenci c = new Ogrenci();

            c.Sube = "C";
            c.Ad = "Ayşe";
            c.Soyad = "Yılmaz";
            c.No = 56;
            Ogrenciler.Add(c);


        }

        static void OgrenciListele()
        {

            Console.WriteLine("2 - Öğrenci Listele----------------");
            Console.WriteLine();
            
            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("Öğrenci listesi boş.");
                
            }
            else
            {
                Console.WriteLine("Şube" + "     No     " + "Ad Soyad");
                Console.WriteLine("----------------------------------------------");

                foreach (Ogrenci ogr in Ogrenciler)
                {

                    Console.WriteLine(ogr.Sube.PadRight(9) + ogr.No.ToString().PadRight(8) + ogr.Ad + " " + ogr.Soyad);


                }
            }

            

            
        }

        static void OgrenciEkle()
        {


            Ogrenci o = new Ogrenci();

            Console.WriteLine("1 - Öğrenci Ekle -------------");
            int deger = 0;

            do 
            {
                
                Console.WriteLine("{0}.oğrencinin: ", deger + 1 );

                
                
                    Console.Write("No: ");
                    o.No = int.Parse(Console.ReadLine());

                    foreach (Ogrenci item in Ogrenciler)
                    {
                        if (item.No == o.No)
                        {
                            Console.WriteLine("Bu numarada bir ogrenci var.");
                            Console.Write("No: ");
                            o.No = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                        
                    }
                


                Console.Write("Adı: ");
                o.Ad = IlkHarfiBuyut(Console.ReadLine());

                Console.Write("Soyadı: ");
                o.Soyad = IlkHarfiBuyut(Console.ReadLine());

                Console.Write("Şubesi: ");
                o.Sube = IlkHarfiBuyut(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
                string giris = Console.ReadLine().ToUpper();

                if (giris == "E")
                {
                    deger++;
                    Ogrenciler.Add(o);
                    Console.WriteLine("Öğrenci Başarıyla Eklendi...");
                    
                }
                else
                {

                    Console.WriteLine("Öğrenci Eklenemedi...");
                    
                }

                Console.Write("Yeni ogrenci eklemek icin 1'e,cikmak icin 9'a basin: ");
                int a = int.Parse(Console.ReadLine());
                if (a == 1)
                {
                    continue;
                }
                else if (a == 9)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatali giris yaptiniz.");
                    break;
                }
            }while (deger <= Ogrenciler.Count) ;
        }


        static void OgrenciSil()
        {
            
                Console.WriteLine("3 - Öğrenci Sil --------------");

                if (Ogrenciler.Count == 0)
                {
                    Console.WriteLine("Listede Ogrenci yok");
                    
                }
                else { 
            
                Console.WriteLine("Silmek istediğiniz öğrencinin: ");
                Console.Write("No: ");
                int no = int.Parse(Console.ReadLine());

                Ogrenci ogrenci = null;

                foreach (Ogrenci item in Ogrenciler)
                {

                    if (item.No == no)
                    {

                        ogrenci = item;

                    }

                }


                if (ogrenci != null)
                {

                    Console.WriteLine("Adı: " + ogrenci.Ad);
                    Console.WriteLine("Soyadı: " + ogrenci.Soyad);
                    Console.WriteLine("Şubesi: " + ogrenci.Sube);
                    Console.WriteLine();

                    Console.WriteLine("Silmek istediğinize emin misiniz? (E/H)");
                    string secim = Console.ReadLine().ToUpper();

                    if (secim == "E")
                    {

                        Ogrenciler.Remove(ogrenci);
                        Console.WriteLine("Öğrenci başarıyla silindi...");

                    }
                    else
                    {

                        Console.WriteLine("Öğrenci silinemedi...");


                    }


                }
                 else
                 {

                    Console.WriteLine("Listede böyle bir öğrenci yok...");

                 }

                }




        }

        static string IlkHarfiBuyut(string veri)
        {

            return veri.Substring(0, 1).ToUpper() + veri.Substring(1).ToLower();

        }

        static float DenemelerYapıyorum()
        {

            Ogrenci o = new Ogrenci(78, "Fatma", "Gül", "A");
            o.OrtalamaHesapla(56, 65, 85);
            return o.Ortalama;

        
        }

        



    }
}
