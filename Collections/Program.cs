using System;
using System.Collections.Generic; // List yazdıktan sonra soldaki ampulden bunu ekleyerek listi aktive ettik

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //Console.WriteLine(isimler[4]);
            //bunu yapamayız çünkü diziler en başta tanımladığımız sayının dışına çıkmaz

            //string[] isimler = new string[5];
            //yukarıdaki işlemi yaparak 5 boyutlu bir dizi oluşturur ve ilkeri yazdırırız ama 0 1 2 3. indekslerdeki elemanları
            //tanımlamadığımız için isimler[0] yazdırdığımızda boş gelir, yeniden new yapmak yeni bir adres oluşturur!!
            //isimler[4] = "İlker"; 
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            //bu sebeple dizi kullanmak yerine java ve c#ta koleksiyonlar(List) kullanırız.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" }; 
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
