using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozklad_na_prvočísla
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, i = 2;
            bool prvni = true;

            Console.WriteLine("Rozklad na prvočísla");
            Console.Write("Zadejte číslo: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}=", x);

            while(x > 1)
            {
                if (x % i == 0)
                {

                    if (prvni) prvni = false;
                    else Console.Write("*");
                    Console.Write(i);
                    x = x / i;

                }
                else i = i + 1;

            }
            Console.ReadLine();





        }
    }
}
