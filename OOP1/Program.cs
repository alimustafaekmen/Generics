﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, 
                UnitsInStock = 5, UnitPrice = 35, ProductName = "Kalem"};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


            //Int - void methot farkı!!!
            //void dediğimiz zaman git yap demek. Ama int-string-bool vs. gibi metotlarda sonucu döndürerek başka yerde kullanabiliyoruz.!!!
            
            //productManager.Topla2(3, 6); voidli metot!!!

            //int toplam = productManager.Topla(3, 6); int li metot!!!
            //Console.WriteLine(toplam * 2);
        }
    }
}
