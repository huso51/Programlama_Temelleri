using System;
using System.Collections;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class HashTableUygulamalari
    {
        public static void Temeller()
        {
            //HASHTABLE
            // Tanımlama
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-20}");
            }

            // Anahtarları alma 
            Console.WriteLine("\nAnahtarlar (Keys)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Değerler 
            Console.WriteLine("\nDeğerler (Values)");
            ICollection degerler = sehirler.Values;
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Elemana erişme
            Console.WriteLine("\nElemana erişme");
            Console.WriteLine(sehirler[34]);

            // Eleman silme 
            Console.WriteLine("\nEleman silme");
            sehirler.Remove(23);


            // Dolaşma
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"- {item.Value,-20}");
            }
        }
        public static void BaslikUretme()
        {
            // Hashtable uygulamasi

            // başlığı okuma
            Console.WriteLine("Başlık giriniz: ");
            string baslik = Console.ReadLine();

            // kucultme
            baslik = baslik.ToLower();

            // Hashtable
            var karakterSeti = new Hashtable()
            {
                {'ç','c'},
                {'ı','i'},
                {'ö','o'},
                {'ü','u'},
                {' ','-'},
                {'\'','-'},
                {'ğ','g'},
                {'.','-'},
                {'?','-'}
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }

            // Ekranda yazdir
            Console.WriteLine(baslik);
        }
    }
}


