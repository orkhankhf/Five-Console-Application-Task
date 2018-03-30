using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string daxilEdilen = Console.ReadLine();
            daxilEdilen += " ";
            string tersine = "";
            string sozuCevir = "";
            for(int a=0; a<daxilEdilen.Length; a++)
            {
                if (Convert.ToString(daxilEdilen[a]) != " ")
                {
                    sozuCevir += daxilEdilen[a];
                }
                else
                {
                    for (int b = sozuCevir.Length - 1; b >= 0; b--)
                    {
                        tersine += Convert.ToString(sozuCevir[b]);
                    }
                    tersine += " ";
                    sozuCevir = "";
                }
            }
            Console.WriteLine(tersine);
            
        }
    }
}
