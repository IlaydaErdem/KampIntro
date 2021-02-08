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
            Console.WriteLine("Müşteri Adı : " + musteri1.Adi +"\nMüşteri Soyadı : " + musteri1.Soyadi +"\nBakiye Tutarı : " + musteri1.Bakiye + " TL " + "\nSon İşlem Tarihi : " + musteri1.SonIslemTarihi);

            Console.WriteLine("----------------------> Yeni Müşteri <----------------------");

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Halil";
            musteri2.Soyadi = "İnal";
            musteri2.Bakiye = 550;
            musteri2.SonIslemTarihi = "01.09.2020";
            Console.WriteLine("Müşteri Adı: " + musteri2.Adi + "\nMüşteri Soyadı: " + musteri2.Soyadi + "\nBakiye Tutarı: " + musteri2.Bakiye + " TL " + "\nSon İşlem Tarihi: " + musteri2.SonIslemTarihi);

            Console.WriteLine("----------------------> Yeni Müşteri <----------------------");

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Selin";
            musteri3.Soyadi = "Şahin";
            musteri3.Bakiye = 0;
            musteri3.SonIslemTarihi = "29.01.2021";
            Console.WriteLine("Müşteri Adı: " + musteri3.Adi + "\nMüşteri Soyadı: " + musteri3.Soyadi + "\nBakiye Tutarı: " + musteri3.Bakiye + " TL " + "\nSon İşlem Tarihi: " + musteri3.SonIslemTarihi);

        }
    }
}
