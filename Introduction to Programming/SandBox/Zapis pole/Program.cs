using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Zapis_pole
{
    class Program
    {

        static void JenomSlova5(string zdroj,string cil)
        {
            int delka = 0, c;
            char[] pole = new char[100];

            StreamReader sr = new StreamReader(zdroj);
            StreamWriter sw = new StreamWriter(cil);

            while ((c = sr.Read()) != -1)
            {
                if (char.IsLetter((char)c))
                {
                    pole[delka] = (char)c;
                    delka++;
                }
                else
                {

                    if (delka >= 5)
                        sw.WriteLine(pole, 0, delka);
                        delka = 0;
                    

                }
            }
            sr.Close(); sw.Close();
        }
        static void Main(string[] args)
        {


            JenomSlova5(@"c:\Users\lseme\source\repos\Uvod do programovaní\Soubory\SouborText.txt", @"c:\Users\lseme\source\repos\Uvod do programovaní\Soubory\PrevedenyText.txt");
            Console.ReadLine();

        }
    }
}
