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

namespace Cviceni_6._1
{

    // Práce s textovými řetezci cviceni 6.1 a) Funkce vracejicí pocet písmen (2 Body)
    //                                       b) Funkce vracejíci počet slov   (2 body)
    //                                       c) Funkce vracejici slovo prvniho vyskytu
    //                                       d) Funkce vracejici nejdelši slovo
    //                                       e) Funkce vracejici lexikograficky nejvetši slovo 
    //                                       f) Funkce vracejici  nejčastěji se vyskytující slovo
    
    class Program
    {

        static int PocetPismen(string s)//Funkce vracející počet písmen
        {
            int pocet = 0,stejne = 0;
            int i,j;

            for(i = 0; i < s.Length;i++)//For cyklus pro pole charu ve stringu
            {
                if (char.IsLetter(s[i]))// Pokud je Char na dané pozici písmeno vstopim do vnořeneho cyklu
                {
                    pocet++;// za každé pismeno zvýším počet o jedno 
                    stejne = 0;

                    for(j = i; j >= 0;j--)// další cyklus pro kontrolu stejnych písmen vždy od dané pozice kterou směrem dolů
                        if(j != i)// když jsou stejné pozice nekotroluji
                        {
                            if (char.ToLower(s[j]) == char.ToLower(s[i]))// změna charu na malá písmena aby mi kontrolovalo podobnost i s Velkym pismenem
                                stejne++;

                        }
                    if (stejne > 0) pocet--;// pokud najdu stejná písmena dekrementuji počet o jeden

                }
            }
            return pocet;// vracím konečny výsledek 

        }
        static int PocetSlov(string s)//Funkce vracející pocet slov
        {
            int slov = 0;
            int i;

            for (i = 0; i < s.Length ; i++)//For cyklus pro pole charu daného stringu
            {
                
                if (char.IsLetter(s[i]) || char.IsPunctuation(s[i]))//Pokud je char písmeno nebo znamenko vstupujeme do cyklu
                {
                    if (i == s.Length - 1)// pokud jsme na konci stringu zvedame slovo o 1 a nasledně se cyklus ukonci(musíme snížit o jeden)
                        slov++;

                    else if (char.IsWhiteSpace(s[i + 1])) // pokud nasleduje mezera po pismenu slovo inkrementuji o jeden
                        slov++;
                }
            }
            return slov;// Vracím pocet slov 

        }
         

        static void Main(string[] args)
        {
            int x,y,i;

            string s1 ="Polevka pro 2 osoby";
            i = s1.Length;

            x = PocetPismen(s1);
            y = PocetSlov(s1);
           


            Console.WriteLine("V zadaném řetězci o delce řetezce :{0}: je {1} ruzných písmen",i, x);
            Console.ReadLine();
            Console.WriteLine("V zadaném řetezci jsou {0} slova", y);
            Console.ReadLine();





            Console.ReadLine();

        }

    }
}
