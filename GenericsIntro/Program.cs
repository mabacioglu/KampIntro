using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("mehmet"); // <> arasına string yazdığımız için benden string istiyor
            myList.Add("Ayşe");
            
        }
    }
}
