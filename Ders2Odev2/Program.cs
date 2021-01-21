using System;

namespace Ders2Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
                  
            Urun urun1 = new Urun();
            urun1.Kategori = "Elektronik";
            urun1.UrunAdi = "Bilgisayar";
            urun1.Fiyat = 5000;
            urun1.Stok = 12;

            Urun urun2 = new Urun();
            urun2.Kategori = "Giyim";
            urun2.UrunAdi = "Kazak";
            urun2.Fiyat = 100;
            urun2.Stok = 50;

            Urun urun3 = new Urun();
            urun3.Kategori = "Beyaz Eşya";
            urun3.UrunAdi = "Buzdolabı";
            urun3.Fiyat = 6000;
            urun3.Stok = 8;


            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("For Döngüsü;");

            for (int i=0; i<urunler.Length; i++)
            {
                Console.WriteLine("Kategori: " + urunler[i].Kategori);
                Console.WriteLine("Ürün Adı: " + urunler[i].UrunAdi);
                Console.WriteLine("Fiyat: " + urunler[i].Fiyat);
                Console.WriteLine("Kalan Adet: " + urunler[i].Stok);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("For Döngüsü Bitti.");

            Console.WriteLine("              ");

            Console.WriteLine("Foreach Döngüsü;");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Kategori: " + urun.Kategori);
                Console.WriteLine("Ürün Adı : " + urun.UrunAdi);
                Console.WriteLine("Fiyat: " + urun.Fiyat);
                Console.WriteLine("Kalan Adet: " + urun.Stok);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("Foreach Döngüsü Bitti.");

            Console.WriteLine("              ");

            Console.WriteLine("While Döngüsü;");

            int s = 0;
            while (s<urunler.Length)
            {
                Console.WriteLine("Kategori: " + urunler[s].Kategori);
                Console.WriteLine("Ürün Adı: " + urunler[s].UrunAdi);
                Console.WriteLine("Fiyat: " + urunler[s].Fiyat);
                Console.WriteLine("Kalan Adet: " + urunler[s].Stok);
                Console.WriteLine("-------------");
                s++;
            }

            Console.WriteLine("While Döngüsü Bitti.");
        }
    }

    class Urun
    {
        public string Kategori { get; set; }
        public string UrunAdi { get; set; }
        public int Fiyat { get; set; }
        public int Stok { get; set; }
    }
}
