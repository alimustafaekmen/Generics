using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //dinamik programlama
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 10;
            urun1.Açiklama = "Amasya elması";
            urun1.StokAdedi = 15;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Açiklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 20;

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Açiklama);
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("--------Metotlar--------");

            //intance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 10, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 10, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 10, 8);


        }
    }
}
