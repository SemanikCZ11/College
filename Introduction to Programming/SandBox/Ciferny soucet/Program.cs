using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciferny_soucet
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            int y, cif = 0;

            Console.WriteLine("Spocteme ciferny soucet zadaneho cisla");
            Console.Write("Semn zadejte cislo  ");
            y = x = Convert.ToInt32(Console.ReadLine());

            while (y > 0)
            {

                cif = cif + y % 10;
                y = y / 10;

            }

            Console.WriteLine("Ciferny soucet cisla {0} je {1}", x, cif);
            Console.ReadLine();
        }
    }
}
