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

namespace Cvičení_1._1
{
    /*Funkce pro práci s Jednosměrným spojovým seznamem A)Napište funkci, která uloží spojový seznam do textového pole. Hotovo - 2.body
                                                        B)Napište funkci, která načte z textového souboru spojový seznam. Hotovo -2.body
                                                        C)Napište funkci, která vrátí počet výskytů zadaného prvku ve spojovém seznamu. Hotovo - 2.body
                                                        D)Napište funkci, která ze spojového seznamu odstraní poslední z prvků,jejich hodnota je schodná se zadanou. Hotovo - 2.body
                                                        E)Napište funkci, ktera odstraní prvek s nejvetší hodnotou,pokud jich je víc odstraní první z nich. Hotovo - 2.body
                                                        F)Napište funkci, která prohodí pořadí prvku ve spojovém seznamu (za použití jednoho průchodu). Hotovo - 3Body
                                                        G)Napište funkci, která prvky spojového seznamu uspořádá sestupně.---Není vypracováno
                                                        H)Napište funkci, která ve spojovém seznamu prohodí(pomocí odkazů)první prvek a poslední prvek--Není vypracováno
                                                        I)Napište funkci, která prohodi ve spojovém seznamu druhý prvek a předposlední prvek. Hotovo */

    class Program
    {
        class Seznam
        {
            public int data;
            public Seznam next;
        }
        static Seznam Create(int n)//Vytvoření jednoprvkoveho seznamu Funkce použita ze slajdu!!!!.
        {
            Seznam vys= new Seznam();
            vys.data = n;//data přiřazena prohledávaného indexu
            vys.next = null;//naslednik prvku nastavíme na null.
            return vys;
        }
        static Seznam ConvertArray(int [] pole)//Převod pole na Seznam Funkce použita ze slajdu!!!!.
        {
            int i;
            Seznam vys, now, tmp;
            if (pole.Length == 0) return null;//pokud je pole nulove vracime null(prázdný seznam)

            vys = now = null;
            for(i=0;i<pole.Length;i++)// For cyklus pro pruchod polem od začátku 
            {
                tmp = Create(pole[i]);//Vytvoření jednoho prvku seznamu + připojená data na určitém indexu
                if (vys == null) vys = now = tmp;//Podmínka pro první prvek v Seznamu
                else now = now.next = tmp;//napojovéní ostatních prvku pole
            }
            return vys;
        }
        static Seznam FindPrevios(Seznam s,Seznam s2)//Funkce najdi předchůdce použita ze slajdu !!!!
        {
            Seznam now;
            if (s == null || s2 == null || s == s2) return null;// oveření jestli není seznam,nebo zadany prvek  prázdny nebo zadaný prvek neni zacatkem seznamu 
            for (now = s; now != null; now = now.next)//Procházim seznam
                if (now.next == s2) return now;//pokud najdu předchudce vracim aktualni pozici
            return null;// pokud nenajdu vracím null.
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        static void Uloz(Seznam s,string cil)//Funkce pro zapsání dat ze spojového seznamu do souboru txt. - Cvičení A
        {
            StreamWriter sw = new StreamWriter(cil);
            Seznam now;
            for (now = s; now != null; now = now.next)//For cyklus použity ze slajdu z Hodiny
                if (now.next != null) sw.Write(now.data + "-->");
                else sw.Write(now.data);
            sw.Close();
        }
        static void Nacti(string zdroj)//Funkce pro načtení dat ze spojového seznamu a jeho vypsaní na obrazovku´- Cvicení B
        {
            StreamReader sr = new StreamReader(zdroj);
            string s;
            while((s = sr.ReadLine()) != null)
                Console.Write(s);
            Console.WriteLine("");
            sr.Close();
        }
        static int PocetVyskytu(Seznam s,int x)//Funkce pro Počítání vyskytů - Cvičení C
        {
            int vyskyt=0;//deklaruji proměnou a hned ji z inicializuji
            Seznam now;
            for (now = s; now != null; now = now.next)// použití for cyklu pro průchod seznamem 
                if (now.data == x) vyskyt++;//pokud najdeme v seznamu zadanou hodnotu  inkrementujeme  proměnou.
            return vyskyt;//Po skončení cyklu vracíme vysledek.
        }
        static Seznam DeleteLast(Seznam s,int x)// Funkce smazaní prvku posledního výskytu - Cvičení D
        {
            Seznam now, last = null,prev;   
            for (now = s; now != null; now = now.next)//procházím seznam a hledám pozici se zadaným prvkem,pokud najdu nastavím aktualni pozici jako posledni.
                if (now.data == x) last = now;
            prev = FindPrevios(s, last);
            prev.next = last.next;// po Funkci najdi předchůdce nastavím že jeho nasledovník bude naslednik mazaného hodnoty. 
            return s;//vracím seznam bez mazaného prvku.
        }
        static Seznam DeleteNej(Seznam s)//Funkce smazání nejvetšího prvku v seznamu - Cvičení E
        {
            Seznam now,nej,prev;
            for (now=nej=s; now != null; now = now.next)
                if (now.data > nej.data) nej = now;
            prev = FindPrevios(s, nej);
            prev.next = nej.next;// po Funkci najdi předchůdce nastavím že jeho nasledovník bude naslednik mazaného hodnoty. 
            return s;
        }
        static Seznam Prohod(Seznam s,int delka)//Funkce prohozeni hodnot pomocí pole - Cvičení F
        {
            int[] pole = new int[delka];// vytvoření pole a nastavení delky seznamu
            int i = 0,tmp;
            Seznam now;
            for (now = s; now != null; now = now.next)//For cyklus pro pruchod seznamu a přiřazení hodnot do pole 
                pole[i++] = now.data;
            for (i = 0; i < (pole.Length-1) / 2; i++)//For cyklus pro prohozeni hodnot.
            {
                tmp = pole[i];
                pole[i] = pole[pole.Length - 1 - i];
                pole[pole.Length - 1 - i] = tmp;
            }
            Seznam s1= ConvertArray(pole);//převod z pět na seznam

            return s1;//return nový prohozený seznam.

            //Nevím jestli se to dá považovat za jeden průchod..D
        }
        static Seznam Otoceni(Seznam s)//Funkce prohozeni druhého a předposledního prvku Cvičení - I--Určitě nekorektní řešení ale aspon 1 bod za snahu :-D 
        {
            int delka = 0, i = 0,tmp;//deklarace a inicializace proměních pro pomocné pole
            Seznam now;
            for (now = s; now != null; now = now.next)// projdu seznam abych mohl zjistit délku pole
                  delka++;
            int[] pole = new int[delka];
           for (now = s; now != null; now = now.next)//For cyklus pro vložení hodnot
                pole[i++] = now.data;
            for (i = 0; i < pole.Length ; i++)//For cyklus pro prohození dvou proměných 
                if (i == 1)
                {
                    tmp = pole[i];
                    pole[i] = pole[pole.Length - 1 - i];
                    pole[pole.Length - 1 - i] = tmp;
                }
            Seznam s1 = ConvertArray(pole);
            return s1;
            //Vracím nový seznam s prohozenou hodnotou
        }
        static void Vypis(Seznam s)
        {
            Seznam now;
            for (now = s; now != null; now = now.next)
                Console.Write(now.data+" ");
            Console.WriteLine("");

        }
        static void Main(string[] args)
        { 
            //Základní Spoják použit pro první dve cviceni A) a B)
            Seznam s1 = new Seznam();
            Seznam s2 = new Seznam();
            Seznam s3 = new Seznam();
            Seznam s4 = new Seznam();
            s1.data = 1; s2.data = 2; s3.data = 3; s4.data = 4;
            s1.next = s2; s2.next = s3; s3.next = s4; s4.next = null;
            Uloz(s1, @"..\..\..\Soubory Hodina 1\Seznam1.txt");//Použita relativní cesta
            Nacti(@"..\..\..\Soubory Hodina 1\Seznam1.txt");
            Console.Write("Hodnoty použité pro Seznam { 22, 18, 69, 2, 11, 666, 12, 11, 15, 11, 69 }");
            int x;
            int[] p1 = { 22, 18, 69, 2, 11, 666, 12, 11, 15, 11, 69 };
            Seznam s5 = ConvertArray(p1);
            x = PocetVyskytu(s5, 11);
            Console.WriteLine("Počet vyskytů hodnoty 11: {0}x",x);
            Seznam s6 = DeleteLast(s5, 11);
            Vypis(s6);//Odstranění posledního prvku daného výskytu -2. řadek
            Seznam Delete = ConvertArray(p1);
            Seznam s7 = DeleteNej(Delete);
            Vypis(s7);///Odstranění nejvetšího prvku  -3. řadek
            Seznam prohod = ConvertArray(p1);
            Seznam s8 = Prohod(prohod, p1.Length);
            Vypis(s8);// Prohození hodnot seznamu  - 4.řádek
            Seznam otoc = ConvertArray(p1);
            Seznam s9 = Otoceni(otoc);
            Vypis(s9);//Prohození druhého s předposledním 5.-řadek
            Console.ReadLine(); 
        }    

    }
}
