using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Metot injection - dependency injection
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) 
            // bütün kredilerin referansın tuttuğu için böyle yazıyoruz
            // böylece bütün kredileri buraya gönderebiliyoruz
        {
            krediManager.Hesapla();
            loggerService.Log();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
