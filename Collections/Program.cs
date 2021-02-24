﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);  
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler = new string[5]; //Yeni bir referans numarasına 5 elemanlı içi 
            //boş bir dizi oluşturdu 5. elemanına "İlkay" ismini verdi.
            isimler[4] = "İlkay";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);

            Console.WriteLine("-------------List-----------------");

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Halil", "Kerem" };
            Console.WriteLine(isimler2[0]); 
            Console.WriteLine(isimler2[1]); 
            Console.WriteLine(isimler2[2]); 
            Console.WriteLine(isimler2[3]);

            isimler2.Add("İlkay");
            Console.WriteLine(isimler2[4]); 
            Console.WriteLine(isimler2[0]); 
        }
    }
}
