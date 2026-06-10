using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bojer_mur_tabla
{
    internal class Program
    {
        static void BojerMur(string rec)
        {
            int m = rec.Length;
            int[] tabelaSkokova = new int[256];

            for (int i = 0; i < 256; i++)
            {
                tabelaSkokova[i] = m;
            }

            for (int i = 0; i < m - 1; i++)
            {
                tabelaSkokova[rec[i]] = m - 1 - i;
            }

            int[] ispisano = new int[256];

            for (int i = 0; i < m; i++)
            {
                char slovo = rec[i];
                if (ispisano[slovo] == 0)
                {
                    Console.WriteLine($"{slovo,-10}   {tabelaSkokova[slovo],-20}");
                    ispisano[slovo] = 1;
                }
            }


            Console.WriteLine($"{"*",-10}   {   m,-20}");
        }
        static void Main(string[] args)
        {
            string rec = Console.ReadLine();
            BojerMur(rec);
        }
    }
}
