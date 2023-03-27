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

namespace Cviceni_4._7
{
    class Program
    {    

        // Skalarni soucin dvou vektoru cviceni 4.7

        static void VypisVektorU(int [] pole)//Funkce pro výpis prvního vektoru
        {
            int i;
            
            for (i = 0; i < pole.Length; i++)
                Console.Write("{0},",pole[i]);
                
        }
        static void VypisVektorV(int []pole)// Funkce pro výpis druheho vektoru
        {

            int i;
            Console.WriteLine("");
            for (i = 0; i < pole.Length; i++)
                Console.Write("{0},", pole[i]);


        }
        static int SkalarniSoucin(int[] pole,int[] pole1)// Funkce pro soucin jednotlivých složek vektoru pro skalarní soucin
        {

            
            int i, soucin =0,tmp =0;

            for(i = 0;i < pole.Length;i++)
            {
                if (pole.Length == pole1.Length)// vektory musí být vždy steneho typu
                {
                    soucin = pole[i] * pole1[i];
                    soucin = soucin + tmp;
                    tmp = soucin;
                }
               
            }


            return soucin;// Vracím hodnotu skalarního soucinu

        }

        static void Main(string[] args)
        {
            
            int[] u = { 6, 3, 5, 0, 4 };//první vektor
            int[] v = { 1, -3, -5, -3, 6};//druhy vektor

            VypisVektorU(u);//Vstupy do funkcí
            VypisVektorV(v);

           int soucin = SkalarniSoucin(u, v);//Inicializace vysledku soucinu 

            Console.WriteLine("= {0} (Skalarni soucin vektoru)", soucin);// Vypsání na obrazovku 
            Console.ReadLine();


        }
    }
}
