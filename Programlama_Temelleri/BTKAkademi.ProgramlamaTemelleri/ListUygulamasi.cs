
using System;
using System.Collections.Generic;
using System.Text;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class ListUygulamasi
    {
        public static void SehirUygulamasi()
        {
            // List
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            // Sehir Listesi
            var sehirler = new List<Sehir>()
            {
                new Sehir(6,"Ankara"),
                new Sehir(34,"İstanbul"),
                new Sehir(55,"Samsun"),
                new Sehir(23,"Elazığ"),
                new Sehir(44,"Malatya")
            };
            sehirler.Add(new Sehir(1, "Adana"));

            sehirler.Sort();
            sehirler.ForEach(s => Console.WriteLine(s));
        }
    }
}
