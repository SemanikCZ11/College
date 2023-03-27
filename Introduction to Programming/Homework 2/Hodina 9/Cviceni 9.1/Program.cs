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
using System.IO;
namespace Cviceni_9._1
{
    class Program
    {
        static Random random = new Random();


        static void vypisMatice(long[,] matice)//výpis matice
        {
            int i, j;

            for(i=0 ;i < matice.GetLength(0);i++)
            {
                for (j = 0; j < matice.GetLength(1); j++)
                    Console.Write(matice[i,j] +" ");
                Console.WriteLine("");
            }
        }
        static void ZapisMatice(string soubor,long[,] p)//zápis do souboru
        {
          
            StreamWriter sw = new StreamWriter(soubor);

            int i, j;
            sw.WriteLine("Rozměr matice je {0} x {1}", p.GetLength(0), p.GetLength(1));

            for (i = 0; i < p.GetLength(0); i++)
            {
                for (j = 0; j < p.GetLength(1); j++)
                    sw.Write(p[i, j] + " ");
                sw.WriteLine("");
            }

            sw.Close();
        }
        

        static void Zamena(long[,] matice2)//řádky za sloupce
        {
            Console.WriteLine("Prohození řádků za sloupce");

            int i, j;

            for (i = 0; i < matice2.GetLength(0); i++)
            {
                for (j = 0; j < matice2.GetLength(1); j++)
                    Console.Write(matice2[j, i] + " ");
                Console.WriteLine("");
            }
        }
        
        static void Main(string[] args)
        {
            //int i, j;

            //long[,] r = new long[5, 5];

            long[,] p = { { 4, 2, 3, -1 }, { 4, -2, 2, 3 }, { 1, 1, -2, -4 }, { 2, 2, 3, 4 } };


            /*for (i = 0; i < r.GetLength(0); i++)
                for (j = 0; j < r.GetLength(1); j++)
                    r[i, j] = random.Next(-4, 4);*/


            vypisMatice(p);
            ZapisMatice(@"c:\Users\lseme\source\repos\Hodina 9\Soubory\matice.txt",p);
            Zamena(p);
            
            Console.ReadLine();
        }
    }
}
