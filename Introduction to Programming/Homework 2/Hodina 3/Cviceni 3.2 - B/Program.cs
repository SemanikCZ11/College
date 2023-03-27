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

namespace Cviceni_3._2___B
{
    class Program
    {

        // BMI s vyčtovym typem cviceni 3.2 - B
        enum BMI// Vyčtový typ pro BMI
        {
            Tezkapodviziva = 1,
            podvaha ,
            optimalnivaha,
            nadvaha ,
            obezitaprvnihostupne,
            obezitaduhehostupne,
            obezitatretihostupne,

        }
        static int NactiVahu()//Nactu vahu bez parametru požadam uživatele o zadani a vratim hodnotu
        {

            int x;
            Console.Write("Zadejte prosim Vasi vahu: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;
            
        }
        static int NactiVysku()//Nactu vyšku v Cm bez parametru požadam uživatele o zadani a vratim hodnotu
        {

            int x;
            Console.Write("Zadejte prosim Vasi výšku v Cm: ");
            x = Convert.ToInt32(Console.ReadLine());

            return x;

        }
        static void SpocitejBmi()// Nejprve spočitam BMI hodnotu
        {
            
            double x, y, vys;

            y = NactiVysku();
            x = NactiVahu();

            vys = x / ( 2*( y / 100));
           
            Console.WriteLine("Vase BMI je {0:N1}", vys);// Vypíšu jeji hodnotu
            // Pomoci If zjistim Vyčtovy typ a vypíši

            if (vys <= 16.5) Console.WriteLine("..{0}..", BMI.Tezkapodviziva);
            if ((vys > 16.5) && (vys <= 18.5)) Console.WriteLine("..{0}..", BMI.podvaha);
            if ((vys > 18.5) && (vys <= 25)) Console.WriteLine("..{0}..", BMI.optimalnivaha);
            if ((vys > 25 )  && (vys <= 30)) Console.WriteLine("..{0}..", BMI.nadvaha);
            if ((vys > 30)  && (vys <= 35)) Console.WriteLine("..{0}..", BMI.obezitaprvnihostupne);
            if ((vys >35)  && (vys <= 40))  Console.WriteLine("..{0}..", BMI.obezitaduhehostupne);
            if (vys > 40) Console.WriteLine("..{0}..", BMI.obezitatretihostupne);
        }
        

        static void Main(string[] args)
        {

           SpocitejBmi();
           Console.ReadLine();//pockam na klavesu Enter

        }
    }
}
