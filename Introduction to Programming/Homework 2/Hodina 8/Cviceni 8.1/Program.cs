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

namespace Cviceni_8._1
{
    class Program
    {
        //Funkce která tvoří binární soubor z nahodných kladných čísel (2 body) Cviceni 8.1


        static Random random = new Random();// Globalní promená pro náhodná císla

        static void UlozKladnaCisla(string soubor)//Funkce pro zapsaní na soubor
        {
            int i;

            FileStream fs = new FileStream(soubor, FileMode.Create);// nutný řadek pro otevření binarního souboru a vytvoření nového
            BinaryWriter bw = new BinaryWriter(fs);


            for (i = 0; i < 1000; i++)//For cyklus ze pro každé i je vytvořeno náhodné cislo
            {
                int x = random.Next(250);
                bw.Write(x);// vypsání náhodneho čísla od 0 - 249
            }
            bw.Close();// zavření souboru 
        }

        static void Main(string[] args)
        {
                    
            UlozKladnaCisla(@"..\..\..\Soubory k Hodine 8\Cisla Cviceni 8.1.dat");// uložení souboru
            Console.ReadLine();
        }
    }
}
