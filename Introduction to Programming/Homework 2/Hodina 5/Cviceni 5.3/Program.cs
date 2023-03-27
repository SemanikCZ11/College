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

namespace Cviceni_5._3
{

    //Sestupne třídění pole  cviceni 5.3 pomoci a)Selection sort
    //                                          b) Insertion sort
    //                                          c)Bubble sort
    //                                          d)Count Sort
    // U Insertion sort,Bubble sort a Count Sort jsem neprisel na to jak to efektivněji vypsat pro par hodnot v poli asi staci ale když jich bude víc je to urcite neefektivni..
    class Program
    {
        static void Selectionsort(int [] pole)
        {
            Console.WriteLine("Setrídime pole sestupne pomoci Selection sort:");
            int i, j, max;

            for(i = 0; i < pole.Length;i++)
            {
                max = i;

                for (j = i; j < pole.Length; j++)
                    if (pole[j] > pole[max])
                        max = j;
                Vymena(ref pole[max], ref pole[i]);

                Console.Write("{0}, ", pole[i]);
                
            }
            Console.ReadLine();
           
        }
        static void Insertionsort(int [] pole)
        {
            Console.WriteLine("Setridime pole sestupne pomoci Insertion sort:");

            int i, j, akt;

            for(i = 1;i < pole.Length;i++)
            {
                akt = pole[i];

                for (j = i; (j > 0) && pole[j - 1] < akt; j--)
                    pole[j] = pole[j - 1];
                pole[j] = akt;
                

            }
            Console.Write("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", pole[0], pole[1], pole[2], pole[3], pole[4], pole[5], pole[6], pole[7], pole[8], pole[9]);
            Console.ReadLine();



        }
        static void BubbleSort(int[] pole)
        {
            Console.WriteLine("Setridime pole sestupne pomoci BubbleSort:");
            int i;
            bool prohod = true;

            while(prohod)
            {
                prohod = false;

                for (i = 1; i < pole.Length;i++)
                    if(pole [i] > pole[i -1])
                    {

                        Vymena(ref pole[i], ref pole[i - 1]);
                        prohod = true;
                    }

            }
            Console.Write("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", pole[0], pole[1], pole[2], pole[3], pole[4], pole[5], pole[6], pole[7], pole[8], pole[9]);
            Console.ReadLine();
        }
        static void CountingSort( int []pole)
        {
            Console.WriteLine("Setridime pole sestupne pomoci Couting sort:");
            int i, j, max = -1;
            int[] hodnoty;


            for (i = 0; i < pole.Length; i++)
                if (pole[i] > max) max = pole[i];

            hodnoty = new int[max+1];
            for (i = 0; i < pole.Length; i++)
                hodnoty[pole[i]]++;

            i = 0; j = max;

            while(i < pole.Length)
            {

                if (hodnoty[j] > 0)
                {

                    hodnoty[j]--;
                    pole[i] = j;
                    i++;
                    

                }
                else j--;


            }
            Console.Write("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", pole[0], pole[1], pole[2], pole[3], pole[4], pole[5], pole[6], pole[7], pole[8], pole[9]);
            Console.ReadLine();
        }


        static void Vymena(ref int x,ref int y)
        {
            int tmp;

            tmp = x;
            x = y;
            y = tmp;

        }
       

        static void Main(string[] args)
        {
            int[] pole = { 8, 6, 1, 3, 9, 0, 4, 2, 7, 5 };
            
           Selectionsort(pole);
           Insertionsort(pole);
           BubbleSort(pole);
           CountingSort(pole);

            Console.ReadLine();
        }
    }
}
