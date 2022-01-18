using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyolar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 19;
            double toplamMin = 0;
            double toplamMax = 0;
            double gelenSayi;
            double[] gelensayilar = new double[20];
            double[] min = new double[3];
            double[] max = new double[3];
            while (i >= 0)
            {
                Console.Write(20 - i + ".sayi:");
                gelenSayi = getNumber();
                gelensayilar[i] = gelenSayi;
                i--;
            }
            Array.Sort(gelensayilar);
            for(int a = 0; a<3; a++)
            {
                min[a] = gelensayilar[a];
                max[a] = gelensayilar[20 - (a + 1)];
                toplamMin += gelensayilar[a];
                toplamMax += gelensayilar[20 - (a + 1)];
            }
            Console.WriteLine("MinOrt: " + toplamMin / min.Count() + " Min count: " + min.Count());
            Console.WriteLine("-*min*-");
            foreach (var item in min)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("MaxOrt: " + toplamMax/max.Count() + "Max count: " + max.Count());
            Console.WriteLine("-*max*-");
            foreach (var item in max)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.WriteLine("MaxOrt: " + toplamMax / max.Count() + " MinOrt: " + toplamMin / min.Count() + " OrtToplam: "+ toplamMax / max.Count()+ toplamMin / min.Count());
            Console.ReadLine();
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
