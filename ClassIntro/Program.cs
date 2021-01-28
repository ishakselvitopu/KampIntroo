using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ishak";
            int yas = 26;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 28;
            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };
            foreach (var kursum in kurslar)
            {
                Console.WriteLine(kursum.KursAdi + ":" + kursum.Egitmen);
            }

            Console.ReadKey();
        }
        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}
