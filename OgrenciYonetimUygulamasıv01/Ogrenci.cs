using System;
using System.Collections.Generic;

namespace OgrenciYonetimUygulamasıv01
{
    class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string Sube;

        public float Ortalama;

        public Ogrenci()
        {



        }
        //kurucu methodlar construct
        public Ogrenci(int no, string ad, string soyad, string sube)
        {

            No = no;
            Ad = ad;
            Soyad = soyad;
            Sube = sube;
        
        }

        public void OrtalamaHesapla(int matematiknotu, int fennotu, int sosyalnotu)
        {

            int toplam = matematiknotu + fennotu + sosyalnotu;
            Ortalama = (float)toplam / 3;
        
        }


    }
}
