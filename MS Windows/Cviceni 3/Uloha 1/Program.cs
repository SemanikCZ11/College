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

namespace Uloha_1
{
    class Program    // Uloha 1 Zadaní počtu zaměstnanců ,zadání jejich mzdy a vypsání mezd ktere jsou vetší než průměrná
    {           
        static void Main(string[] args)
        {
            Console.Write("Zadejte počet zaměstnancu: ");
            int pocetlidi = Int32.Parse(Console.ReadLine());// Zadání počtu zaměstnancu od uživatele 

            int[] firma = new int[pocetlidi];//nastavení velikosti pole - Firmy

            int pmzda = 0;// Pro výpočet průměrné mzdy

            for(int i=0;i<firma.Length;i++)//For cyklus pro přiřazení mezd zaměstnancům
            {
                Console.Write("Zadejte mzdu zaměstnance: ");
                int mzda = Int32.Parse(Console.ReadLine());

                firma[i] = mzda;// uložení mzdy zadané uživatelem do daného indexu
                pmzda = pmzda + mzda;// sčítaní mezd
            }

            pmzda = pmzda / pocetlidi;// výpočet výše průměrné mzdy

            Console.WriteLine("Průměrná mzda ve firmě je : {0}", pmzda);

            foreach (int mzdy in firma)// cyklus foreach ktery projde pole a If větev pro vypsání jenom vetších mezd než průměrné
            {

                if (mzdy > pmzda) Console.WriteLine("Výše mezd vetší než průměrná {0}",mzdy);
                else continue;
            }
            Console.ReadKey();
        }
    }
}
