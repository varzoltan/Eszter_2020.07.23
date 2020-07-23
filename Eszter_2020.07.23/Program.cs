using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._07._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Készíts programot, mely képernyőre írja a kettes szám első 32 hatványát
            //2*2*2*2*2*...*2=végeredménye
            long hatvany = 1;
            for (int i = 1;i<33;i++)//32-szer kell lefutnia
            {
                hatvany *= 2;
                //hatvany = hatvany * 2
                Console.WriteLine($"A kettő a {i}. hatványon {hatvany}");
            }

            //Előltesztelős ciklussal
            int szamlalo = 1;
            long hatvany_ertek = 1;
            while (szamlalo <= 32)//32-szer kell lefutnia
            {             
                hatvany_ertek *= 2;
                //hatvany_ertek = hatvany_ertek * 2
                Console.WriteLine($"A kettő a {szamlalo}. hatványon {hatvany_ertek}");
                szamlalo++;
            }
            Console.WriteLine($"2 a 32 = {hatvany}");
            Console.WriteLine($"Előltesztelős ciklussal 2 a 32 = {hatvany_ertek}");
            Console.ReadKey();
        }
    }
}
