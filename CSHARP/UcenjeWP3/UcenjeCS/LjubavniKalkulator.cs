using System;
using UcenjeCS;

internal class LjubavniKalkulator
{
    public static void Izvedi()
    {
        string ime1 = Pomocno.UcitajString("Tvoje ime").ToUpper();
        string ime2 = Pomocno.UcitajString("Ime tvoje simpatije").ToUpper();

        string obaImena = ime1 + ime2;
        char[] obaImenaPolje = obaImena.ToCharArray();
        int[] poljeBrojeva = new int[obaImenaPolje.Length];
        int pocetniIndex = 0;

        foreach (char i in obaImenaPolje)
        {
            int suma = 0;
            foreach (char j in obaImenaPolje)
            {
                if (i == j)
                {
                    suma++;
                }
            }
            poljeBrojeva[pocetniIndex++] = suma;
        }

        string string1 = string.Join("", poljeBrojeva);

        int[] polje = string1.Select(c => int.Parse(c.ToString())).ToArray();

        int[] suma1 = Zbroj(polje);
        string string2 = string.Join("", suma1);
        int rezultat = int.Parse(string2);
        
        Console.Write(ime1 + " i " + ime2 + " se vole ");

        Console.Write(rezultat + "%");
    }

    static int[] Zbroj(int[] brojevi)
    {
        int[] sumaNovi;

        if (brojevi.Length % 2 == 0)
        {
            sumaNovi = new int[brojevi.Length / 2];
        }
        else
        {
            sumaNovi = new int[brojevi.Length / 2 + 1];
        }

        for (int i = 0; i < brojevi.Length / 2; i++)
        {
            int suma = brojevi[i] + brojevi[brojevi.Length - 1 - i];
            sumaNovi[i] = suma;
        }

        if (brojevi.Length % 2 != 0)
        {
            sumaNovi[sumaNovi.Length - 1] = brojevi[brojevi.Length / 2];
        }

        string uString = string.Join("", sumaNovi.Select(i => i.ToString()));
        int[] polje = uString.Select(c => int.Parse(c.ToString())).ToArray();

        if (polje.Length > 2)
        {
            return Zbroj(polje);
        }
        else
        {
            return sumaNovi;
        }
    }
}