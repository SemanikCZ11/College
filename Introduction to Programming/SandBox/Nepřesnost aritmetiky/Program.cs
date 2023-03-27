using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nepřesnost_aritmetiky
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, opak = 200;
            double jedna = 1;

            for (i = 0; i < opak; i++)
                jedna = jedna / 7;
            for (i = 0; i < opak; i++)
                jedna = jedna * 7;

            Console.WriteLine(jedna);
            Console.ReadLine();

        }
    }
}
