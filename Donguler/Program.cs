using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yaizilim Geliştrici Yetistirme Kampi";
            string kurs2 = "Programlamaya baslangic icin temel kurs";
            string kurs3 = "Java";
            string kurs4 = "python";
            string kurs5 = "c++";

            //array  dizi

            string[] kurslar = new string[] {"Yaizilim Geliştrici Yetistirme Kampi", "Programlamaya baslangic icin temel kurs","Java", "python", "c++"};

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayafasonu - footer");
        }
    }
}
