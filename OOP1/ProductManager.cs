using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {

        //Creat, Read, Update, Delete operasyonları- Ekle, oku, güncelle, sil.

                        //(string ad) gibi
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        






        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);
        }

        //void verilen işi yapar sonuçlandırır ve bitirir.
        //int verilen işi yapar sonuçlandırır ve sonuç ile tekrar bir iş yaptırılır.


    }
}
