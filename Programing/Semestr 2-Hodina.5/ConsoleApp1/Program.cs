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

namespace ConsoleApp1 // MergeSort
{
    class Program
    {
        static void rozdel(int[] pole, int l, int r)//Funkce na rekurzivni voláni a rozdělování pole 
        {
            int m;

            if (l < r)
            {
                m = (r + l) / 2;// delení pole na pulky
                rozdel(pole, l, m);// rozdělení na menší kousky
                rozdel(pole, m + 1, r);
                slij(pole, l, r, m);// funkce na sleváni dat v poli 
            }      
        }
        static void slij(int[] pole,int l,int r,int m)// funkce pro třídění 
        {
            int[] poleB = new int[20];// alokuju jsi nové pole
            int i=l, j=m+1, k=l;

            while(i<=m && j<=r)// Cyklus že i není vetší než střed a že J není vetší než konec tříděného pole
            {
                if (pole[i] >= pole[j])// pro sestupné třídění pro vzestupné akorat otočíme znaménka
                {
                    poleB[k] = pole[i];// nakopírujeme na pozici K hodnotu pole I
                    i++;
                    k++;
                }
                else
                {
                    poleB[k] = pole[j];// nakopírujeme na pozici K hodnotu pole J
                    j++;
                    k++;
                }
            }
            while(i<=m) // pokud nám ještě zbyly prvky v levé části 
            {
                poleB[k] = pole[i];
                i++;
                k++;
            }
            while (j <= r)// pokud nám ještě zbyly prvky v levé části 
            {
                poleB[k] = pole[j];
                j++;
                k++;
            }
            for (k = l; k <=r; k++)// přepisujeme nové rozstříděné hodnoty z pomocného pole do pole původního
                pole[k] = poleB[k];

        }
        static void Main(string[] args)
        {
            int i;
            int[] pole = { 84, 73, 46, 86, 60, 40, 18, 54, 83, 9, 88, 22, 72, 34, 51, 69, 35, 95, 16, 14 };
            rozdel(pole, 0, pole.Length - 1);
            for (i = 0; i < pole.Length; i++)// vypis pole
                Console.WriteLine(pole[i]);
            Console.ReadLine();
        }
    }
}
