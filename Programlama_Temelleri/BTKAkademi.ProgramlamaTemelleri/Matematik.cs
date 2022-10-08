using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class Matematik
    {
        public List<int> Seri { get; set; }

        public Matematik(params int[] sayilar)
        {
            Seri = new List<int>();
            foreach (var sayi in sayilar)
                ElemanEkle(sayi);
        }

        /// <summary>
        /// Seriye eleman ekler
        /// </summary>
        /// <param name="sayi">Tek bir sayiyi ifade eder.</param>
        public void ElemanEkle(int sayi)
        {
            Seri.Add(sayi);
        }

        /// <summary>
        /// Seriye eleman ekler.
        /// </summary>
        /// <param name="sayilar">Bir diziyi temsil eder.</param>
        public void ElemanEkle(int[] sayilar)
        {
            Seri.AddRange(sayilar);
        }

        public void Yazdir()
        {
            Console.WriteLine();
            if (Seri != null)
                Seri.ForEach(s => Console.Write("{0,5}", s));
            else
                Console.WriteLine("\aSeri bos!");
            Console.WriteLine();
        }

        /// <summary>
        /// Serideki en buyuk elemani bulur.
        /// </summary>
        /// <returns>En buyuk elemani doner.</returns>
        public int EnBuyukDegeriGetir()
        {
            int eb = int.MinValue;
            foreach (var sayi in Seri)
                eb = Math.Max(eb, sayi);
            return eb;
        }

        public int EnKucukDegeriGetir()
        {
            return 0;
        }

        /// <summary>
        /// Serinin toplamını döner.
        /// </summary>
        /// <returns>Seri toplamini ifade eder.</returns>
        public int Toplam()
        {
            int t = 0;
            foreach (var sayi in Seri)
                t += sayi;
            return t;
        }

        public int TekSayilarinToplaminiGetir()
        {
            int t = 0;
            for (int i = 0; i < Seri.Count; i++)
            {
                if (Seri[i] % 2 == 1)
                    t += Seri[i];
            }
            return t;
        }

        public int CiftSayilarinToplaminiGetir()
        {
            int t = 0;
            for (int i = 0; i < Seri.Count; i++)
            {
                if (Seri[i] % 2 == 0)
                    t += Seri[i];
            }
            return t;
        }

        public double OrtalamayiGetir()
        {
            return (double)Toplam() / Seri.Count;
        }

    }


}


