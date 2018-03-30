using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("19 xanalı reqem daxil edin: ");
            long daxilEdilen = Convert.ToInt64(Console.ReadLine());
            long[] reqemler = new long[]{1000000000000000, 1000000000000 , 1000000000 , 1000000 , 1000 , 100 , 10 , 1};
            string[] sozler = new string[] {"Katrilyon", "Trilyon", "Milyard", "Milyon", "Min", "Yuz", "On", "Bir" };
       
            for(int a = 0; a < reqemler.Length; a++)
            {
                if (daxilEdilen / reqemler[a] != 0)
                {
                    Console.WriteLine(daxilEdilen / reqemler[a] + " eded " + reqemler[a] + " ("+ sozler[a] + ");");
                    daxilEdilen = daxilEdilen - (daxilEdilen / reqemler[a] * reqemler[a]);
                }
            }
        }
    }
}
