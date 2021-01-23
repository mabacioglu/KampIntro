using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1244";
            musteri1.TcNo = "1648541641";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Abacıoğlu";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1245";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567980";

            // Musteri class ı Gerçek müşteri ve Tüzel müşterinin referansını tutabiliyor.
            //************** base sınıf referans tutucudur. ***************
            Musteri musteri3 = new GercekMusteri();  
            Musteri musteri4 = new TuzelMusteri();
           

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);




        }
    }
}
