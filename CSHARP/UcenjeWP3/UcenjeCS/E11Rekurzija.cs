using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Rekurzija
    {
        public static void Izvedi()
        {
            int Suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                Suma+=i;
            }
            Console.WriteLine(Suma);

            Console.WriteLine(Zbroji(100));
        }

        private static int Zbroji(int Broj)
        {
            if (Broj == 1)
            {
                return 1;
            }

            return Broj + Zbroji(Broj - 1);
        }
    }
}
