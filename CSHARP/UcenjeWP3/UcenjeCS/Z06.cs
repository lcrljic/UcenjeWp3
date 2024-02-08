using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z06
    {
        public static void Izvedi()
        {
            int i, Najmanji = int.MaxValue;
            for (; ; )
            {
                Console.Write("Unesi broj: ");
                i = int.Parse(Console.ReadLine());
                if(i == -1)
                {
                    break;
                }
                if (i < Najmanji) 
                {
                    Najmanji = i;
                }
            }
            Console.WriteLine(Najmanji);
        }
    }
}
