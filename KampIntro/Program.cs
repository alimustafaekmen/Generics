using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int oğrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirişYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayartlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap burtonu");
            }

            Console.WriteLine(kategoriEtiketi);



            // ternary operatörü kullanımı
            bool oturumDurumu = true;
            string mesaj = oturumDurumu == false ? "Oturum kapalı" : "Oturum açık";
            Console.WriteLine(mesaj);


        }
    }
}
