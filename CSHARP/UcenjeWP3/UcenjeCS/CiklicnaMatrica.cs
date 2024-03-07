using System;

namespace UcenjeCS
{
    internal class CiklicnaMatrica
    {
        public static void Izvedi()
        {
            Console.Write("Redovi: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Stupci: ");
            int y = int.Parse(Console.ReadLine());

            int[,] matrica = PopuniMatricu(x, y);

            IspisiMatricu(matrica);
        }

        private static int[,] PopuniMatricu(int x, int y)
        {
            int[,] matrica = new int[x, y];
            int trenutnaVrijednost = 1;

            int pocetakX = x - 1, krajX = 0;
            int pocetakY = y - 1, krajY = 0;

            while (pocetakX >= krajX && pocetakY >= krajY)
            {
                for (int i = pocetakX; i >= krajX; i--)
                    matrica[i, pocetakY] = trenutnaVrijednost++;

                pocetakY--;

                for (int i = pocetakY; i >= krajY; i--)
                    matrica[krajX, i] = trenutnaVrijednost++;

                krajX++;

                if (krajX <= pocetakX)
                {
                    for (int i = krajX; i <= pocetakX; i++)
                        matrica[i, krajY] = trenutnaVrijednost++;

                    krajY++;
                }

                if (krajY <= pocetakY)
                {
                    for (int i = krajY; i <= pocetakY; i++)
                        matrica[pocetakX, i] = trenutnaVrijednost++;

                    pocetakX--;
                }
            }

            return matrica;
        }

        private static void IspisiMatricu(int[,] matrica)
        {
            int x = matrica.GetLength(0);
            int y = matrica.GetLength(1);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write("{0,4}", matrica[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}