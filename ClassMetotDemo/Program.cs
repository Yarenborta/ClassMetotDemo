using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriIsmi musteri1 = new MusteriIsmi();
            musteri1.Adi = "Rabia";
            musteri1.SoyAdi = "BAŞA";
            musteri1.TcNo = "34002546761";
            musteri1.Id = 34;

            MusteriIsmi musteri2 = new MusteriIsmi();
            musteri2.Adi = "Aylin";
            musteri2.SoyAdi = "ASAR";
            musteri2.TcNo = "36234951872";
            musteri2.Id = 110;

            MusteriIsmi musteri3 = new MusteriIsmi();
            musteri3.Adi = "Ela";
            musteri3.SoyAdi = "YERLİKAYA";
            musteri3.TcNo = "26459187325";
            musteri3.Id = 64;

            MusteriIsmi[] musteriler = new MusteriIsmi[] {musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            foreach (MusteriIsmi musteri in musteriler)
            {
                musteriManager.Ekle (musteri1);
                musteriManager.Ekle(musteri2);
                musteriManager.Ekle(musteri3);
            }
            Console.WriteLine("--MÜŞTERİLER----");
            foreach (MusteriIsmi musteriIsmi in musteriler)
            {
                musteriManager.Listele(musteri1);
                musteriManager.Listele(musteri2);
                musteriManager.Listele(musteri3);
            }
            
            

            Console.WriteLine("----MÜŞTERİLER");
            
            foreach (MusteriIsmi musteri in musteriler)
            {
                musteriManager.Sil(musteri1);
                musteriManager.Sil(musteri2);
                musteriManager.Sil(musteri3);
            }

        }
    }
}
