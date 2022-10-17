using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            // array - dizi
            string[] kurslar = new string[]{ "Yazılım Geliştirici Yetiştirme Kampı", "Programlamay Başlangıç İçin Temel Kurs", "Java", "Phyton", "C++", "Java Script" };


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");


            // Foreach Dizi temelli yapıları tek tek dönmeye yarar ve Dizilere uygulanır...
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
