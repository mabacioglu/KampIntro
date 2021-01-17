using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            // stack                 heap
            //101/sayilar1           101/  [10,20,30]
            //102/sayilar2           102/  [100,200,300]
            // 17. satırdan sonra Garbage collector boşta kalan veriyi siler yani 101 referanslıyı

        }
    }
}
