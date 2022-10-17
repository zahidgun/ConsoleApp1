using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 200;
            double faizOrani = 1.5;
            bool sistemeGirişYapmışMı = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.65;


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

            if (sistemeGirişYapmışMı == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

           
            

        }
    }
}
