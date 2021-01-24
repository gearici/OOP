using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //string değil de T değişkeni kullanıcam diyorum kuralları kendim koyuyorum
                    //hangi değişkenle bu classtan eleman oluşturursak onu benimser
    {
        T[] items;

        public MyList() //ctor tab tab yaptık bu bir constructor
        {
            items = new T[0]; //bir blok newlendiğinde oluşan bloğa constructor denir
        }
        public void Add(T item)
        {
            T[] tempArray = items; //önceki değerleri buna tutturuyoruz yeni değeri alttaki satırda giriyoruz
            items = new T[items.Length + 1]; //eleman sayısını 1 arttırır ama new yapınca öncekiler uçuyordu bunu birine tutturalım geçici diziye 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //geçiçi diziye devrettiğim elemanları items listeme tekrardan alıyorum
            }

            items[items.Length - 1] = item;//itemda en sonda boş bir hücre kalmıştı ona da son değerini atadık
        }
    }
}
