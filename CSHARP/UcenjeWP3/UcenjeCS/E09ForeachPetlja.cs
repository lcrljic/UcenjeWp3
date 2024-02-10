using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E09ForeachPetlja
    {
        public static void Izvedi()
        {
            string Grad = "Osijek";

            for (int i = 0; i < Grad.Length; i++)
            {
                Console.WriteLine(Grad[i]);
            }

            foreach (var c in Grad)
            {
                Console.WriteLine(c);
            }

            for (int i = Grad.Length - 1; i >= 0; i--)
            {
                Console.Write(Grad[i]);
            }

            int[] Niz = new int[] { 2, 3, 4, 5, 6, 76, 78 };

            foreach (var i in Niz)
            {
                Console.WriteLine(i);
            }
        }
    }
}
