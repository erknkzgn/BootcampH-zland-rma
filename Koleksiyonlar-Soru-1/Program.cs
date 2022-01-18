using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            double toplam = 0;
            double gelenSayi;
            ArrayList prime = new ArrayList();
            ArrayList notPrime = new ArrayList();
            while (i > 0)
            {
                gelenSayi = getNumber();
                if (isPrime(gelenSayi))
                {
                    prime.Add(gelenSayi);
                }
                else
                {
                    notPrime.Add(gelenSayi);
                }
                i--;
            }
            prime.Sort();
            prime.Reverse();
            notPrime.Sort();
            notPrime.Reverse();
            Console.WriteLine("-*Prime*-");
            foreach (var item in prime)
            {
                toplam += int.Parse(item.ToString());
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Prime ortalama:" + toplam / prime.Count + "||PrimeCount:" + prime.Count);
            toplam = 0;
            Console.WriteLine("-*NotPrime*-");
            foreach (var item in notPrime)
            {
                toplam += int.Parse(item.ToString());
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("NotPrime ortalama:" + toplam / notPrime.Count + "||NotPrimeCount:" + notPrime.Count);
            Console.ReadLine();
        }
        public static bool isPrime(double sayi)
        {
            for (int a = 2; a < sayi; a++)
            {
                if (sayi % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int getNumber()
        {
            int a = -1;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz");
                a = getNumber();
            }

            return a;
        }
    }
}
