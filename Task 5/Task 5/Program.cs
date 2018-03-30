using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni daxil edin:");
            string text = Console.ReadLine();
            
            text += " ";
            string soz = "";
            Console.WriteLine("Metnin daxilinde hansi soz evez edilecek?");
            string tap = Console.ReadLine();
            Console.WriteLine("Hansi soz ile evez edilecek?");
            string deyis = Console.ReadLine();
            string netice = "";
            for (int a = 0; a < text.Length; a++)
            {
                if (Convert.ToString(text[a]) != " ")
                {
                    soz += text[a];
                }
                else
                {
                    if(soz == tap)
                    {
                        soz = deyis;
                    }
                    netice += soz+" ";
                    soz = "";
                }
            }

            Console.WriteLine(netice);
        }
    }
}
