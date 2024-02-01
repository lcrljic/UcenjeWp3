using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E04UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {
            int i = 2;

            switch (i)
            {
                case 0:
                    Console.WriteLine("DOBAR");
                    break;
                case 1:
                    Console.WriteLine("LOŠ");
                    break;
                case 2:
                    Console.WriteLine("ZAO");
                    break;
                default:
                    Console.WriteLine("Ostalo");
                    break;
            }

            Console.Write("Unesi ime grada: ");
            string Grad = Console.ReadLine();

            switch (Grad)
            {
                case "Osijek":
                case "Vukovar":
                    Console.WriteLine("Slavonija");
                    break;
                case "Split":
                case "Zadar":
                    Console.WriteLine("Dalmacija");
                    break;
            }
        }
    }
}
