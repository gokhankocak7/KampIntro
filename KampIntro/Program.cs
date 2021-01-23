using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //Do not repeat yourself -kendini tekrarlama

            string kategoriEtiketi = "Kategoriler";
            int ogrenicSayisi = 32000;
            double faizOrani= 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
      

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
