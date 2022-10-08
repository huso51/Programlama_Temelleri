using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class SortedSetUygulamalari
    {
        public static void BenzersizSayilar()
        {
            // SortedSet
            var sayilar = new List<int>();
            var r = new Random();

            Console.WriteLine();
            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5, 15));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanlari bulmak
            var benzersizSayiListesi =
                new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine();
            Console.WriteLine("\nBenzersiz {0} sayi var. ",
                benzersizSayiListesi.Count);
        }
        public static void SortedSetUygulamasi()
        {
            // SortedSet

            // Tanımlama
            var list = new SortedSet<string>();

            // Ekleme
            if (list.Add("Mehmet"))
            {
                Console.WriteLine("Mehmet eklendi.");
            }
            else
            {
                Console.WriteLine("Ekleme başarısız.");
            }

            Console.WriteLine("{0}",
                list.Add("Ahmet") == true ?
                "Ahmet eklendi." : "Ekleme başarısız.");

            list.Add("Sule");
            list.Add("Neslihan");
            list.Add("Fahrettin");
            list.Add("Fatih");

            list.Remove("Sule");
            list.RemoveWhere(deger => deger.StartsWith("F"));

            Console.WriteLine("\nİsimler Listesi\n");
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Eleman sayisi    :{0,3}", list.Count);
        }
        public static void SortedSetKumeUygulamalari()
        {
            // SortedSet Küme işlemeri 
            // var A = new SortedSet<int>() { 1, 2, 3, 4 };
            var A = new SortedSet<int>(RastgeleSayiUret(10000));
            // var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var B = new SortedSet<int>(RastgeleSayiUret(10000));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // Union

            // A.UnionWith(B);
            // A.IntersectWith(B);
            // A.ExceptWith(B);
            // A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("\n\n Kesisim disindaki elemanlar");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("\nToplam sayisi : {0}", A.Count);

            Console.WriteLine();
        }
        public static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
                list.Add(r.Next(0, 1000));
            return list;
        }
    }

    
}


