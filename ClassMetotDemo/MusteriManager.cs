using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " isimli müşteri başarıyla eklendi.");
        }

        
        public void Listele(Musteri musteri)
        {         
            Console.WriteLine("Id : " + musteri.Id);
            Console.WriteLine("Adı : " + musteri.Adi);
            Console.WriteLine("Soyadı : " + musteri.Soyadi);
            Console.WriteLine("Kredi Tutarı : " + musteri.KrediTutari);
            Console.WriteLine("Toplam Taksit Sayısı : " + musteri.TaksitSayisi);
            Console.WriteLine("\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " " + "nolu müşteri başarıyla silindi");
        }
    }
}
