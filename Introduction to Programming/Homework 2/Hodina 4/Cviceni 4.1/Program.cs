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

namespace Cviceni_4._1
{
    class Program
    {
        //Cviceni 4.1 Sestupne setřídeni
        
        static void setrid(ref int a, ref int b)//Funkce pro setřídení dvou hodnot
        {
            //Podminka pokud je A vetší pokud ne bje vetši
            if (a > b) Console.WriteLine("Hodnoty setridene sestupne jsou {0} a {1}",a, b);
            else Console.WriteLine("Hodnoty setridene sestupne jsou {0} a {1}",b,a);
    
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            // Deklarace s inicializaci
            int x = 11, y = 18;

           setrid(ref x, ref y);//Vstup do funkce z hodnotou X a Y

         
        }

    }
}
