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

namespace Cviceni_6._3
{
    //Cviceni Naše vlastni řetezce 6.3 pracujicí s polem Charu[]  -  A)Funkce lexikografického porovnávání řetežcu (2 body) -Hotovo
    //                                                               B)Funkce vracející index prvního výskytu hledaného řetežce (2 body) - Hotovo
    //                                                               C)Funkce vracející podřetězec zadaného řetežce (1 bod) - Hotovo
    //                                                               D)Funkce vracející řetezec vzniklý vložením řetezce  (2 body) - Hotovo
    //                                                               E)Funkce vracející řetězec odstraněním podřetězce ze zadaného řetězce 
    //                                                               F)Funkce  vracející řetezec vzniklí z řetežce a nahrazení všech výskytů
    class Program
    {

        static int Porovnani(char[] s3,char[] s4)//lexikograficke  porovnávání dvou řetezcu
        {
            int i, j;

            for (i = 0; i < s3.Length; i++)// prvni řetezec 
            {
                for (j = i; j < s4.Length;)// druhy řetezec se stejnou hodnotou jako prvni
                {
                    if (s3[i] > s4[j]) return 1;// pokud je první řetezec vetší vratí mi 1 
                    else if (s3[i] < s4[j]) return -1;// pokud je druhy řetezec vetší vrací  -1
                    else break;// jinak break pro porovnání dalších charu
                }

            }
            return 0;// pokud jsou obě slova stejná vrátím  0

            // předpokládáme že vždy najdeme nejakou neschodu pokud by druhý řetezec byl stejný a měl o par charů navíc cyklus by vratil 0 i když by byl druhy řetezec vetší
        }

        static void Podretezec(char[] s3,int index)// načtení Funkce prvního řetezce a indexu od kterého začínám
        {
            int i;
            Console.Write("Podřetezec prvního řetezce:  ");
            for (i = index; i <= index + 2; i++)// nastavení i na index a delku o hledaní + 2 a vypsaní
                Console.Write("{0}", s3[i]);
            Console.ReadLine();
        }
        static void SpojeniRetezcu(char[] s3, char[] s4, int index)// spojení dvou řetezcu od určitého indexu
        {

            int i,j;
            Console.Write("Spojeni dvou neuplnych řetezců :  ");
            for (i = 0; i <= index; i++)// vypsaní prvního řetezce od indexu nula a po zadaný index 
                Console.Write("{0}", s3[i]);

            for (j = index; j < s4.Length; j++)// připojení druhého řetezce od zadaného indexu až po jeho délku
                Console.Write("{0}", s4[j]);
            Console.ReadLine();

        }
        static int PrvniVyskyt(char []s3,char co)//Hodnota hledaného prvního vyskytu
        {

            int i;

            for (i = 0; i < s3.Length; i++)//hledání charu v řetezci
            {
                if (s3[i] == co)// pokud se zadaná hodnota najde vyskočíme z cyklu a vracíme hodnotu
                    break;
                else if (s3[i] != co && i == s3.Length -1)// když se nenajde vracíme -1
                        return -1;
                     
            }
            return i;
        }
        
        static void Main(string[] args)
        {
            int i,x;

            char[] s1 = "Kolotoc".ToCharArray();
            char[] s2 = "Klobouky".ToCharArray();
            
            x = Porovnani(s1, s2);//Funkce pro porovnání
            Console.WriteLine("Porovnání dvou řetezcu: {0}", x);
            Console.ReadLine();

            Podretezec(s1, 3);// Funkce pro podretezec
            SpojeniRetezcu(s1, s2, 4);// spojení obou neuplných retezcu
            
            i = PrvniVyskyt(s2, 'o');// Funkce pro výskyt charu a jeho vypsání 
            Console.WriteLine("Index prvního výskytu je na pozici {0}", i);
            Console.Read();

            
        }


    }
}
