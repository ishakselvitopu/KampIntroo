using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım1", "Yazılım2", "Yazılım3", "Yazılım4" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            foreach (string kurs in kurslar) //kursları tek tek dolaş.Foreach dizilerde uygulanır.
            {
                Console.WriteLine(kurs);
            }
            Console.ReadKey();
        }
    }
}
