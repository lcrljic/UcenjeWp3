using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z09
    {
        public static void Izvedi()
        {
            string ime = Pomocno.UcitajString("Unesi svoje ime");
            float visina = Pomocno.UcitajDecimalniBroj("Unesi svoju visinu u cm");
            float tezina = Pomocno.UcitajDecimalniBroj("Unesi svoju težinu u kg");
            if (visina >= 170 && visina <= 190 && tezina < 90.5)  
            {
                if (ime.Length > 0 && ime[ime.Length - 1] == 'a' || ime[ime.Length - 1] == 'A')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ti, "+ime+", si zgodna");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ti, " + ime + ", si zgodan");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("OK");
                Console.ResetColor();
            }
        }
    }
}
