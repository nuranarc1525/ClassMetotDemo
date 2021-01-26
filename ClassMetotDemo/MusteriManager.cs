using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)

        {

            Console.WriteLine(musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.TcKimlikNo + " " + musteri.HesapNo + " " + " eklendi.");
            
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine(musteri.Id+ " " + musteri.Adi+ " " + musteri.Soyadi+ " " + musteri.TcKimlikNo+ " " + musteri.HesapNo+ " " + "müşteri listelendi");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + musteri.TcKimlikNo + " " + musteri.Adi + " " + musteri.Soyadi + " " + " bilgilerdeki müşterinin" + " " + musteri.HesapNo + " " + " nolu banka hesabı silinmiştir.");

        }
       

    }
}
