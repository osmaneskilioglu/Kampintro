using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //do not repeat yourself - Kenidini tekrarlama!
            //değer tutucu, alias

            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool SistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun) ;

            {
                Console.WriteLine("Artis Butonu");

            }
                else
            {

            }        
            


        }
    }
}
