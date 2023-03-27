using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cviceni_na_Hodinu
{
    class Program
    {

        static void JenomSlova5(string zdroj, string cil)
        {
            int znak = 0,index = 0, c,i,delka = 10;
            char[] pole = new char[1000];

            StreamReader sr = new StreamReader(zdroj);
            StreamWriter sw = new StreamWriter(cil);

            while ((c = sr.Read()) != -1)
            {
                if (char.IsLetter((char)c) || char.IsPunctuation((char)c))
                {
                    znak++;

                    pole[index] = (char)c;
                    index++;
                    
                    for(i = 0; i < znak ;i++)
                    {
                        if (pole[i] == (char)c && i !=index)
                            znak--;

                    }

                }
               
            }
            Console.WriteLine("V souboru se vyskytuje {0} znaku ", znak);
            Console.ReadLine();
            sr.Close(); sw.Close();
        }
        static void Main(string[] args)
        {

            JenomSlova5(@"c:\Users\lseme\source\repos\Uvod do programovaní\Soubory\SouborText.txt", @"c:\Users\lseme\source\repos\Uvod do programovaní\Soubory\PrevedenyText.txt");
            Console.ReadLine();
        }
    }
}
