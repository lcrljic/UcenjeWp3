using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z01
    {
        public static void Izvedi()
        {
            Console.Write("Unesi cijeli broj: ");
            int Broj = int.Parse(Console.ReadLine());
            if (Broj%2==0)
            {
                Console.WriteLine("SUPER");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}
