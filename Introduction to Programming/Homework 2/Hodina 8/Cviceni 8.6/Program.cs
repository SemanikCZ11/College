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

namespace Cviceni_8._6
{
    class Program
    {
        //Statistické udaje Funkce zjištění udajů ze souboru a) Funkce vracející pocet různých znaků (2 body) HOTOVO
        //                                                   b) Funkce vracející pocet slov (2 body) HOTOVO
        //                                                   c) Funkce vracející pocet vet (2 body) HOTOVO
        //                                                   d) Funkce vracející nejdelší slovo
        //                                                   e) Funkce vracející nejdelsi vetu

        static void RuzneZnaky(string zdroj)// Funkce pro hledaní znaku v souboru
        {
            int znak = 0, index = 0, c, i;
            char[] pole = new char[1000];

            StreamReader sr = new StreamReader(zdroj);// Nactení Souboru

            while ((c = sr.Read()) != -1)// Prochazení souboru po znacích
            {
                if (char.IsLetter((char)c) || char.IsPunctuation((char)c))//Podminka pro znamenka a pismena
                {
                    znak++;// inkrementovaní znaku

                    pole[index] = (char)c;//prirazeni charu do indexu pole
                    index++;

                    for (i = 0; i < znak; i++)// for cyklus pro hledani stejných znaku
                    {
                        if (pole[i] == (char)c && i != index)// podmínka pro dekrementaci znaku
                            znak--;

                    }

                }

            }

            Console.WriteLine("V souboru se vyskytuje {0} znaku ", znak);// vypsani do console
            Console.ReadLine();

            sr.Close();// zavreni souboru 
        }



            static void PocetSlov(string zdroj)// Funkce pro vrácení poctu slov
        {
            int delka = 0, slovo = 0, c;
            char[] pole = new char[50];// nastavení pole charu počítame že slovo nebude delší než 50 

            StreamReader sr = new StreamReader(zdroj);// nactení souboru
            
            while ((c = sr.Read()) != -1)// while cyklus pro ctení po znacích dokud nenarazíme na konec.
            {
                if (char.IsLetter((char)c) || char.IsPunctuation((char)c))// podmínka pokud je char písmeno nebo když je konec celeho slova tecka
                {
                    pole[delka] = (char)c;
                    delka++;

                }
                else//pokud narazíme na mezeru 
                {
                    if (delka >= 3)// délka slova jsem nastavil aspon na 3 ( aby mi to nepočítalo spojky apod.)
                    {
                        slovo++;// slovo inlrementuji
                        delka = 0;// delku nastavím zbova na 0 aby mohlo počítat další slovo
                    }
                }


            }
            Console.WriteLine("V souboru se vyskytuje {0} slov ", slovo);// vypsaní výsledku
            Console.ReadLine();
            sr.Close();// zavření souboru 
        }
        static void PocetVet(string zdroj)// Funkce pro pocítaní vet
        {
            int vet = 0, c;
      
            StreamReader sr = new StreamReader(zdroj);// nactení souboru

            while ((c = sr.Read()) != -1)// ctení souboru po jednotlivych znacích doku nenarazím na konec
            {
                if (char.IsPunctuation((char)c) && c != ',')// podmínka pokud je na konci tecka znamená to vetu,ale aby to nepočítalo i čárky.
                    vet++;// inkrement vety 
                
            }
            Console.WriteLine("V souboru se vyskytuje {0} vet ", vet);// Vypsani vysledku
            Console.ReadLine();
            sr.Close();// zavreni souboru
        }

        static void NejdelsiSlovo(string zdroj)
        {
            int delka = 0,delka1=1, c;
            char[] pole = new char[100];
            
            StreamReader sr = new StreamReader(zdroj);
            while ((c = sr.Read()) != -1)
            {
                if (char.IsLetter((char)c))
                {
                    pole[delka] = (char)c;
                    delka++;
                    
                }
                else
                {
                    if (delka > delka1)
                    {
                        delka1 = delka;
                        char[] nejpole;
                    }
                    delka = 0;
                }

            }
            Console.WriteLine("{0}");
            Console.ReadLine();

            sr.Close();
        }
        static void Main(string[] args)
        {
            RuzneZnaky(@"..\..\..\Soubory k Hodine 8\\SouborText Cviceni 8.6.txt");//relatyvní cesta k souboru 
            PocetSlov(@"..\..\..\Soubory k Hodine 8\\SouborText Cviceni 8.6.txt"); 
            PocetVet(@"..\..\..\Soubory k Hodine 8\\SouborText Cviceni 8.6.txt");
            //NejdelsiSlovo(@"..\..\..\Soubory k Hodine 8\\SouborText Cviceni 8.6.txt");
        }
    }
}
