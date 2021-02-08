using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri )
        {
            Console.WriteLine("Adınıza Hesabınız açıldı :" + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Hesabınız silindi :" + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}
