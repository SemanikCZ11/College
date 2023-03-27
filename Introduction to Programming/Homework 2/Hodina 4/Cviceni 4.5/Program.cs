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

namespace Cviceni_4._5
{

    // Maximum 3 nejvetšich cisel cvoceni 4.5 a) Hodnota nejvetsiho prvku (toto jsem udelal)
    //                                        b) Hodnota druheho nejvetsiho x
    //                                        c) Hodnota Třetiho nejvetsihox
    class Program
    {

        static void Vypispole(int[] pole)//Vypsaní pole hodnot s klavesou enter pro pokracovaní
        {

            int i;

            for (i = 0; i < pole.Length; i++)
                Console.Write(" {0},", pole[i]);Console.Write(" Pole pro hledaní hodnot!! Pokracujte klavesou enter!!");
            Console.ReadLine();

        }
        static int NajdiHodnotu( int [] pole, int hodnota)// funkce pro hledaní nejvetší hodnoty v poli
        {

            int i, nejvetsi = 0;
            for (i = 0; i < pole.Length; i++)
                if (pole[i] > hodnota) nejvetsi = pole[i];// pokud je hodnota vetší nez minula tak se zapíše do nejvetsi.
            

            return nejvetsi;// vrací nejvetší hodnotu

        }


        static void Main(string[] args)
        {
            int nejvetsi = 0;
            int[] pole = { 6, 4, 12, 11, 3, 9, 1, 15, 0 };// Pole s hodnotou

            Vypispole(pole);
            int max = NajdiHodnotu(pole,nejvetsi);// Vstup do funkce 
         
            Console.WriteLine("Nejvetsi hodnota v poli je {0}",max);// Vypsaní nejvetší hodnoty v poli
            



            Console.ReadLine();

        }
    }
}
