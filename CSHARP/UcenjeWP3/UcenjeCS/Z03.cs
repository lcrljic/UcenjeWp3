using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z03
    {
        public static void Izvedi()
        {
            Console.Write("Unesi prvi broj: ");
            int Broj1 = int.Parse(Console.ReadLine());

            Console.Write("Unesi drugi broj: ");
            int Broj2 = int.Parse(Console.ReadLine());

            Console.Write("Unesi treći broj: ");
            int Broj3 = int.Parse(Console.ReadLine());

            if (Broj1 > Broj2 && Broj3 > Broj2)
            {
                Console.WriteLine(Broj2);
            }
            if (Broj2 > Broj1 && Broj3 > Broj1)
            {
                Console.WriteLine(Broj1);
            }
            if (Broj1 > Broj3 && Broj2 > Broj3)
            {
                Console.WriteLine(Broj3);
            }
        }
    }
}
