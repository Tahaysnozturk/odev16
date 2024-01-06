using System;

namespace or214
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a;
            string s = "";
            string[] Birler = { "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlar = { "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzler = { "", "Yüz", "İkiYüz", "ÜçYüz", "DörtYüz", "BeşYüz", "AltıYüz", "YediYüz", "SekizYüz", "DokuzYüz" };

            Console.Write("Bir Sayı Giriniz (1-999): ");
            a = int.Parse(Console.ReadLine());

            if (a >= 1 && a <= 999)
            {
                if (a / 100 > 0)
                {
                    s = Yuzler[a / 100];
                    a %= 100;
                }

                if (a / 10 > 0)
                {
                    s += Onlar[a / 10 - 1];
                    a %= 10;
                }

                if (a > 0)
                {
                    s += Birler[a - 1];
                }

                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Geçersiz giriş!");
            }

            Console.Write("Devam etmek için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
