using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler "+urun.Adi+" Sepete eklendi");
        }
        public void Ekle2(string urunAdi,string Aciklama,double Fiyat) 
            /* 
             sonradan stok adedi eklenecekse program hata veriyor ve tüm kodun değiştirilmesi gerekiyor
             fakat sınfa bu özelliği eklediğin zaman sayafada hiç bir hata almazsın
             bu olay   ENCAPSULATION    dır.         
         */
        {
            Console.WriteLine("Tebrikler " + urunAdi + " Sepete eklendi");

        }
    }
}
