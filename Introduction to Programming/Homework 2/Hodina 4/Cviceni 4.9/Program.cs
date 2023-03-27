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

namespace Cviceni_4._9
{

    // Spoprtka vytvoreni sazenky a vyher :-D Cviceni 4.9  // Není to uplně v Top Dokonalosti spíš taková kostra kdyby to nestačilo mužu předělat a poslat znovu.
                               // Urcite co bude lepší udělat pole cisel Tahu ne nahodně ale napsat si je sám,trefil jsem snad 3 cisla jendou asi z 50 :-D 
    class Program
    {
        static int[] VytvorNahodnePole(int delka, int min, int max)// Vytvoření náhodného pole s nahodnou hodnotou
        {
            int i;

            int[] vys = new int[delka];
            Random r = new Random();

            for (i = 0; i < vys.Length; i++)
                vys[i] = r.Next(min, max);
           
            return vys;
        }

        static void VypisTah(int[] pole)// Vypis polí pro jednotlive tahy a sazenku 
        {

            int i;

            for (i = 0; i < pole.Length; i++)
                Console.Write("{0} ", pole[i]);

        }

        static int NaplnPenezenku()// Ne uplně zasadni napln peneženku pro hraní ( nemám opakujicí se hru )
        {
            int x = 0, tmp = 0;

            while (x >= 0)
            {
                Console.Write("Zadejte castku kterou chete prevest pro hru sportka minimalni vklad 20 kc: ");
                x = Convert.ToInt32(Console.ReadLine());
                x = tmp + x;
                if (x < 20)
                {
                    Console.WriteLine("Neplatna hodnota, nebyl dodrzen minimalni vklad");
                    tmp = x;
                    continue;


                }
                else Console.WriteLine("Děkujeme Hodně štesti");
                break;

            }

            return x;

        }
        static int PocetCiselTah1(int[] pole1, int[] pole2)//soucet stejnych čísel kolik trefil sazející v prvním tahu
        {
            int i, stejna = 0;

            for (i = 0; i < pole1.Length; i++)
                if (pole1[i] == pole2[i]) stejna++;

            return stejna;
        }
        static int PocetCiselTah2(int[] pole1, int[] pole2)//soucet stejnych čísel kolik trefil sazející v druhem tahu
        {
            int i, stejna = 0;

            for (i = 0; i < pole1.Length; i++)
                if (pole1[i] == pole2[i]) stejna++;

            return stejna;
        }




        static void Main(string[] args)
        {
            // Deklarace s inicializaci pro peneženku ,možnou výhru a počet stejnych cisel.
            int x = 0, bank = 27000000, trefa1tah = 0, trefa2tah = 0;
            double vyhra = 0;
           
            Console.WriteLine("Vytejte ve hre Sportka ve které se hraje o velké penize v banku je momentalne {0}",bank);


            while (x < 20)// aby mohl sazející hrat musí mit aspon 20 kc ( je to na jednu hru v zadani je i moznost více slosovaní pro jednu sazenku to nemam)
            {
                x = NaplnPenezenku();

                if (x >= 20)
                {
                    Console.WriteLine("Pozor,Připrav se, Hrajem");
                    break;

                }
                else Console.WriteLine("Není dostatečný kredit pro další slosování, nejprve napln penezenku");
            }

            int[] pu = { 43, 11, 12, 5, 18, 28 }; // pole sazenky (pro zadaní jakýkoliv vlastních cisel) i pro sazenku by se dalo udělat pole nahodně 

            // Tah 1 a jeho vypsani
            int [] Tah1 = VytvorNahodnePole(6, 1, 49);
            Console.Write("V prvni tahu sportky padla čísla :");
            VypisTah(Tah1);
            Console.ReadLine();
            // Tak 2 a jeho vypsani 
            int [] Tah2= VytvorNahodnePole(6, 1, 49);
            Console.Write("Ve druhem tahu sportky padla čisla : ");
            VypisTah(Tah2);Console.WriteLine("");

            Console.WriteLine("!!!!!!Slosování proběhlo podíváme se na výhry!!!!!");
            Console.ReadLine();

            // Vypsani sazenky sazejícího
            Console.Write("Sazenka hrace:" );
            VypisTah(pu);
            Console.ReadLine();

            trefa1tah = PocetCiselTah1(Tah1, pu);//Funkce pro stejná čísla v tahu a v sazence 
            trefa2tah = PocetCiselTah2(Tah2, pu);

            Console.WriteLine("V prnim tahu hrac uhodl {0}x cislo a ve druhem tahu {1}x cislo", trefa1tah,trefa2tah);
           
            // Podmínky pro výhru zatím to mám takto jednoduše (teda spíš složite :-D ) a nemám koncipované to dodatkové číslo 
            if(trefa1tah < 3 || trefa2tah < 3)
            {
                Console.WriteLine("Dneska to nevyšlo zkuste to příště");
                Console.ReadLine();
            }

            if (trefa1tah == 3 || trefa2tah == 3) 
            {
                vyhra = bank * 0.0001;

                if(trefa1tah==trefa2tah)
                {

                    vyhra = vyhra + vyhra;
                }


                Console.WriteLine("Gratulujeme vyhral jste 5.poradi {0}", vyhra);
            }

            if (trefa1tah == 4 || trefa2tah == 4)
            {
                vyhra = (bank * 0.001) / 3;

                if (trefa1tah == trefa2tah)
                {

                    vyhra = vyhra + vyhra;
                }


                Console.WriteLine("Gratulujeme vyhral jste 4.poradi {0}", vyhra);
            }
            if (trefa1tah == 5 || trefa2tah == 5)
            {
                vyhra = bank * 0.01;

                if (trefa1tah == trefa2tah)
                {

                    vyhra = vyhra + vyhra;
                }


                Console.WriteLine("Gratulujeme vyhral jste 3.poradi {0}", vyhra);
            }
            if (trefa1tah == 6 || trefa2tah == 6)
            {
                vyhra = bank;

                if (trefa1tah == trefa2tah)
                {

                    vyhra = bank; 
                }


                Console.WriteLine("GRATULUJEME VYHRAL JSTE JACPOT {0}", vyhra);
            }
            Console.ReadLine();
            //Konec Hry :D 


        }

    }
}
