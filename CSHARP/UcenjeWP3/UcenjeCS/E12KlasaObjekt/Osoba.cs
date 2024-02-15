using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E12KlasaObjekt
{
    //Klasa je opisnik objekta - NAUČITI NAPAMET
    internal class Osoba 
    {
        //Klasa sadrži svojstva
        public string? Ime { get; set; } //OOP princip učahurivanje
        public string? Prezime { get; set; }

        public Mjesto? Mjesto { get; set; }

        //Klasa sadrži metode
        public string ImePrezime() //Ova metoda se može pozvati na objektu, ne na klasi
        {
            return Ime + " " + Prezime;
        }

        public static void Izvedi() //Ovu metodu mogu pozvati na klasi, ne na objektu
        {
            
        }
    }
}
