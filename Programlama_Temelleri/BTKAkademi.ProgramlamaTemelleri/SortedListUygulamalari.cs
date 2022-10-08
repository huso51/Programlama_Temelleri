using System;
using System.Collections;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class SortedListUygulamalari
    {
        public static void Temeller()
        {
            // SortedList - Temeller 
            // Tanımlama
            var list = new SortedList()
            {
                {1,"Bir"},
                {2,"İki"},
                {3,"Üç"},
                {8,"Sekiz"},
                {5,"Beş"},
                {6,"Altı"}
            };

            list.Add(4, "Dört");


            // Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("Listedeki eleman sayısı  : {0}", list.Count);
            Console.WriteLine("Listenin kapasitesi      : {0}", list.Capacity);
            list.TrimToSize();
            Console.WriteLine("Listenin kapasitesi      : {0}", list.Capacity);

            // Erişme
            // Key
            Console.WriteLine(list[4]);
            // Index
            Console.WriteLine(list.GetByIndex(0));
            // Get -> Key
            Console.WriteLine(list.GetKey(0));
            // Liste sonundaki elemanın değeri 
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\nANAHTARLAR");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            Console.WriteLine("\nDEGERLER");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGuncelleme");
            if (list.ContainsKey(1))
            {
                list[1] = "One";
            }

            // Dolaşma
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
        public static void KitapIcerigiOrnegi()
        {
            // SortedList
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Değişkenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "İlişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine(new string('-', 25));

            Console.WriteLine($"{"Konular",-33} {"Sayfalar",8}");
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,8}");
            }
        }

    }
}


