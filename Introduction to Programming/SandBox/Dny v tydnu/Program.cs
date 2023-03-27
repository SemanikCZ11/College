using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dny_v_tydnu
{
    class Program
    {
        enum Den
        {
            Pondeli = 1,
            Utery,
            Streda,
            Ctvrtek,
            Patek,
            Sobota,
            Nedele,

        }

        static Den NactiDen()
        {

            Den d = 0;
            Console.Write("Napis den v tydnu: ");
            d = (Den)Enum.Parse(typeof(Den), Console.ReadLine(), true);
            return d;


        }




        static void Main(string[] args)
        {

            Den d;

            d = NactiDen();
            Console.WriteLine("Den {0} je {1} dnem v tydnu", d, (int) d);
            //Console.ReadLine();

            switch (d)
            {
                case Den.Sobota:
                case Den.Nedele:
                    Console.WriteLine("Wolno");
                    break;
                case Den.Pondeli:
                    Console.WriteLine("zacatek tydne ");
                    break;
                case Den.Patek:
                    Console.WriteLine("Konec pracovniho tydne");
                    break;
                default:
                    Console.WriteLine("Prostredek pracovniho tydne");
                    break;
                  
            
     
            
            }
            Console.ReadLine();
        }
    }
}
