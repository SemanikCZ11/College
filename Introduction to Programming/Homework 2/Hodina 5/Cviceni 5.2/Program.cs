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

namespace Cviceni_5._2
{
    // Příprava na třídeni s globalní proměnou A) Přiřazení 
    //                                         b) Porovnaní Menší
    //                                         c) Porovnání Vetsi

    class Program//Nastavíme dve globalni promene a ty pomocne 
    {
        static int x = 10;
        static int y = 5;
        static int porovnani = 0;
        static int prirazeni = 0;
        static int operace = 0;
        static void Porovnani()// Nejprve budeme porovnavat hedbu globalni promenou s promenou v tele funkce 
        {
            Console.WriteLine("Nyní vyzkoušíme par kroku s Globalní promenou!!Pro pokracovaní stisknete ENTER");
            Console.ReadLine();

            operace++;
            porovnani++;
            int z = 4;
            bool mensi = false;

            if (x < z) mensi = false;
            else mensi = true;

            if (mensi == true) Console.WriteLine("Porovnání dvou čísel z něhož jedna je globalní hodnota, je zadaná hodnota  {0} menší než  globalní hodnota {1}", z, x);
            else Console.WriteLine("Porovnání čisla s globalní proměnou je globalní proměná menší {0}  než zadaná hodnota {1}", x, z);
            Console.ReadLine();
        }
        static void GlobalniPorovnani()//Ted budeme porovnavat 2 globalni promene 
        {
            Console.WriteLine("Nyní zkusíme porovnat dvě globální proměné mezi sebou");
            operace++;
            porovnani++;
            if (x < y) Console.WriteLine("Cislo {0} Globalní promene X je mensi nez cislo {1} globalni promene Y", x, y);
            else Console.WriteLine("Cislo {0} globalní promene Y je mensi nez cislo {1} globalni promene X", y, x);

            Console.ReadLine();


        }
        static void Vymena1(ref int a,ref int b )//Nejprve prohodíme dve globalni promene 
        {
            operace++;
            prirazeni++;
            Console.WriteLine(" Nyní priradíme hodnote x:{0} hodnotu y:{1}", a, b);
            int tmp;//inicializujeme si pomocnou promenou ktera nam pomuze prohodit 2 cisla mezi sebou 

            tmp = a;
            a = b;
            b = tmp;
            Console.WriteLine("Nyní je hodnota x:{0} a hodnota y:{1}", a, b);
            Console.ReadLine();
        }
        static void Vymena2(ref int a, ref int b)//Pote prohodime jednu globalni promenou s promenou v Mainu a postupujeme stejne 
        {
            operace++;
            prirazeni++;
            Console.WriteLine(" Nyní priradíme hodnote z:{0} hodnotu y:{1}", b, a);
            int tmp;

            tmp = b;
            b = a;
            a = tmp;
            Console.WriteLine("Nyní je hodnota z:{0} a hodnota y:{1}", b, a);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            int z = 6;

            Porovnani();//Volání vsech funkci
            GlobalniPorovnani();
            Vymena1(ref x,ref y);
            Vymena2(ref y,ref z);


            Console.WriteLine("Celkem jsme provedli {0} operace a {1}x jsme prirazovali a {2}x jsme porovnavali", operace,prirazeni,porovnani);//Výpis  kolik jsme provedli operaci a jake to jsou
            Console.WriteLine("Děkuji za spolupraci,Nashledanou");
            Console.ReadLine();//Konec Programu 


        }
    }
}
