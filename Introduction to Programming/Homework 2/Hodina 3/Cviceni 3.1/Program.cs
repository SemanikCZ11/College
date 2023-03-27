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

namespace Cviceni_3._1
{
    class Program
    {
        // DPH 3.1 - A
        static int NactiDph() //Nacti DPH bez parametru 
        {
            //Deklarace x vyzva uzivateli k vypsani sazby convertovat na cislo a pomoci return vratit vyslednou hodnotu
            int x;
            Console.Write("Napis sazbu DPH: ");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static int NactiCenu() // Nacti Cenu bez parametru
        {
            // Stejne jako v predchozim pripade
            int x;
            Console.Write("Napis cenu zbozi: ");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void VypisCenu( double z) // Vypsani ceny vysledku "z" s realnym typem double
        {

            Console.WriteLine("Cena zbozi s DPH je {0} Kc", z);//vypis na obrazovku
            Console.ReadLine();//Pockame na klavesu enter

            
        }

        static void Main(string[] args)
        {
            // Deklarace s typem double a nacitani hodnot bez parametru
            double x, y, z;
            x = NactiDph();
            y = NactiCenu();

            // Aritmeticka operace pro ziskani Ceny s DPH
            z = y *(x / 100);
            z = y + z;
            // Zaokrouhleni na cele cislo nahoru
            z = Math.Ceiling(z);
            VypisCenu(z);
        }
    }
}
