using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir bankada müşteri takibi yapmak istiyorsunuz.--Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
            //MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "İrem";
            musteri1.Soyadi = "Avcı";
            musteri1.Bakiye = 1000;
            musteri1.SonIslemTarihi = "12.12.2020";
            

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Halil";
            musteri2.Soyadi = "İnal";
            musteri2.Bakiye = 550;
            musteri2.SonIslemTarihi = "01.09.2020";
            

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Selin";
            musteri3.Soyadi = "Şahin";
            musteri3.Bakiye = 0;
            musteri3.SonIslemTarihi = "29.01.2021";
            

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi );
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Bakiye);
                Console.WriteLine(musteri.SonIslemTarihi);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Console.WriteLine("---------------------------");

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Sil(musteri1);
            musteriManager1.Sil(musteri2);
            musteriManager1.Sil(musteri3);
        }
    }
}
