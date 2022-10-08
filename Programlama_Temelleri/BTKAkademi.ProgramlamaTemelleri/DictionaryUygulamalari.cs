using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class DictionaryUygulamalari
    {
        public static void KullaniciTarafliVeriTipiIleDictoryUygulamasi()
        {
            // Dictionary
            var personelListesi = new Dictionary<int, Personel>()
            {
                {110, new Personel("Mehmet","Sonsoz",7500)},
                {120, new Personel("Ahmet","Can",9000) }
            };

            personelListesi.Add(100, new Personel("Zeynep", "Coskun", 5000));
            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
        }
        public static void DictionaryTemelleri()
        {
            // Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332, "Konya"},
                {424, "Elazığ"},
                {466, "Art"},
                {422, "Malatya" }
            };

            // Ekleme
            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "İstanbul");
            telefonKodlari.Add(216, "İstanbul");

            // Erişme
            telefonKodlari[466] = "Artvin";

            // ContainsKey
            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkara'nın kod bilgisi tanımli degil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi.");
            }

            // ContainsValue
            if (!telefonKodlari.ContainsValue("Malatya"))
            {
                Console.WriteLine("\aMalatya'nın kod bilgisi tanimli değil!");
                telefonKodlari.Add(422, "Malatya");
                Console.WriteLine("Yeni kod eklendi.");
            }

            telefonKodlari.Remove(322);

            foreach (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }
        }
    }

    
}


