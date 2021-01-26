using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 16247001;
            musteri1.Adi = "Ali";
            musteri1.Soyadi = "Kaya";
            musteri1.TcKimlikNo = 14755698652;
            musteri1.HesapNo = 7539514628;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 16247002;
            musteri2.Adi = "Nur";
            musteri2.Soyadi = "Kaya";
            musteri2.TcKimlikNo = 85461982963;
            musteri2.HesapNo = 4567319826;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 16247003;
            musteri3.Adi = "Ayşe";
            musteri3.Soyadi = "Kaya";
            musteri3.TcKimlikNo = 14375695852;
            musteri3.HesapNo = 741369856;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2,musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID : " + musteri.Id +" "+ "TC KİMLİK NO : " + musteri.TcKimlikNo + " " + "ADI : " + musteri.Adi + " " + "SOYADI : " + musteri.Soyadi + " " + "HESAP NO: " +musteri.HesapNo );

            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
        }

        

        }
}
