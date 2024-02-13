using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E10Metode
    {
        public static void Izvedi()
        {
            //for (int i = 0; i < 100; i++)
            //{
                Tip1();
                Tip1();
            //}
            Tip2("Luka");
            Tip2("Luka", "Crljić");

            Tip3();

            Console.WriteLine(Tip3());

            Console.WriteLine(Tip4(2,77));
        }

        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koja nije primila parametre i ne vraća vrijednost");
        }

        static void Tip2(string ime)
        {
            Console.WriteLine("Dobar dan " + ime);
        }

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("Dobar dan " + ime + " " + prezime);
        }

        internal static int Tip3()
        {
            return '7';
        }
        /// <summary>
        /// Primjer metode koja prima dva parametra i vraća vrijednost
        /// </summary>
        /// <param name="odBroja">Prvi primljeni parametar od kojeg se kreće</param>
        /// <param name="doBroja">Drugi primljeni parametar do kojeg se kreće</param>
        /// <returns>Zbroj svakog drugog broja između dva primljena</returns>
        protected static int Tip4(int odBroja, int doBroja)
        {
            int Suma = 0;
            for (int i = odBroja; i <= doBroja; i += 2) 
            {
                Suma += i;
            }
            return Suma;
        }
    }
}
