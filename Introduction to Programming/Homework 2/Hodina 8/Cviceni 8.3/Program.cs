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
    
namespace Cviceni_8._3
{
    class Program
    {
        //Součet čísel na radku v textovem souboru (3 Body) cviceni 8.3 


        static void SouborCisel(string zdroj,string soubor)
        {
            char [] s1 = new char[50];
            long soucet = 0;
            int pocet = 0,c,cislo = 0;
            
            StreamReader sr = new StreamReader(zdroj);
            StreamWriter sw = new StreamWriter(soubor);

            while ((c = sr.Read()) != -1) 
            {
               if(char.IsDigit((char)c))
               {

                   //s1[pocet++] = (char)c;
                    long s = (char)c++;

                    Console.WriteLine("{0}", s);

               }
               else
               {
                    cislo++;
                    if (cislo == 1)
                    {

                       long cislo1;
                        pocet = 0;
                    }
                    else if(cislo == 2)
                    {

                        long cislo2;
                        pocet = 0;
                        cislo = 0;

                        soucet = cislo1 + cislo2;

                        sw.WriteLine(soucet);
                    }           
               }
                
            }

            sw.Close(); sr.Close();
           
        }

        static void Main(string[] args)
        {

            SouborCisel(@"..\..\..\Soubory k Hodine 8\Cisla pro soucet - Cviceni 8.3.txt", @"..\..\..\Soubory k Hodine 8\SoucetCisel - Cviceni 8.3.txt");
            Console.ReadLine();
        }
    }
}
