using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_prvociselnosti
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i = 2;
            bool prvocislo = true;

            Console.WriteLine("Test prvociselnosti.");
            Console.Write("Zadejte cislo ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 2) prvocislo = false;

            while (prvocislo && (i *i <= x))
            {

                if(x % i == 0)
                {

                    prvocislo = false;
                    Console.WriteLine("Cislo {0} je delitelem cisla {1}", x, i);
                }
                i = i + 1;
            }
            if (prvocislo) Console.WriteLine("Cislo {0} je prvocislo", x);
            else Console.WriteLine(" Cislo {0} neni prvocislo", x);
            Console.ReadLine();
        }
    }
}
