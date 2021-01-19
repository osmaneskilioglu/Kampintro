using System;

namespace ClassIntroVeri
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int Yas = 36;


            Kurs Kurs1 = new Kurs();
            Kurs1.KursAdi = "C#";
            Kurs1.Egitmen = "Engin Demirog";
            Kurs1.IzlenmeOrani = 68;

            Kurs Kurs2 = new Kurs();
            Kurs2.KursAdi = "Java";
            Kurs2.Egitmen = "Kerem Varis";
            Kurs2.IzlenmeOrani = 64;

            Kurs Kurs3 = new Kurs();
            Kurs3.KursAdi = "Python";
            Kurs3.Egitmen = "Berkay Bilgin";
            Kurs3.IzlenmeOrani = 80;

            Kurs Kurs4 = new Kurs();
            Kurs4.KursAdi = "C++";
            Kurs4.Egitmen = "Murat Kurtbogan";
            Kurs4.IzlenmeOrani = 100;

            //Console.WriteLine(Kurs2.KursAdi + " " + Kurs2.Egitmen);

            Kurs[] kurslar = new Kurs[] {Kurs1, Kurs2, Kurs3, Kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen );
            }

        }
    }

    class Kurs
    {

        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
