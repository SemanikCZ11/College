// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni_8_2
{
    class Program
    {
        // Převod binarního souboru na textový Cviceni 8.2

        static void NactiCislaApreved(string soubor,string zapis)
        {
            int s;

            FileStream fs = new FileStream(soubor, FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            StreamWriter sr = new StreamWriter(zapis);

            




        }
        static void Main(string[] args)
        {

            NactiCislaApreved(@"..\..\..\Soubory k Hodine 8\Cisla pro prevod na text cviceni 8.2.dat", @"..\..\..\Soubory k Hodine 8\Prevedena cisla na text cviceni 8.2.dat");


        }
    }
}
