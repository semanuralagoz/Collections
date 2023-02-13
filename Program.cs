using System;
using System.Collections.Generic;
namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new  string[] { "Sema", "Yilmaz", "Ayse" };
            Console.WriteLine(isimler[0]);
            isimler = new string[4];
            isimler[3] = "İlker";
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[1]);
            //diziler genişletilmez, yeni eleman eklersek eski elemanları kaybederiz


            List<string> isimler2 = new List<string> { "Lütfiye", "Seda", "Mehmet", "Eda" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[2]);

            isimler2.Add("Mahmut");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

            //Listlere sonradan eleman ekleyebiliriz bir sıkıntı oluşmaz 


        }
    }
}


