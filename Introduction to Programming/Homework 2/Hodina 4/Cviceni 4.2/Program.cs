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

namespace Cviceni_4._2
{
    class Program
    {

        // Cviceni 4.2 Absolutni hodnota pole
        
        static void AbsolutniPole (int [] pole)// Funkce absolutniho pole
        {
            int i;
           
            for (i = 0; i < pole.Length; i++)
            {
                if (pole[i] < 0) pole[i] = pole[i] * (-1);//If pokud je v poli zaporna hodnota,přepíše se na kladnou pokud ne nic se nevykona
                else pole[i] = pole[i];
                Console.WriteLine("Pole s indexem {0} má absolutní hodnotu hodnotu {1}", i, pole[i]);
                
            }

            
        }
      
        static void Main(string[] args)
        {

            int [] p0 = { 2, -5, -4, -8, 6, -1, -6, 3, 9 };// Pole hodnot

            AbsolutniPole(p0);//Vstup do funkce 


            Console.ReadLine();
      
            
        }
    }
}
