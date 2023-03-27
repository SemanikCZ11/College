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

namespace Cviceni_4._3
{


    //Zaokrouhleni realnych čísel na celá čísla Cviceni 4.3

    class Program
    {
        static void ZaokrouhliPole(double[] pole)// Funkce pole s realným datovým tipem
        {
            int i;

            for (i = 0; i < pole.Length; i++)
                Console.WriteLine("Prvek s indexem {0} ma hodnotu {1}", i, Math.Round (pole[i]));// vypsani pole a jeho zaokrouhleni pomoci knihovny MATH.
            

        }

        static void Main(string[] args)
        {

            double[] pole = { 3.22, 5.66, 8.259, 6.669, 110, 7.9 };//Pole s hodnotamy
            
            ZaokrouhliPole(pole);//vstup do funkce 
            Console.ReadLine();

        }
    }
}
