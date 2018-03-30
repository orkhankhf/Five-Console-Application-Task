using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Yeni sifre yaradilsin? (he / yox)");
                string cavab = Console.ReadLine();
                if (cavab == "he" || cavab == "He")
                {
                    var sifre = new sifre();
                    Console.WriteLine(sifre.SifreYarat());
                }
                else
                {
                    break;
                }
            }

        }
    }
    class sifre
    {
        public static string SifreYarat()
        {
            string pass = "";
            Random rnd = new Random();
            string herfler = "abcdefghijklmnopqrstuvwxyz";
            string xususiXarakter = @"!@#$%^&*()_+-=,./;'\[]<>?:P{}" + '"';

            int herfIndex = rnd.Next(0, 25);
            pass += herfler[herfIndex].ToString();

            int RandomReqem = rnd.Next(0, 9);
            pass += RandomReqem;

            herfIndex = rnd.Next(0, 25);
            pass += herfler[herfIndex].ToString().ToUpper();
            
            int xususiXarakterIndex = rnd.Next(0, 29);
            pass += xususiXarakter[xususiXarakterIndex].ToString();

            RandomReqem = rnd.Next(0, 9);
            pass += RandomReqem;

            herfIndex = rnd.Next(0, 25);
            pass += herfler[herfIndex].ToString();

            xususiXarakterIndex = rnd.Next(0, 29);
            pass += xususiXarakter[xususiXarakterIndex].ToString();

            RandomReqem = rnd.Next(0, 9);
            pass += RandomReqem;

            return pass;
        }
    }
}
