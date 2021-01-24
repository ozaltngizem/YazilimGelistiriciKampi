using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kurs";
            string kurs2 = "Programlamaya Giriş";
            string kurs3 = "Java";
            string kurs4 = "Pyhton";
            string kurs5 = "C++";

            //aray - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Kurs", "Programlamaya Giriş", "Java", 
                "Pyhton", "C++"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("For Bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu - footer");

        }
    }
}
