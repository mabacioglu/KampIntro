using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T type dan geliyor
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // new yaparken hangi veri türü seçildiyse bu metot o veri türünü isteyecek.
        {
            T[] tempArray = items;  // geçici dizi
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
