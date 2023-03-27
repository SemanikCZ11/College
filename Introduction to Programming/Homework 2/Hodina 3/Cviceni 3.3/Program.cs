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

namespace Cviceni_3._3
{
    class Program
    {
        // Aritmeticky vyraz Cviceni 3.3 - A, B, D 

        // Vypocet Faktorialu
        static int FaktorialCisla()// Vyzva v zadani cisla pro vypocet faktorialu
        {

            int x ;
            Console.Write("Zadejte Cislo pro vypočet faktorialu: ");
            x = Convert.ToInt32(Console.ReadLine());
            return x;

        }
        static void SpoctiFaktorial()// Vypocet factorialu 
        {

            double x, i, faktorial = 1;

            x = FaktorialCisla();

            for (i = 1; i <= x; i++)
            {

                faktorial = faktorial * i;
            }

            Console.WriteLine("Faktorial cisla {0} je {1}", x, faktorial);//Vypsani vysledku

        }
        // Vypocet Celociselne mocniny
        static double RealneCislo()// Vyzva k zadani cisla uzivatelem 
        {

            double x;
            Console.Write("Zadejte nahodne cislo pro vypocet: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;
        }
        static int Mocnina()//Zadani mocniny k vypoctu
        {
            int x;
            Console.Write("Zadejte mocninu: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;

        }
        static void CelociselnaMocnina()// vypocet celociselne mocniny
        {
            double i, y, z,tmp, vys;

            y = RealneCislo();
            z = Mocnina();
            tmp = y;

            for(i = 1; i < z; i++)
            {

                vys = tmp * y;
                tmp = vys;

            }


            Console.WriteLine("Realne cislo {0} umocnene na {1} je {2}", y, z, tmp);
        }
        // Vypocet pro Kombinacni cislo
        static int Kombinace()// Vyber cisla pro  N 
        {
            int x;
            Console.Write("Zadejte cele cislo: ");
            x =Convert.ToInt32(Console.ReadLine());
            return x; // vracim vybranou hodnotu
            
        }

        // Vypocet pro Kombinacni cislo
        static int KombinacePod()// Vyber cisla pro  K
        {
            int x;
            Console.Write("Zadejte cele cislo: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;//vracim vybranou hodnotu
        }
        static void KombinacniCislo()// Vypocet Kombinacniho cisla
        {
            double i,x, y, z,Faktorialn = 1,Faktorialk = 1,Faktorials = 1,kom;

            x = Kombinace();
            y = KombinacePod();

            for(i = 1; i <= x; i++)// Vypocet Faktorialu pro N
            {
                Faktorialn = Faktorialn * i;
            }

            for (i = 1; i <= y; i++)// Vypocet faktorialu pro K
            {
                Faktorialk = Faktorialk * i;
            }

            z = x - y;// Vypocet K-N

            for (i = 1; i <= z; i++)// Faktorial K-N
            {
                Faktorials = Faktorials * i;
            }

            kom = Faktorialn / (Faktorialk * Faktorials);// Vypocet kombinacniho cisla

            Console.WriteLine("Kombinacni cislo pro {0} a {1} je {2}", x, y, kom);// Vypsani vysledku pro kombinacni cislo
        }


        static void Main(string[] args)
        {

            SpoctiFaktorial();
            CelociselnaMocnina();
            KombinacniCislo();

            Console.ReadLine();
        }
    }
}
