using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(MusteriIsmi musteri)
        {
            Console.WriteLine("Yeni bir müşteri eklenmiştir." + musteri.Adi + "  "+musteri.SoyAdi);
        }
       
        public void Listele(MusteriIsmi musteriler)
        {
            Console.WriteLine("Müşteriler listelendi" + musteriler.Adi +"  " + musteriler.SoyAdi);
        }
        public void Sil(MusteriIsmi musteri)
        {
            Console.WriteLine("Müşteri silme talebiniz gerçekleştirilmiştir."+ musteri.Adi+"  "+musteri.SoyAdi);
        }


    }
}
