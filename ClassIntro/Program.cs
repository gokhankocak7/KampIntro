using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Gökhan";
            int yas = 30;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Ogrenci = "Gökhan Koçak";
            kurs1.IzlenmeOrani = 26;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Ogrenci = "Gökhan Koçak";
            kurs2.IzlenmeOrani = 45;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Ogrenci = "Gökhan Koçak";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Ogrenci);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Ogrenci);
            }


            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Ogrenci { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
