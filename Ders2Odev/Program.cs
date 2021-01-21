using System;

namespace Ders2Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch - Case yapısı İf - Else yapısına benzer bir yapıdır. Yalnız İf-Else yapısı birden fazla durumu aynı
            //anda kontrol etmemize yararken, Switch-Case yapısında her koşul ve her durum ayrı ayrı tanımlanmalıdır.

                Console.WriteLine("Switch Yapısı;");
            
            int number = 3;
            if (number == 1)
            {
                Console.WriteLine("Durum 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("Durum 2");
            }
            else
            {
                Console.WriteLine("Varsayılan Durum");
            }

            switch (number)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                case 3:
                    Console.WriteLine("Varsayılan Durum");
                    break;
            }

            //While döngüsü içerisindeki koşul doğru olduğu sürece tekrar eden, koşul yanlış olduğunda döngüden
            //çıkan bir yapıdır.
            
                Console.WriteLine("While Döngüsü;");

            int sayi = 1;
            while (true)
            {
                if(sayi ==  11)
                { break;
                }
                Console.WriteLine(sayi);
                sayi++;
            }

            Console.WriteLine("Hello World!");
        }
    }
}
