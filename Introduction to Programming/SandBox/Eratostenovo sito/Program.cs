using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratostenovo_sito
{
    class Program
    {

        static bool [] EratostenovoSito(int delka)
        {

            int i, j;

            bool[] sito = new bool[delka];

            for (i = 2; i < sito.Length; i++) sito[i] = true;

            for(i = 2; i*i <= sito.Length; i++)
            {
                if (!sito[i]) continue;
                for (j = i * i; j < sito.Length; j = j + i)
                    sito[j] = false;
            }
            return sito;





        }
        static void Main(string[] args)
        {
            int i;

            bool[] sito = EratostenovoSito(60);
            for (i = 0; i < sito.Length; i++)
                if (sito[i]) Console.Write("{0}, ", i);
            Console.ReadLine();

        }
    }
}
