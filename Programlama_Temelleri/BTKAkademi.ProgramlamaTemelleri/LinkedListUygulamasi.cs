using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class LinkedListUygulamasi
    {
        public static void Sehirler()
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");
            sehirler.AddLast("İstanbul");

            sehirler.AddAfter(sehirler.Find("Ordu"), "Samsun");
            sehirler.AddBefore(sehirler.First.Next.Next, "Giresun");
            sehirler.AddAfter(sehirler.Last.Previous, "Sinop");
            sehirler.AddAfter(sehirler.Find("Sinop"), "Zonguldak");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            Console.WriteLine();
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Dönüş Güzergahı");
            Console.WriteLine();

            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }

            Console.ReadKey();
        }
    }
}


