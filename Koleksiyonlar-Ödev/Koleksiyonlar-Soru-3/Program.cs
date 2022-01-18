using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in sesliHarfler(Console.ReadLine()))
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

        public static List<char> sesliHarfler(string str)
        {

            var sesli = "aeıioöuüAEIİOÖUÜ";
            List<char> arr = new List<char>();
            str.ToLower();
            int i = 0;
            
            foreach(var ch in str)
            {
                if(sesli.Contains(ch))
                {
                    arr.Add(ch);
                }
            }
            arr.Sort();
            return arr;
        }
    }
}
