﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }


        //public int Topla(int sayi1, int sayi2)  intli metot !!!
        //{
        //    return sayi1 + sayi2;
        //}

        //public void Topla2(int sayi1, int sayi2) voidli metot !!!
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
