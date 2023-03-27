using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dělení_základem_převod_soustavy
{
    class Program
    {
        static string  DexTHex(int x)
        {
            char[] p= new char [100];

            int i,zbytek= 0,cifry=0;
            char tmp;

            while (x > 15)
            {
                zbytek = x % 16;
                x = x / 2;

                p[cifry] = HexCifra(zbytek);
                cifry++;
            }

            p[cifry] = HexCifra(x);
            cifry++;

            for (i = 0;i < (cifry-1)/2 ;i++)
            {
                tmp = p[i];
                p[i] = p[cifry - 1 - i];
                p[cifry - 1 - i] = tmp;
            }
            return new string(p, 0, cifry);
        }
        static char HexCifra(int i)
        {
            if (i < 10) return (char)(i + '0');
            else return (char)(i - 10 + 'A');

        }
        static void Main(string[] args)
        {

            int x;

            x = 5689;

            string s1;

            s1 = DexTHex(x);

            Console.WriteLine("{0}", s1);
            Console.ReadLine();
        }
    }
}
