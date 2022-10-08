using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class OgretimElemani 
    {
        // Property - Özellik 
        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Default ctor
        public OgretimElemani()
        {
           
        }

        public OgretimElemani(int sicilNo, string adi, string soyadi, bool cinsiyet)
        {
            SicilNo = sicilNo;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{SicilNo,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10} " +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }

        public static void Calistir()
        {
            // Tanımlama - Atama
            var liste1 = new List<OgretimElemani>()
                {
                    new OgretimElemani(100,"Ahmet","Yalçın",true),
                    new OgretimElemani(101,"Aylin","Dag",false),
                    new OgretimElemani(102,"Mehmet","Yıldız",true),
                    new OgretimElemani(103,"Servet","Aydogdu",true),
                    new OgretimElemani(104,"Leyla","Aydın",false),
                    new OgretimElemani(105,"Selim","Asilhan",true)
                };

         
            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            var liste2 = liste1;

            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
         

            liste2.Add(new OgretimElemani(106, "Öner", "Han", true));
            liste1.RemoveAt(0);

            Console.ReadKey();

            Console.WriteLine("Liste 1");
            liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();

            Console.WriteLine("Liste 2");
            liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
        }

       
    }
}


