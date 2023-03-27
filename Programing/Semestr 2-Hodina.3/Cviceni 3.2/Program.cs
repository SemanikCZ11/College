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

namespace Cviceni_3._2
{
    class Program
    {

        class StromB
        {
            public int data;
            public StromB levy;
            public StromB pravy;
        }
        static StromB Create (int n)
        {
            StromB vys = new StromB();
            vys.data = n;
            vys.levy = vys.pravy = null;
            return vys;

        }
        static StromB ConverArray (int [] pole)
        {
            StromB vys = null;
            int i;
            for (i = 0; i < pole.Length; i++)
                vys = Insert(vys, pole[i]);
            return vys;
        }
        static StromB Insert (StromB koren,int n)
        {
            StromB akt = koren, tmp = Create(n);
            if (koren == null) return tmp;
            while (akt != null)
            {
                if (akt.data == n) return koren;
                if (n< akt.data)
                {
                    if (akt.levy == null)
                    {
                        akt.levy = tmp;
                        return koren;
                    }
                    else akt = akt.levy;
                }
                else 
                {
                    if (akt.pravy == null)
                    {
                        akt.pravy = tmp;
                        return koren;
                    }
                    else akt = akt.pravy;
                }

            }
            return koren;
        }
        static StromB Uncle(StromB koren,int x)
        {
            StromB akt = koren,otec=null;

            if (akt.data == x || akt.levy.data == x || akt.pravy.data == x) return null;// Pokud je hledané čislo kořen vracíme null

            while (akt != null)// hledame dokud akt neni null
            {
                if (x < akt.data)// jdeme v levo, nebo v pravo v zavislosti na hledaný prvek
                {
                    otec = akt;// nastavíme aktualni prvek jako otce následujícího 
                    akt = akt.levy; // a přesuneme se na levý prvek a hledáme hodnotu 
                    if (akt.levy.data == x || akt.pravy.data == x) return otec.pravy;// pokud najdeme pravý otec je strýc prvku
                    continue;
                }
                else
                {
                    otec = akt;
                    akt = akt.pravy;
                    if (akt.pravy.data == x || akt.levy.data == x) return otec.levy;
                    continue;
                }
   
            }
            return null;         
        }
        static void Cesta(StromB koren,int x)// Cviceni B Cesta od kořene k hledané hodnotě
        {
            // v teto funkci nepočítam,že zadana hodnota neni obsažena ve stromě
            int i;
            StromB akt = koren;

            for (i = 1; akt.levy != null || akt.pravy != null; i++)// For cyklus pro hledání hodnoty 
            {
                if (i == 1) Console.WriteLine("Koren-{0}", akt.data);// nastavení kořene jen pro první iteraci
                if (x < akt.data)// Pokud je menši jdeme do leva 
                {
                    akt = akt.levy;
                    Console.WriteLine("L-{0}-{1}", i, akt.data);
                    if (akt.data == x) break;// pokud najdu hodnotu opostim For cyklus
                    continue;
                }
                else // pokud vetší tak doprava 
                {
                    akt = akt.pravy;// nastaveni pro další iteraci
                    Console.WriteLine("P-{0}-{1}", i, akt.data);
                    if (akt.data == x) break;// pokud najdu hodnotu opostim For cyklus
                    continue;// pokracujeme dokud nenajdeme hodnotu
                }
            }

        }
        static void Main(string[] args)
        {
            
            int [] pole1 = {31, 63, 97, 56, 98, 7, 1, 3, 41, 65, 12, 21, 66, 73, 40, 71, 5, 78, 42, 64 };
            StromB Strom1 = ConverArray(pole1);
            StromB x = Uncle(Strom1,41);
            Console.WriteLine("Pro zadanou hodnotu je strýc {0}", x.data);
            Cesta(Strom1,73);
            Console.ReadLine();
        }
    }
}
