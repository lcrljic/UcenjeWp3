using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14VjezbanjeRadaSObjektima
{
    internal class Program
    {

        private List<Osoba> Osobe;

        /// <summary>
        /// Kreirati apk koja unosi, pregledava, mijenja i briše osobe
        /// </summary>
        public Program() 
        {
            // Konstruktor služi da bi konstruirao potrebne zavisnosti
            Osobe = new List<Osoba>();

            TestPodaci();
            PozdravnaPoruka();
            Izbornik();
        }

        private void TestPodaci()
        {
            Osobe.Add(new() { Ime = "Ana", Prezime = "Kat", Dob = 12 });
            Osobe.Add(new() { Ime = "Marko", Prezime = "Kekin", Dob = 14 });
        }

        private void Izbornik()
        {
            Console.WriteLine("1. Pregled osoba");
            Console.WriteLine("2. Unos nove osobe");
            Console.WriteLine("3. Promjena osobe");
            Console.WriteLine("4. Brisanje osobe");
            Console.WriteLine("5. Izlaz iz programa");
            OdaberiOpciju();
        }

        private void OdaberiOpciju()
        {
            switch(Pomocno.UcitajCijeliBroj("Odaberi opciju"))
            {
                case 1:
                    PrikaziOsobe(true);
                    break;
                case 2:
                    UnosNoveOsobe();
                    break;
                case 3:
                    PromjenaOsobe();
                    break;
                case 4:
                    BrisanjeOsobe();
                    break;
                case 5:
                    Console.WriteLine("Program je završio, doviđenja");
                    return;
                default:
                    Console.WriteLine("Nije dobra opcija");
                    Console.WriteLine("*****************");
                    break;
            }
            Izbornik();
        }

        private void BrisanjeOsobe()
        {
            Console.WriteLine("********************");
            Console.WriteLine("** Brisanje osobe **");
            Console.WriteLine("********************");
            PrikaziOsobe();
            if (Osobe.Count == 0)
            {
                return;
            }
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe koju brišeš (0 - odustani) ", 0, Osobe.Count);
            if(izbor == 0)
            {
                return;
            }
            Osobe.RemoveAt(izbor - 1);
        }

        private void PromjenaOsobe()
        {
            PrikaziOsobe();
            if (Osobe.Count == 0)
            {
                return;
            }
            Console.WriteLine("********************");
            Console.WriteLine("** Promjena osobe **");
            Console.WriteLine("********************");
            int izbor = Pomocno.UcitajCijeliBroj("Izaberi broj osobe koju mijenjaš (0 - odustani) ", 0, Osobe.Count);
            if (izbor == 0)
            {
                return;
            }
            var o = Osobe[izbor-1];
            
            o.Ime = Pomocno.UcitajString("Unesi ime [" + o.Ime + "]");
            o.Prezime = Pomocno.UcitajString("Unesi prezime [" + o.Prezime + "]");
            o.Dob = Pomocno.UcitajCijeliBroj("Unesi dob [" + o.Dob + "]");
        }

        private void UnosNoveOsobe()
        {
            Console.WriteLine("****************");
            Console.WriteLine("** Unos osobe **");
            Console.WriteLine("****************");
            Osobe.Add(new()
            {
                Ime=Pomocno.UcitajString("Unesi ime osobe"),
                Prezime=Pomocno.UcitajString("Unesi prezime osobe"),
                Dob=Pomocno.UcitajCijeliBroj("Unesi dob osobe")
            });
        }

        private void PrikaziOsobe(bool prikaziNaslov = false)
        {
            if(prikaziNaslov)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("** Osobe u sustavu **");
                Console.WriteLine("*********************");
            }
            if(Osobe.Count==0)
            {
                Console.WriteLine("U sustavu nema ni jedna osoba");
                return;
            }
            int i = 1;
            foreach (var o in Osobe)
            {
                Console.WriteLine(i++ + ". " + o);
            }
            Console.WriteLine("*********************");
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("Osobe program V1");
            Console.WriteLine("****************");
        }
    }
}
