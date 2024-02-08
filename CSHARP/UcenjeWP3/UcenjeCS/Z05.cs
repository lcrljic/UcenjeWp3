using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z05
    {
        public static void Izvedi()
        {
            Console.Write("Unesi do kojeg broja želiš zbrajati: ");
            int Broj = int.Parse(Console.ReadLine());
            int Suma = 0;
            for (int i = 1; i <= Broj; i++)
            {
                Suma += i;
            }
            Console.WriteLine(Suma);
        }
    }
}
