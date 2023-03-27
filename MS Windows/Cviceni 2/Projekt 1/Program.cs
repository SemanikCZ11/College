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

namespace Projekt_1            // Logické výrazy hodnoty bool-True/False (4 prezentace -snímek 12)
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 5;
            int y1 = 3;
            bool vyraz1 = x1 > y1;

            Console.WriteLine(vyraz1);
            Console.WriteLine(x1 > y1);
            Console.WriteLine("{0} > {1}.......{2}",x1, y1, x1 > y1);

            Console.WriteLine();

            int x2 = 4;
            int y2 = 4;

            Console.WriteLine(x2 > y2);
            Console.WriteLine("{0} > {1}.......{2}",x2, y2, x2 > y2);
            Console.WriteLine("{0} >= {1}.......{2}",x2, y2, x2 >= y2);
            Console.WriteLine("{0} == {1}.......{2}",x2, y2, x2 == y2);

            Console.ReadKey();

            //Výstupem budou hodnoty True/False podle toho jak je podmínka splněna či nikoliv.
        }
    }
}
