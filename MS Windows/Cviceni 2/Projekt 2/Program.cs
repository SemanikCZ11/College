// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2         // Kod vícenásobného příkazu else if (4 prezentace - snímek 16)
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            int y =5;
            int z = 10;

            if (x < y && y > z) Console.WriteLine("Dobrá Prace první příkaz = TRUE");
            else if (x > y || z < y) Console.WriteLine("Dobrá Prace druhý příkaz = TRUE");
            else if (x == z || z == y ) Console.WriteLine("Dobrá Prace třetí příkaz = TRUE");
            else Console.WriteLine("Spatná práce - všechny příkazy jsou FALSE");

            Console.ReadKey();

            //Je to jednoduchý kod porovnávání pokud se nějaká podmínka vyhodnoti jako true tak se vypíše jako dobrá práce
            //pokud ne tak projde až k poslednímu else ...


        }
    }
}
