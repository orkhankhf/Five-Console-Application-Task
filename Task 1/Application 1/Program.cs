using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Userin daxil etdiyi reqemi daxilEdilen adli deyisene ver
            string daxilEdilen = Console.ReadLine();
            string toplananDeyerler = "";
            //cem deyisenini teyin et ve deyeri 0 olsun;
            int cem = 0;
            //userin daxil etdiyi reqem string oldugu ucun onun uzunlugu qeder foru donder
            for (int a=0; a < daxilEdilen.Length; a++)
            {
                //daxilEdilen deyisenin a indexinin typi char oldugu ucun once stringe,
                //sonra integere convert et ve cem deyisenine topla
                cem += Convert.ToInt32(Convert.ToString(daxilEdilen[a]));
                toplananDeyerler += Convert.ToInt32(Convert.ToString(daxilEdilen[a]));
                if (a != daxilEdilen.Length - 1)
                {
                    toplananDeyerler += " + ";
                }
                else
                {
                    toplananDeyerler += " = " + cem;
                }
            }
            //atomu parcala :)
            Console.WriteLine(toplananDeyerler);
        }
    }
}
