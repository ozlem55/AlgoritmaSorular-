using System;

namespace AlgoritmaSoruları
{
    class Program
    {
        static void Main(string[] args)
        {
            İşlemler instance = new İşlemler();
            //instance.Soru_1();
            //instance.Soru_2();
            //instance.Soru_3();
            instance.Soru_4();
        }

    }
    public class İşlemler
    {
        public void Soru_1()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz!");
            int n= int.Parse(Console.ReadLine());
            int a = 0;
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz!");
                a = int.Parse(Console.ReadLine());
                dizi[i] = a;
            }
            Console.WriteLine("Girilen çift sayılar!");
            foreach (var item in dizi)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Soru_2()
        {
            Console.WriteLine("Lütfen 1. sayıyı giriniz!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. sayıyı giriniz!");
            int m = int.Parse(Console.ReadLine());
            int a = 0;
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen sayı giriniz!");
                a = int.Parse(Console.ReadLine());
                dizi[i] = a;
            }
            foreach (var item in dizi)
            {
                if(item==m || item % m == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Soru_3()
        {
            Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
            int n = int.Parse(Console.ReadLine());
            string m;
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen kelime giriniz ");
                m = Console.ReadLine();
                kelimeler[i] = m;
            }
            Console.WriteLine("Girilen kelimeler sondan başa doğru");
            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
            }
        }
        public void Soru_4()
        {
            Console.WriteLine("Lüften bir cümle yazınız : ");
            string m = Console.ReadLine();
            string[] kelimeler = m.Split(" ");
            int sayi = 0;
            Console.WriteLine("Toplam kelime sayısı :" + kelimeler.Length);
            for (int i = 0; i < kelimeler.Length; i++)
            {
                char[] harfler = kelimeler[i].ToCharArray();
                sayi += harfler.Length;
            }
            Console.WriteLine("Toplam harf sayısı :" + sayi);
        }
    }
}
