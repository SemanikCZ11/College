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
using System.IO;
namespace Cviceni_8._5
{
    class Program
    {
        // Vypsaní řádků jenom se zadaným řetezcem cviceni 8.5
        static void VypsaniRadku(string zdroj, string soubor)
        {
            string co = "dneska";
            string s; 
            StreamReader sr = new StreamReader(zdroj);
            StreamWriter sw = new StreamWriter(soubor);
            while ((s = sr.ReadLine()) != null)
            {
                if (s == co) sw.WriteLine(s);
                else continue;


            }

            sw.Close(); sr.Close();
        }

        static void Main(string[] args)
        { 

            VypsaniRadku(@"..\..\..\Soubory k Hodine 8\Text Cviceni 8.5.txt", @"..\..\..\Soubory k Hodine 8\ Upraveny Text Cviceni 8.5.txt");
            Console.ReadLine();
        }
    }
}
