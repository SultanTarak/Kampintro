using System;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(111, "Sultan");
            ogrenciler.Add(222, "Elif");
            ogrenciler.Add(333, "Ahmet");
            ogrenciler.Add(444, "Efe");

        }
    }
}
