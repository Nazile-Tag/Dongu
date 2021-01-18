using System;

namespace DonguOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            BabyProduct urun1 = new BabyProduct();
            urun1.UrunAdi = "Avent Biberon";
            urun1.UrunFiyati = 55;
            urun1.IndirimOrani = 39;

            BabyProduct urun2 = new BabyProduct();
            urun2.UrunAdi = "Mama Kaşığı";
            urun2.UrunFiyati = 16;
            urun2.IndirimOrani = 32;

            BabyProduct urun3 = new BabyProduct();
            urun3.UrunAdi = "Mama Önlüğü";
            urun3.UrunFiyati = 24;
            urun3.IndirimOrani = 12;

            BabyProduct[] babyProducts = new BabyProduct[] {urun1, urun2, urun3};
            foreach (var urun in babyProducts)
            {
                Console.WriteLine(urun.UrunAdi + urun.UrunFiyati + urun.IndirimOrani);
            }
            
        }
    }
    class BabyProduct
    {
        public string UrunAdi { get; set; }
        public int UrunFiyati { get; set; }
        public int IndirimOrani { get; set; }
    }
}
