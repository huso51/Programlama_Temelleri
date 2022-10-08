using System;
using System.Collections.Generic;
using System.Text;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class StackUygulamalari
    {
        public static void YiginBasamakOrnegi()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            var sayiYigini = new Stack<int>();

            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;
            }

            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10, n - i),7}\t = " +
                    $"{s * Math.Pow(10, n - i),7}");
                i++;
            }
        }
        public static void KarakterYiginiOrnegi()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yığına eklendi.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }

            // Ek bilgi 
            var dizi = karakterYigini.ToArray();
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından çıkarıldı.");
                Console.WriteLine($"Yığındaki eleman sayisi : {karakterYigini.Count}");
            }
        }
        public static void YiginOrnegi()
        {
            // Stack tanımlama
            var karakterYigini = new Stack<char>();

            // Ekleme
            karakterYigini.Push('A');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('B');
            Console.WriteLine(karakterYigini.Peek());
            karakterYigini.Push('C');
            Console.WriteLine(karakterYigini.Peek());

            // Çıkarma
            Console.WriteLine(karakterYigini.Pop() + " yığında çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığında çıkartıldı.");
            Console.WriteLine(karakterYigini.Pop() + " yığında çıkartıldı.");
        }
    }
}
