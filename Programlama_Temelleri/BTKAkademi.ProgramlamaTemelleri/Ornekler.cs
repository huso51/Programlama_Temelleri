using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BTKAkademi.ProgramlamaTemelleri
{

    class Ornekler
    {

        private static void ListeUygulamasiSehirler()
        {
            var sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Van",
                "Samsun",
                "Ordu"
            };

            // Lambda expression =>
            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-', 50));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            sehirler.Add("Sinop");
            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));

            iller.Remove("Ankara");
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();
            sehirler.ForEach(s => Console.WriteLine(s));
        }

        private static void DegerVeReferansTipler()
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("{0},{1}", x, y);
            Degistir(ref x, ref y);
            Console.WriteLine("{0},{1}", x, y);
        }

        private static void Degistir(ref int a, ref int b)
        {
            int gecici = a;
            a = b;
            b = gecici;
            Console.WriteLine("{0},{1}", a, b);
        }

        /// <summary>
        /// Satış yapan yapan fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar = 0)
        {
            return miktar * 1.18;
        }
        /// <summary>
        /// Satış yapan yapan fonksiyon.
        /// </summary>
        /// <param name="miktar">Alış-veriş tutarı.</param>
        /// <param name="indirim">İndirim oranı</param>
        /// <returns>KDV eklenmiş toplam ödenecek miktar.</returns>
        static double SatisYap(double miktar, double indirim)
        {
            return ( miktar * ( 1.0 - indirim ) ) * 1.18;
        }
        private static void MetotTasarimi()
        {
            /*
                        int buyuk = Karsilastir(13,5);
                        Console.WriteLine(buyuk);
                        */

            // var x = KareAl(3);
            // double y = KareAl(x);
            // Console.WriteLine(x);
            // Console.WriteLine(y);


            Console.WriteLine("{0,5:0.##}",
                SeriToplami(5.52, 15.12, 25.54, 13.13));
        }
        private static double SeriToplami(params double[] seri)
        {
            double toplam = 0;
            foreach (double s in seri)
                toplam += s;
            return toplam;
        }
        public static int Karsilastir(int A, int B)
        {
            return A > B ? A : B;
        }
        static double KareAl(double sayi)
        {
            double kare = sayi * sayi;
            return kare;
        }
        private static void ListeOrnegi()
        {
            // Tanımlama - Atama
            var sayilar = new List<int>() { 10, 15, 20 };

            int x = 55;
            // int[] Seri = new int[] { 70, 80, 90 };
            // Ekleme

            sayilar.Add(x);
            sayilar.AddRange(new int[] { 40, 50, 60 });

            // Araya ekleme
            sayilar.Insert(3, 0);
            sayilar.InsertRange(4, new int[] { 80, 90 });


            sayilar.RemoveAt(3);
            sayilar.RemoveAt(sayilar.IndexOf(55));

            // Dolaşma
            foreach (int s in sayilar)
            {
                Console.Write($"{s,-5}");
            }
        }
        private static void CokboyutluDiziOrnegi()
        {
            double[,] matris = new double[,]
            {
                { 1, 2, 3, 3 },
                { 2, 3, 4, 5},
                { 3, 4, 5, 8 },
                { 4, 5, 6, 10 }
            };

            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                        matris[i, j] = -1;

                    if (matris[i, j] % 2 == 0)
                        matris[i, j] = 0;

                    toplam += matris[i, j];

                    Console.Write($"{matris[i, j],5}");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Toplam: {toplam}");
        }
        private static void DiziOrnegi3()
        {
            Console.WriteLine("Dizi boyutunu giriniz: ");
            int boyut = Convert.ToInt32(Console.ReadLine());
            int[] sayilar = new int[boyut];

            var r = new Random();

            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 10);

            foreach (var s in sayilar)
            {
                Console.WriteLine($"{s,5} {s * s,5}");
            }
        }
        private static void DiziOrnegi2()
        {
            Console.WriteLine("Dizi boyutu giriniz: ");
            int boyut = int.Parse(Console.ReadLine());

            var r = new Random();
            int[] sayilar = new int[boyut];
            for (int i = 0; i < sayilar.Length; i++)
                sayilar[i] = r.Next(1, 9);

            foreach (var item in sayilar)
            {
                Console.WriteLine($"{item,5} {item * item,5}");
            }
        }
        private static void DiziOrnegi()
        {
            // tanımlama & başlatma & atama
            int[] numaralar = { 3, 5, 7, 8, 10 };

            for (int i = 0; i < numaralar.Length; i++)
            {
                Console.WriteLine($"Numalaralar[{i}] = " +
                    $"{numaralar[i]}");
            }
        }
        private static void KarakterOrnegi()
        {
            int karakterKodu = 65;
            char[] x = new char[29];
            for (int i = 0; i < 26; i++)
            {
                x[i] = (char)karakterKodu;
                Console.Write("{0,-5}", x[i]);
                karakterKodu++;
            }
        }
        private static void CevrimlerForDongusu()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
        private static void DoWhileDonguOrnegi()
        {
            Console.WriteLine("Bir sayi giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            do
            {
                Console.Write("{0,3}", i);
                i += 2; // i = i + 2
            } while (i < n);
        }
        private static void DonguOrnegi()
        {
            int sayac = 10;
            while (sayac > 0)
            {
                Console.WriteLine("{0,-3} {1,-3}", sayac, sayac * sayac);
                sayac -= 1; // sayac = sayac -1
            }
        }
        private static void DonguCevrim1()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("Döngü sonu.");
        }
        enum Islemler
        {
            Toplama = 1,
            Cikarma = 2,
            Carpma = 3,
            Bolme = 4
        }
        private static void switchCaseOrnegi()
        {
            int A = 10;
            int B = 20;
            Islemler secim = (Islemler)( new Random().Next(1, 4) );

            switch (secim)
            {
                case Islemler.Toplama:
                    Console.WriteLine($"{A} + {B} = {A + B}");
                    break;
                case Islemler.Cikarma:
                    Console.WriteLine($"{A} - {B} = {A - B}");
                    break;
                case Islemler.Carpma:
                    Console.WriteLine($"{A} * {B} = {A * B}");
                    break;
                case Islemler.Bolme:
                    Console.WriteLine($"{A} / {B} = {A / B}");
                    break;
                default:
                    Console.WriteLine("\aGeçersiz işlem!");
                    break;
            }
        }
        private static void KarakterUygulamsi()
        {
            var k = (char)Console.Read();
            if (char.IsDigit(k))
            {
                Console.WriteLine("Rakamdır!");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("Kucuk karakter.");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine("Buyuk karakter.");
            }
            else
            {
                Console.WriteLine("Bilinmeyen karakter.");
            }


            Console.WriteLine(k);
        }
        private static void MutlakDegerOrnegi()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine($"|{n}| = {n * -1}");
            }
            else
            {
                Console.WriteLine($"|{n}| = {n}");
            }
        }
        private static void TekMiCiftMiOrnegi()
        {
            // tek / çift 
            Console.WriteLine("Bir sayi giriniz: ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi % 2 == 0)
            {
                Console.WriteLine($"{sayi} çift bir sayıdır.");
            }
            else
            {
                Console.WriteLine($"{sayi} tek bir sayıdır.");
            }
        }
        private static void OperatorUygulamasi()
        {
            int A = 20, B = 10;

            // Aritmetik operatörler

            Console.WriteLine(A + B);
            Console.WriteLine(A - B);
            Console.WriteLine(A * B);
            Console.WriteLine(A / B);
            Console.WriteLine(A % B);

            // İlişkisel operatörler
            Console.WriteLine(A > B);
            Console.WriteLine(A < B);
            Console.WriteLine(A >= B);
            Console.WriteLine(A <= B);
            Console.WriteLine(A == B);
            Console.WriteLine(A != B);

            Console.WriteLine(!( A > B && A < 5 ));
            Console.WriteLine(A < B || B > 5);
        }
        private static void DizeDegismezleriOrnegi()
        {
            var ifade = " Merhaba programlama dünyası. ";
            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade[0]);
            Console.WriteLine(ifade[1]);
            Console.WriteLine(ifade[ifade.Length - 1]);
        }
        private static void OrtuluDegiskenTanimi()
        {
            // örtülü değişken
            var ifade = Console.ReadKey();
            Console.WriteLine(ifade.Key);
            Console.WriteLine(ifade.KeyChar);
        }
        private static void KarakterSabitleri()
        {
            // Kullanıcıdan bilgi alma.
            // string ifade = Console.ReadLine();
            string ifade = @"C:\users\btkakademi";
            Console.WriteLine(ifade);
            Console.ReadKey();
        }
        private static void EscapeIfadeleri()
        {
            // ESCAPE
            // \n   : yeni satir 
            // \t   : tab
            // \a   : uyarı
            string mesaj = "Mutlu\nyıllar\narkadaşlar.\n";
            string mesaj2 = "Mutlu\tyıllar\tarkadaşlar.\t";
            string mesaj3 = "\aDikkat!";

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj2);
            Console.WriteLine(mesaj3);
        }
        // Basit degisken ornegi
        private static void BasitDegiskenOrnegi()
        {
            int sayi = 3;
            Console.WriteLine(sayi);
            Console.WriteLine(sayi + 2);    // 3 + 2 = 5
            Console.WriteLine(sayi * sayi); /* Karesi */
            Console.WriteLine(sayi - 5);
        }
        private static void DegisenBasitOrnek()
        {
            // Tip ... 
            string isim = "Ahmet";
            Console.WriteLine("Merhaba " + isim + ".");
            isim = "Mehmet";
            Console.WriteLine("Merhaba Sayın " + isim + ".");
        }
        private static void foreachDonguOrnegi()
        {
            var sayiListesi = new List<int> { 5, 23, 55, 61, 19 };
            int sayac = 0;
            foreach (int sayi in sayiListesi)
            {
                sayac++;
                Console.WriteLine($"Eleman ({sayac}) : {sayi,5}");
            }
            Console.WriteLine($"Toplam eleman sayisi: {sayac}");
            Console.ReadKey();
        }
        private static void MatematikUygulamasi()
        {
            int[] sayiDizisi = { 23, 55, 44 };
            Matematik mat = new Matematik(3, 5, 7, 10);
            mat.ElemanEkle(5);
            mat.ElemanEkle(15);
            mat.ElemanEkle(sayiDizisi);

            mat.Yazdir();
            Console.WriteLine($"En buyuk eleman: {mat.EnBuyukDegeriGetir()}");
            Console.WriteLine($"En kucuk eleman: {mat.EnKucukDegeriGetir()}");
            Console.WriteLine($"Seri toplami : {mat.Toplam()}");
            Console.WriteLine($"Tek sayilarin toplami: {mat.TekSayilarinToplaminiGetir()}");
            Console.WriteLine($"Cift sayilarin toplami: {mat.CiftSayilarinToplaminiGetir()}");
            Console.WriteLine("Ortalama : {0:N1}", mat.OrtalamayiGetir());
            Console.ReadKey();
        }
        public static double CemberinCevresi(double r,
            double pi = 3.14159)
        {
            return 2 * pi * r;
        }
        public int Toplam(params int[] liste)
        {
            int t = 0;
            foreach (var sayi in liste)
                t += sayi;
            return t;
        }
        public void DegerGetir(out int x)
        {
            int temp = 55;
            x = temp;
        }
        public void Degistir(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        public static void Swap(ref int x, ref int y)
        {
            x = x * y;
            y = y * x;
        }
        public int Faktoriyel(int n)
        {
            int f;
            if (n == 1)
                return 1;
            else
            {
                f = Faktoriyel(n - 1) * n;
                return f;
            }
        }
        /// <summary>
        /// Parametre olarak aldığı sayılardan büyük olanı 
        /// geriye döner. 
        /// </summary>
        /// <param name="sayi1"></param>
        /// <param name="sayi2"></param>
        /// <returns>Maksimum sayı</returns>
        public static int MaksimumuBul(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1 > sayi2)
                sonuc = sayi1;
            else
                sonuc = sayi2;
            return sonuc;
        }
        private static void ListedenElemanKaldirma()
        {
            List<int> asalSayilar = new List<int>()
            {
                2,3,5,7,20
            };
            asalSayilar.Remove(20); // kaldir
            asalSayilar.ForEach(s => Console.WriteLine(s));
        }
        private static void ListelereErisme()
        {
            List<double> sayilar = new List<double>()
            {
                2.12,3.21, 4.31, 5.13, 1.11
            };
            Console.WriteLine(sayilar[0]);
            Console.WriteLine(sayilar[4]);
            sayilar.ForEach(s => Console.WriteLine(s));
        }
        private static void DoguIlleri()
        {
            string[] doguSehirleri = { "Malatya", "Elazig",
            "Bingol","Muş","Bitlis"};

            var doguIlleri = new List<string>();
            doguIlleri.AddRange(doguSehirleri);

            foreach (var sehir in doguIlleri)
                Console.WriteLine(sehir);
        }
        private static void ListeOlusturma()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(new Random().Next(1, 9));
                Console.WriteLine(sayilar[i]);
            }

            var sehirler = new List<string>();
            sehirler.Add("Sinop");
            sehirler.Add("Zonguldak");
            sehirler.Add("Corum");
            sehirler.Add("Elazig");
            sehirler.Add(null); // null degerlerde kabul edilir. 

            var buyukSehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "Samsun"
            };
        }
        private static void MatrisTanimlamaProgrami()
        {
            int[,] A = new int[,] {
                { 1, 2, 3, 4 },
                { 4, 5, 6, 7 },
                { 7, 8, 9, 1 }
            };
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write("{0,3}", A[i, j]);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        private static void MatrisOlusturmaProgrami()
        {
            // m*n boyutunda bir matris olusturma
            int m, n;
            Console.WriteLine("m boyutu: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("n boyutu:");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] A = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = new Random().Next(0, 9);
                    Console.Write("{0,5}", A[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public enum Olcek
        {
            KesinlikleKatiliyorum = 5,
            Katiliyorum = 4,
            Kararsizim = 3,
            Katilmiyorum = 2,
            KesinlikleKatilmiyorum = 1
        }
        private static void switchCaseveEnum()
        {
            Olcek secim = Olcek.KesinlikleKatilmiyorum;
            switch (secim)
            {
                case Olcek.KesinlikleKatiliyorum:
                    Console.WriteLine("{0} ({1})", secim,
                        (int)secim);
                    break;
                case Olcek.Katiliyorum:
                    Console.WriteLine("{0} ({1})", secim,
                        (int)secim);
                    break;
                case Olcek.Kararsizim:
                    Console.WriteLine("{0} ({1})", secim,
                        (int)secim);
                    break;
                case Olcek.Katilmiyorum:
                    Console.WriteLine("{0} ({1})", secim,
                        (int)secim);
                    break;
                case Olcek.KesinlikleKatilmiyorum:
                    Console.WriteLine("{0} ({1})", secim,
                        (int)secim);
                    break;
                default:
                    break;
            }
        }
        private static void KucukHesapMakinesi()
        {
            int sayi1, sayi2;

            Console.WriteLine("1. sayiyi giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayiyi giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. Topla");
            Console.WriteLine("2. Carp");
            Console.WriteLine("3. Böl");
            Console.WriteLine("4. Cikar");

            char secim = (char)Console.Read();

            switch (secim)
            {
                case '1':
                    Console.WriteLine("{0} + {1} = {2}",
                        sayi1, sayi2, sayi1 + sayi2);
                    break;
                case '2':
                    Console.WriteLine("{0} * {1} = {2}", sayi1,
                        sayi2, sayi1 * sayi2);
                    break;
                case '3':
                    Console.WriteLine("{0} / {1} = {2}",
                        sayi1, sayi2, sayi1 / sayi2);
                    break;
                case '4':
                    Console.WriteLine("{0} - {1} = {2}",
                        sayi1, sayi2, sayi1 - sayi2);
                    break;
                default:
                    Console.WriteLine("\aGecersiz secim!");
                    break;
            }
        }
        private static void OgrencininNotu()
        {
            Console.WriteLine("Ogrencinin notu: [1-5]");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Basarisiz!");
                    break;
                case 2:
                    Console.WriteLine("Gecer.");
                    break;
                case 3:
                    Console.WriteLine("Orta");
                    break;
                case 4:
                    Console.WriteLine("İyi");
                    break;
                case 5:
                    Console.WriteLine("Pekiyi");
                    break;
                default:
                    Console.WriteLine("\aGecersiz giris!");
                    break;
            }
        }
        private static void KarakterTanima()
        {
            // Karakter tanima
            Console.WriteLine("Lutfen bir karakter giriniz:");
            char k = (char)Console.Read(); // cast

            if (char.IsLower(k))
            {
                Console.WriteLine($"{k} kucuk bir karakterdir.");
            }
            else if (char.IsUpper(k))
            {
                Console.WriteLine($"{k} buyuk bir karakterdir.");
            }
            else if (char.IsDigit(k))
            {
                Console.WriteLine($"{k} bir rakamdir.");
            }
            else
            {
                Console.WriteLine($"\a{k} tanimlanamadi.");
            }
        }
        private static void MutlakDeger()
        {
            // mutlak deger

            Console.WriteLine("Bir sayi giriniz:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("|{0}| = {1}",
                n, n < 0 ? n * ( -1 ) : n);

        }
        private static void TekMiCiftMi()
        {
            // tek mi cift mi?
            int n = Convert.ToInt32(Console.ReadLine());

            // koşul ifadesi
            if (n % 2 == 0)
            {
                Console.WriteLine("{0} cift sayidir.", n);
            }
            else
            {
                Console.WriteLine("{0} tek sayidir.", n);
            }
        }
        private static void DaireninAlani()
        {
            const double pi = 3.14159;
            double r;
            Console.WriteLine("Yaricap giriniz: ");
            r = Convert.ToDouble(Console.ReadLine());
            double alan = pi * r * r;
            Console.WriteLine($"Yaricap : {r,5} " +
                $"Alan: {alan,5}");
        }
        private static void DizeDegismezleri()
        {
            // Dize değişmezleri
            string ifade = " Programlama öğreniyorum. ";
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade[1]);
            Console.WriteLine($"{ifade[1]} {ifade[2]} " +
                $"{ifade[3]}");
            Console.WriteLine(ifade.Length);
        }
        private static void Degiskenler02()
        {
            string path = "C:\\users\\zafer";
            Console.WriteLine($"\n\n Sistem yolu : {path} \n\n");

            string path2 = @"C:\users\zafer";
            Console.WriteLine($"Sistem yolu : {path2}");

            Console.WriteLine("\\");
            Console.WriteLine("\'");

            Console.WriteLine(@"\");
            Console.WriteLine(@"'");
        }
        private static void Degiskenler01()
        {
            #region DegiskenTanimlama
            // Degiskenlerin tanimlanmasi
            int a, b, c;
            char x, y, z1;
            float f1;
            double d1;
            #endregion

            #region Degisken Baslatma
            // Degiskenlerin baslatilmasi 
            int d = 3, f = 5;
            byte z = 23;
            double pi = 3.14159;
            char k = 'e';
            string isim = "BTK Akademi";
            #endregion

            #region Kullanicidan deger kabul etme

            // Kullanicidan deger kabul etme

            int num;


            num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Girilen deger: {num}");



            #endregion
        }
        private static void ArrayList()
        {
            // Tanımlama
            var arrayList = new ArrayList() {
                10,"BTK Akademi", true,'e'
            };

            // Ekleme
            /*
            arrayList.Add(10); //boxing 
            arrayList.Add("BTK Akademi");
            arrayList.Add(true);
            arrayList.Add('e');
            */

            // Dolaşma
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }

            int[] sayilar = new int[] { 23, 44, 55 };
            arrayList.AddRange(sayilar);

            // Dolaşma
            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();

            // Elemana erişme
            Console.WriteLine(arrayList[4]);

            // Elemana erişme - atama
            var x = (int)arrayList[0]; // kutudan çıkarma
            Console.WriteLine(x + 10);

            // Eleman silme
            //arrayList.Remove(10);
            // arrayList.RemoveAt(1);
            arrayList.RemoveRange(3, 3);
            // Dolaşma
            Console.WriteLine();
            foreach (var e in arrayList)
            {
                Console.Write($"{e} ");
            }
        }
    }

}
