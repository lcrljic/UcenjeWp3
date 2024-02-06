using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E06ForPetlja
    {
        public static void Izvedi()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Edunova " + i);
            }

            int[] Niz = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for(int i = 0;i < Niz.Length;i++)
            {
                Console.WriteLine(Niz[i]);
            }

            for (int i = 3; i < 43; i++)
            {
                if (i % 2 == 0) 
                {
                    Console.WriteLine(i);
                }
            }

            int Suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                Suma += i;
                
            }
            
            Console.WriteLine(Suma);

            for (int i = 78;i >= 4; i--)
            {
                Console.WriteLine(i);
            }

            for (int i=1;  i <= 100; i += 7)
            {
                Console.WriteLine(i);
            }

            for (int i=0; i < 21; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
