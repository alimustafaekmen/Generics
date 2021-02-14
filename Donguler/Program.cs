using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım gliştirme kamp kursu", "Programlamaya başlangıç", "Java" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}
