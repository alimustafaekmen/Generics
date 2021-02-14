using System;
using System.Collections.Generic;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Mustafa";
            int yas = 15;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Eğitmen = "Kerem Varış";
            kurs2.İzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Berkay Bilgin";
            kurs3.İzlenmeOrani = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Java";
            kurs4.Eğitmen = "Murat Karaoğlu";
            kurs4.İzlenmeOrani = 70;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Eğitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}
