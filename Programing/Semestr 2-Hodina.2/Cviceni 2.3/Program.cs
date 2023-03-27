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

namespace Cviceni_2._3
{                      /* A)Napište funkci,která ze spojového seznamu odstraní všechny prvky,jejichž hodnota je schodná se zadanou hodnotou. Hotovo - 3 Body
                          B)Napište fuhnkci,která obrátí prvky ve spojovém seznamu(za použití jednoho průchjodu) Hotovo - 3 body
                          C)Napište funkci ,která ve spojovém seznamu uspořádá prvky vzestupně. Hotovo - 3.body
                          D)Napište funkci, která ve spojovém seznamu prohodí první a poslední prvek. Hotovo - 2 Body
                          E)Napište funkci která prohodí předposlední prvek a druhy prvek ... */
    class Program
    {
        class SeznamDB
        {
            public int data;
            public SeznamDB prev;
            public SeznamDB next;

        }
        static SeznamDB Create(int x)
        {
            SeznamDB vys = new SeznamDB();
            vys.data = x;
            vys.next = vys.prev = null;
            return vys;
        }
        static SeznamDB ConvertArray(int[] pole)
        {
            int i;
            SeznamDB vys, akt, tmp;
            if (pole.Length == 0) return null;
            vys = akt = null;

            for (i = 0; i < pole.Length; i++)
            {
                tmp = Create(pole[i]);
                tmp.prev = akt;
                if (vys == null) vys = akt = tmp;
                else akt = akt.next = tmp;
            }
            return vys;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        static void Odtraneni(SeznamDB s, int x)//Funkce pro odstanění prvku (Cviceni A)
        {
            SeznamDB now;
            if (x == s.data) s = s.next;//Pokud je hledaná hodnota na začátku seznamu

            for (now = s; now != null; now = now.next) //Průchod seznamem a hledání stejného prvku a jeho odstranění                
                if(now.data == x) now.prev.next = now.next;             
            Vypis(s);
        }
        static void Trideni(SeznamDB s,int delka)//Funkce pro třídění vzestupně C)
        {
            SeznamDB now;
            int[] pole=new int[delka];
            int i=0,j,akt;
            for (now = s; now != null; now = now.next)
                pole[i++] = now.data;

            for(i=0;i<pole.Length;i++)//Insertion Sort
            {
                akt = pole[i];
                for (j = i; (j > 0) && pole[j - 1] > akt; j--)
                    pole[j] = pole[j - 1];
                pole[j] = akt;
            }
           SeznamDB s2 = ConvertArray(pole);//Vytvářím nový seznam ze tříděného pole


                Vypis(s2);


        }
        static void Obracene(SeznamDB s)// Funkce pro obracení seznamu B
        {
            SeznamDB now,last=null;
            for (now = s; now != null; now = now.next)
                if (now.next == null) last = now;

                Vypis2(last);
        }
        static void Prohod(SeznamDB s)//Prohození prvniho a posledního prvku cvičení D
        {         
            SeznamDB now, last = null,tmp,tmp1;
            for (now = s; now != null; now = now.next)// prvním průchodem seznamu najdu poslední prvek
                if (now.next == null) last = now;
           
            tmp= Create(last.data);//přiřadím první a poslední prvek do tmp
            tmp1 = Create(s.data);
            tmp.next = s.next;//Posledni prvek vložím na začátek seznamu
            
            for (now = s = tmp; now != null; now = now.next)//projdu znovu seznam s posledním prvkem na začátku 
                if (now.next == null) now.data = tmp1.data;
            Vypis(s);
        }

        static void Vypis(SeznamDB s)// Funkce pro výpis Seznamů..
        {
            SeznamDB now;
            
            for (now = s; now != null; now = now.next)
                Console.Write(now.data+" ");
            Console.WriteLine();

        }
        static void Vypis2(SeznamDB s)// Funkce pro výpis obraceného seznamu.
        {

            SeznamDB now;
            for (now = s; now != null; now = now.prev)
                Console.Write(now.data + " ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[] pole = { 8, 11, 58, 69, 115, 8, 159, 3, 5, 8, 66, 2 };
            SeznamDB s1 = ConvertArray(pole);
            Console.WriteLine("Pole pro Příklady-{ 8, 11, 58, 69, 115, 8, 159, 3, 5, 8, 66, 2 }-");
            //Odtraneni(s1, 8);
            //Trideni(s1,pole.Length);
            //Obracene(s1);
            Prohod(s1);
            Console.ReadLine();
        }
    }
}
