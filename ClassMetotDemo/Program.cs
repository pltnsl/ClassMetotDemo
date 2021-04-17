using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Necdet";
            musteri1.Soyadi = "PAMUK";
            musteri1.Adresi = "Bayır Sk.No:15 ANKARA";
            musteri1.Meslegi = "Öğretmen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Melda";
            musteri2.Soyadi = "SAVAŞ";
            musteri2.Adresi = "Güneş Sk.No:1 BURSA";
            musteri2.Meslegi = "Mühendis";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);





        }
         


    }
}
