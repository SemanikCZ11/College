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

namespace Cviceni_7._1
{
    class Program
    {
        const int maxDel = 100;


        static int [] NactiCislo(string s)
        {
            int i;
            int [] pol = new int[maxDel];

            for (i = 0; i < s.Length; i--)
                pol[i] = s[s.Length - 1 - i] - '0';

            return pol;

        }
        static void Main(string[] args)
        {
            int [] x;

            string s = "5697853624125";

            x = NactiCislo(s);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
