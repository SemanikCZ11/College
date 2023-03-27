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

namespace Cviceni_5._1
{
    class Program
    {

        // Cviceni test setřidenosti pole Cviceni 5.1

        static void SestridenePole(int[] pole)// Funkce pro zjisteni setridenosti pole
        {
            int i;
            bool overeni = true;//nastaveni overeni na hodnotu True pro vstup do if 

            for (i = 1; i < pole.Length; i++)// hledani v poli a nastaveni i na hodnotu 1
            {
                if (overeni == true)
                {
                    if (pole[i - 1] >= pole[i]) overeni = true;// Porovnat pozici pole 0 s pozici pole 1
                    else overeni = false;//pokud neni mensi nez předešla hodnota do If už se nevstoupi a overeni zustane na False
                }
            }

            if (overeni == true) Console.WriteLine("Zadane pole je setřídené sestupne");// Vypsani pole pokud je setridene nebo ne ..
            else Console.WriteLine("Zadane pole není setřídené sestupne");
        }
        static void VypisPole(int[] pole)// Vypis pole 
        {
            int i;

            for (i = 0; i < pole.Length; i++)
                Console.WriteLine("{0}", pole[i]);
        }



        static void Main(string[] args)
        {
            int[] pole1 = { 16, 14, 12, 12, 5, 8, 11, 10 };

            VypisPole(pole1);
            SestridenePole(pole1);

            Console.ReadLine();

        }
    }
}
