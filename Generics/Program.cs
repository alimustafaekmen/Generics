using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("İstanbul");
            sehirler2.Add("Ankara");
            sehirler2.Add("İzmir");
            sehirler2.Add("Antalya");


            foreach (var sehir in sehirler2.Array)
            {
                Console.WriteLine(sehir);
            }



        }
    }
}
