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

namespace Cviceni_3._2___A
{
    class Program
    {
        // BODY MASS INDEX Cviceni 3.2 - A

        static int NactiVahu()// Nacteme vahu bez parametru
        {
            // Deklarujeme promenou convertujeme na cislo s navratovou hodnotou 
            int x;
            Console.Write("Zadejte Vasi vahu: ");
            x = Convert.ToInt32(Console.ReadLine());
            return x;

        }

        static int NactiVysku()//Nacteme vysku bez parametru
        {
            // Deklarujeme promenou a postupujeme stejne jako u vahy
            int x;
            Console.Write("Zadejte Vasi vysku v centimetrech: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;

        }

        static void SpocitejBMI( double BMI)// Spocteme BMI 
        {

            Console.WriteLine("Vaše BMI je {0:N1}", BMI);// Vypiseme vysledek BMI a nastavime na jedno desetine misto
            Console.ReadLine();


        }

        static void Main(string[] args)
        {
            double x, y,BMI;
            // prirazeni
            x = NactiVahu();
            y = NactiVysku();
            // aritmeticka operace pro ziskani BMI
            BMI = x / (2* (y / 100)) ;
            SpocitejBMI(BMI);
             




        }
    }
}
