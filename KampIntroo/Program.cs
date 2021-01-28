using System;

namespace KampIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safty--tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 3200;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.ReadKey();
        }
    }
}
