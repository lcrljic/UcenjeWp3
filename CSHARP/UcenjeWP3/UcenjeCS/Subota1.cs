﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Subota1
    {
        public static void Izvedi()
        {

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(DateTimeOffset.Now.ToUnixTimeMilliseconds());
            //    Console.WriteLine("\a");
            //    Thread.Sleep(1000);
            //}

            //int t = 2147483647;
            //long l = t+1;
            //l = 2147483648;
            //Console.WriteLine(l);
            //t = (int)l;
            //Console.WriteLine(t);

            //Console.Write("Unesi cijeli broj: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Unesi cijeli broj: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Unesi cijeli broj: ");
            //int c = int.Parse(Console.ReadLine());
            //Console.Write(a + " " + b + " " + c);

            //Console.Write("Unesi ime grada: ");
            //string a = Console.ReadLine();
            //Console.Write("Unesi ime grada: ");
            //string b = Console.ReadLine();
            //Console.Write("Unesi ime grada: ");
            //string c = Console.ReadLine();
            //if (a[0] == 'o' && b[0] == 'o' && c[0] == 'o') 
            //{
            //    Console.WriteLine("SUPER");
            //}
            //else
            //{
            //    Console.WriteLine("OK");
            //}

            //string[] Gradovi = new string[3];
            //for(int i = 0; i < Gradovi.Length; i++)
            //{
            //    Console.WriteLine("Unesi ime "+(i+1)+". grada");
            //    Gradovi[i] = Console.ReadLine();
            //}
            //bool Pocinju = true;
            //foreach(string Grad in Gradovi)
            //{
            //    if (Grad[0] != 'o')
            //    {
            //        Pocinju = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(Pocinju ? "SUPER" : "OK");

            //string Grad;
            //bool Pocinje = true;
            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.WriteLine("Unesi ime "+(i+1)+". grada: ");
            //    Grad = Console.ReadLine();
            //    if (Grad[0] != 'o')
            //    {
            //        Pocinje = false;
            //        break;
            //    }
            //}
            //Console.WriteLine(Pocinje ? "SUPER" : "OK");
            int a;

            while (true)
            {
                Console.WriteLine("Unesi opciju:\n1 - KN u EUR\n2 - EUR u KN");
                //a = int.Parse(Console.ReadLine());
                string unos = Console.ReadLine();
                if (int.TryParse(unos, out a) && (a == 1 || a == 2))
                {
                    break;
                }
                Console.WriteLine("Neispravna opcija");
            }
            while (true)
            {
                double b = 0;
                if (a == 1)
                {
                    Console.WriteLine("Unesi koliko kuna pretvaraš u eure: ");
                }
                else
                {
                    Console.WriteLine("Unesi koliko eura pretvaraš u kune: ");
                }

                string unos = Console.ReadLine();
                bool provjeraJeliBroj = double.TryParse(unos, out b);
                if (provjeraJeliBroj && b >= 0)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Iznos unesenih kuna u eurima: " + b / 7.53450);
                    }
                    else // tj ako je a == 2
                    {
                        Console.WriteLine("Iznos unesenih eura u kunama: " + b * 7.53450);
                    }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Krivi unos");
                    }
                }

                //int i = int.Parse(Console.ReadLine());

                //Console.ForegroundColor = ConsoleColor.Red;
                //Console.WriteLine("EDUNOVA");
                //Console.ResetColor();
            }
        
    }
}
