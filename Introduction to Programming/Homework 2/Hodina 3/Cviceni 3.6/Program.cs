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

namespace Cviceni_3._6
{
    class Program
    {
        // Kamen , Nuzky, Papir Cviceni 3.6 
        enum Hra
        {
            Kamen = 1,
            Nuzky,
            Papir

        }

        static Hra VyberHrace()
        {
            
            Hra h = 0;
            string s = "" ;

            while(h == 0)
            {
                Console.Write("Zadejte Kamen, Nuzky nebo Papir: ");
                s = Console.ReadLine();
                
                if (s == "Kamen" || s == "Nuzky" || s == "Papir") break;
                else Console.WriteLine("Zadali jste spatnou hodnotu prosim zkuste to znovu");
                
            }
            
         
            h =(Hra) Enum.Parse(typeof(Hra), s, true);
            
           return h;

        }
        static Hra VyberOponenta()
        {

            Random r = new Random();
            int hp = r.Next(1, 4);

            return (Hra) hp;

        }

        static void KonecnaHra()
        {
            Console.WriteLine("Vitejte v klasicke hre Kamen - Nuzky - Papir muzeme zacit");
            Console.WriteLine("Hrajeme na dve vitezna kola peknou zabavu");

            int pocether, vyhrahrac = 0, vyhrapocitac = 0,kolo = 0;

            Hra hrac, oponent;

            for (pocether = 1; pocether <= 3; pocether++)
            {
                hrac = VyberHrace();
                oponent = VyberOponenta();
                kolo = kolo +1;
                Console.WriteLine("Hrac vybral {0} a pocitac vybral {1}", hrac, oponent);
                
                if (hrac == Hra.Kamen)
                {
                    if (oponent == Hra.Nuzky)vyhrahrac ++;
                    if (oponent == Hra.Papir)vyhrapocitac ++;       
                    if (oponent == Hra.Kamen) pocether--;
                    
                    Console.WriteLine("Po {0}.kole je stav {1} : {2}", kolo, vyhrahrac, vyhrapocitac);

                }

                if (hrac == Hra.Nuzky)
                {

                    if (oponent == Hra.Papir) vyhrahrac++;
                    if (oponent == Hra.Kamen)vyhrapocitac ++;
                    if (oponent == Hra.Nuzky) pocether--;
                   
                    Console.WriteLine("Po {0}.kole je stav {1} : {2}", kolo, vyhrahrac, vyhrapocitac);
                }

                if (hrac == Hra.Papir)
                {

                    if (oponent == Hra.Kamen)vyhrahrac ++;
                    if (oponent == Hra.Nuzky)vyhrapocitac ++;
                    if (oponent == Hra.Papir) pocether--;
                 
                    Console.WriteLine("Po {0}.kole je stav {1} : {2}", kolo, vyhrahrac, vyhrapocitac);

                }
       
            }

            if (vyhrahrac < vyhrapocitac) Console.WriteLine("Hra skoncila {0} : {1} oponent vyhral",vyhrahrac, vyhrapocitac);
            else Console.WriteLine("Hra skoncila {0} : {1} hrac vyhral !!GRATULUJEME!!", vyhrahrac, vyhrapocitac);

        }
        static void Main(string[] args)
        {

            KonecnaHra();
            Console.ReadLine();


                
        }
    }
}
