using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri )
        {
            Console.WriteLine("Müşteri Adı: " + musteri.Adi + "Müşteri Soyadı: " +musteri.Soyadi + "Müşteri Bakiye: " + musteri.Bakiye + "Müşteri Son İşlem Tarihi: " + musteri.SonIslemTarihi);
        }
        public void Sil(Musteri musteri)
        {
            
        }
    }
}
