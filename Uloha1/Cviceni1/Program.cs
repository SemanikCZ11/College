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
using System.Threading;
using System.Threading.Tasks;

//Vytvořte program demonstrující vícevláknové programování minimalně 3 vlakna 

namespace Cviceni1
{
    class Program
    { 
        
        // NENI MOJE TVORBA
        public delegate void ThreadStart();
        public object Lock = new object();
        private static int pocetS = 0;

        public void PrintSmile()
        {
            
            lock (Lock)
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.Write("*:-D :-D, ");
                    Thread.Sleep(10);
                    pocetS =pocetS +1;
                }
            }
        }
        // testovaci metoda
        public void PrintCharacter()
        {
           
            for (int j = 0; j <= 3; j++)
            {
               
                Console.Write("**:-d ,");
                Thread.Sleep(100);
                pocetS = pocetS - 1;
            }
        }

        private void IcreaseSmile()
        {
            // Protoze pracujeme s globalni promennou, pouzijeme zamek
            lock (Lock)
            {
                Console.Write("***:-) ,");
                Thread.Sleep(1000);
                pocetS = pocetS + 1;

            }
        }
        private void DecreaseSmile()
        {
                Console.Write("****:-@ ,");
                pocetS = pocetS - 1;
            
        }
        public void Vlakna()
        {
            // Vytvorime si vlakna 
            Thread thread1 = new Thread(IcreaseSmile);
            Thread thread2 = new Thread(DecreaseSmile);
            Thread thread3 = new Thread(IcreaseSmile);
            Thread thread4 = new Thread(DecreaseSmile);
            Thread thread5 = new Thread(IcreaseSmile);

            thread1.Name = "Smich";
            thread2.Name = "Smutek";
            thread3.Name = "Smich";
            thread4.Name = "Smutek";
            thread5.Name = "Smich";

            // Spustime vlakna
            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

            // Pro test spustime take metody samostatne v hlavnim vlaknu
            PrintSmile();
            PrintCharacter();
            
        }
        static void Main(string[] args)
        {

            Thread.CurrentThread.Name = "Head Thread";
            Console.WriteLine(Thread.CurrentThread.Name);

            for (int i = 0; i < 10; i++)
            {

                Program run = new Program();
                run.Vlakna();
                
            }
            Console.WriteLine("\nHotovo");

            if (pocetS > 1) Console.WriteLine("Vic jsme se usmivali");
            else Console.WriteLine("Vic se mracime");

            Console.ReadLine();
        }

    }
}
    

