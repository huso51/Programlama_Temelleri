using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    // Tanımlama
    public struct Ogrenci
    {
        // Yapılandırıcı metot - Constructor
        public Ogrenci(int numara, string adi, 
            string soyadi, bool cinsiyet=true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

         public int Numara { get; set; } // Property - Özellik
         public string Adi { get; set; }
         public string Soyadi { get; set; }
         public bool Cinsiyet { get; set; }

        // Geçersiz kılmak / Ezmek / Override
        public override string ToString()
        {
            return $"{Numara,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }

        public static void Calistir()
        {
            var ogrenciListesi = new List<Ogrenci>()
            {
                new Ogrenci(10,"Ahmet","Yılmaz"),
                new Ogrenci(20, "Fatma", "Dag", false),
                new Ogrenci(30, "Mehmet", "Avşar", true),
                new Ogrenci(40, "Asaf", "Karlıdağ")
            };

            ogrenciListesi.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }
    }
}


