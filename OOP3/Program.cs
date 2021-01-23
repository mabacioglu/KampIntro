using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1....
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //// *******Interface de kendisinden miras alan sınıfların referansını tutabilir.********

            // 2.......
            Console.WriteLine("-------------------------------------");
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            // 3..............
            Console.WriteLine("-------------------------------------");
            List<IKrediManager> krediler = new List<IKrediManager>() { konutKrediManager,ihtiyacKrediManager};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            // 4........
            Console.WriteLine("-------------------------------------");
            basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            ILoggerService fileLoggerService = new FileLoggerService();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService);


        }
    }   
}
