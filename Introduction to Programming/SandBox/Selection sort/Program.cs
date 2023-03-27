using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    class Program
    {
        static void SelectionSort(int[] pole)
        {
            int i, j, min;

            for(i=0;i<pole.Length;i++)
            {

                min = i;

                for (j = i; j < pole.Length; j++)
                    if (pole[j] < pole[min])
                        min = j;

                vymena(ref pole[min], ref pole[i]);
                //Console.WriteLine("Setrříděné pole s indexem {0}je {1}", i, pole[i]);
            }
        }
        static void vymena(ref int x, ref int y)
        {

            int tmp;

            tmp = x;
            x = y;
            y = tmp;

        }
        static void Main(string[] args)
        {

            int [] pole = {16,5,8,12,1,2,6,11,9 };
            SelectionSort(pole);
            Console.ReadLine();
        }
    }
}
