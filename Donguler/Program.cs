using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazilimci Kursu";
            string kurs2 = "Temel Kurs";
            string kurs3 = "Java";

            //array-dizi

            string[] kurslar = new string[] { "Yazilimci Kursu" , "Temel Kurs", "Java", "Python","JavaScript","C#" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine( );
            Console.WriteLine("---------------------------ForBitti---------------------------");
            Console.WriteLine();
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine();
            Console.WriteLine("------------------------SayfaSonu-Footer----------------------");
        }
    }
}
