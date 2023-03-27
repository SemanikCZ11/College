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

namespace Cviceni_5._2_B //QuickSOrt
{
    class Program
    {
        static void Quick(int[] pole,int l,int r)// Funkce pro Quick sort
        {
            int pivot, i, j, tmp;

            if(l<r)
            {
                pivot = pole[l];// nastavení pivota na zacatek pole
                i = l;
                j = r;
                
                while(i<j)
                {
                    while(pole[i] > pivot) i++;// Pokud je pivot menší inkrementujeme i
                    while(pole[j] < pivot) j--;//pokud je pivot vetší dekrementujeme J
                    //Prohozením docílime vzestupného třídění

                    tmp = pole[i];//Pokud nenastane ani jeden While prohazujeme hodnoty
                    pole[i] = pole[j];
                    pole[j] = tmp;//pokracujeme dokud bude I ruzné od J
                }
                Quick(pole, l, i - 1);//Rekurze pro nového pivota z levé části od starého pivota
                Quick(pole, i + 1, r);//Rekurze pro nového pivota z pravé části
            }
        }
        static void Main(string[] args)
        {
            int i;
            int[] pole = { 19, 87, 46, 13, 56, 54, 75, 88, 50, 68, 16, 2, 17, 77, 91, 8, 62, 10, 15, 71 };
            Quick(pole, 0, pole.Length-1);
            for (i = 0; i < pole.Length; i++)// vypis pole
                Console.WriteLine(pole[i]);
            Console.ReadLine();
        }
    }
}
