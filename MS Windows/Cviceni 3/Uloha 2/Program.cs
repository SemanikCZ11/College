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
 
namespace Uloha_2
{
    class Program // Uloha 2 malá násobilka bez sudých výsledků 
    {
        static void Main(string[] args)
        {
            int vysledek = 0;
    
            for(int i=1;i<=10;i++)// První for cyklus pro proměnou kterou budeme násobit
            {
                if (i % 2 == 0) continue;// Pomocné If aby jsme se sudým číslem nemuseli procházet další cyklus for

                for (int j = 1; j <= 10; j++)// Vnořený cyklus pro násobeni
                {
                    vysledek = i * j;
                    if (vysledek % 2 != 0) Console.WriteLine("{0} * {1} = {2}", i, j,vysledek);//Pokud výsledek není sudý zapíšeme na konzoli
                    else continue;
                }
                
            }
            Console.ReadKey();
        }
    }
}
