using System;

namespace DeğerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, float, decimal, double, bool = Değer Tipleri.
            //array, class, interface = Referans Tipler.


            //değer tipi örnek
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??  30


            //referans tipi örnek

            //sayilar2 nin referans numarasına sayilar1 de bağlanır 
            //ve aynı referans numarasına sahip olurlar 
            //o yüzden sayilar2 de yapılan değişikklikten sayilar 1 de etkilenir.
            //sayilar2 nin ilk elamanı 999 ollarak değiştirildiği için 
            //sayilar1 de de aynı değişiklik yapılmış olur çünkü yanı referans numarasına sahipler.

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ??  999
        }
    }
}
