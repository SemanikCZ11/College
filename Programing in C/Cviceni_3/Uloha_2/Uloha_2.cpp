// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

#include <iostream>
#include <conio.h>
#include <stdio.h>

// Uloha 2 z uvedených hodnot spoète prùmìr a najde nejvetší tøetí prvek

int prvek(int pole[], int delka, int nej)// pro pole s menšími hodnotami 
{
    int iterace = 0,i=0;// deklarace s inicializací

    while (iterace < 2)// cyklus preo hledání 3 nejmenšího prvku
    {
        nej = nej + 1;// umìlé navýšení minimální hodnoty

            for (i = 0;i < delka;i++)// procházení pole
            {

                if (pole[i] == nej)// pokud narazí na 2 nejmenší prvek 
                {
                    nej = pole[i];
                    iterace++;// zvetšení iterace 
                    break;
                }
                else continue;
            }
    }

    return nej;// vracená hodnota prvku
}

int main()
{ 
    const int p = 7;//velikost pole == Const promìná a hodnota není možné upravit
    int pole[p] = {1, 2, 8, 12, 1, 45, 11};// inicializace pole 
    double arprumer = 0;// Pro aritmeticky prumìr 
    int nejmensi = 1,hledane=0,i=0;

    for (i = 0; i < p; i++)// For cyklus na hledáni prumìru
    {
       if(pole[i] <= nejmensi)nejmensi = pole[i];// Hledáni nejmenšího prvku 
        arprumer = pole[i] + arprumer;

    }
    arprumer = arprumer / p;// aritmetický prumìr

    printf("Aritmeticky prumer je %2.2f\n", arprumer);

    hledane = prvek(pole, p,nejmensi);// vstup do funkce pro hledání prvku

    printf("Treti nejvetsi cislo je %d\n", hledane);

    return 0;
}


