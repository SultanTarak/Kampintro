using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassMetotDemo isimli bir proje oluşturunuz.
            //Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
            //MusteriManager sınıfı oluşturunuz.
            //Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.

            Musteri musteri1 = new Musteri();
            musteri1.Id = 111111;
            musteri1.Adi = "Ahmet";
            musteri1.Soyadi = "Aslan";
            musteri1.KrediTutari = 100000;
            musteri1.TaksitSayisi = 36;
            musteri1.KalanTaksitSayisi = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 222222;
            musteri2.Adi = "Ali";
            musteri2.Soyadi = "Eke";
            musteri2.KrediTutari = 60000;
            musteri2.TaksitSayisi = 36;
            musteri2.KalanTaksitSayisi = 18;

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekle(musteri1);
            musteriManager1.Ekle(musteri2);
            Console.WriteLine("\n");

            MusteriManager musteriManager2 = new MusteriManager();
            Console.WriteLine("Müşteri Listesi;" + "\n");
            musteriManager2.Listele(musteri1);
            musteriManager2.Listele(musteri2);
            Console.WriteLine("\n");

            MusteriManager musteriManager3 = new MusteriManager();
            musteriManager3.Sil(musteri1);
            //musteriManager3.Sil(musteri2);
        }
    }
}
