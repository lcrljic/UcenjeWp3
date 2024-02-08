using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z07
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi broj: ");
            int b= int.Parse(Console.ReadLine());
            bool prim = true;
            for(int i=2; i<b; i++)
            {
                if (b % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            Console.WriteLine(b + (prim ? " JE " : " NIJE ") + "prim broj");
        }
    }
}
