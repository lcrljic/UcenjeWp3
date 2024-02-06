using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E05Nizovi
    {
        public static void Izvedi()
        {
            int[] Temperature = new int[6];
            Temperature[0] = 1;
            Temperature[Temperature.Length - 1] = 2;

            Console.WriteLine(Temperature);
            Console.WriteLine(string.Join(",", Temperature));

            string[] Gradovi = new string[3];
            Gradovi[0] = "Osijek";
            Gradovi[1] = "Zagreb";
            Gradovi[2] = "Donji Miholjac";

            Console.WriteLine(string.Join(" ", Gradovi));

            int[] Brojevi = { 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(Brojevi[4]);
            Console.WriteLine(Brojevi[0]);
            Console.WriteLine(Brojevi[Brojevi.Length - 1]);

            int[,] Tablica =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            Console.WriteLine(Tablica[1, 2]);

            int[,,] Kocka = new int[10, 10, 10];

            int[,,,,,] ZvjezdaneStaze;

            string Grad = "Osijek";

            Console.WriteLine(Grad[3]);

            char Znak = 'j';

            Console.WriteLine(Znak);

            Console.WriteLine((int)Znak);

            int[] Niz = { 1, 2, 3, 4, 5 };

            Console.WriteLine(Niz[0]);
            Console.WriteLine(Niz[1]);
            Console.WriteLine(Niz[2]);
            Console.WriteLine(Niz[3]);
            Console.WriteLine(Niz[4]);

            int i = 0;
            i++;
        }
    }
}
