using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dictionary sınıfı içerisinde bizim belirleyeceğimiz bir key e uygun olarak değer saklar.
             * key türünün belirlenmesi şarttır(string,int,double vs....)
             */
            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //veri eklenir.
            AdYas.Add("İshak",26);
            AdYas.Add("Ali",22);
            AdYas.Add("Mehmet",29);
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();
            //silme özelliği vardır.
            AdYas.Remove("Ali");
            foreach (var degeroku2 in AdYas)
            {
                Console.WriteLine(degeroku2);
            }
            Console.ReadLine();
            //değer sayma özelliği vardır.
            var elemansay = AdYas.Count;
            Console.WriteLine("Eleman Sayısı:"+elemansay);
            Console.ReadKey();

            

        }
    }
}
