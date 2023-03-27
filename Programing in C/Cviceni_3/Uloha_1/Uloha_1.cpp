// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

#include <iostream>
#include <stdio.h>
#include <conio.h>

// Uloha 1 Modulo pro reálná èísla 

void Modulo(double prvni, double druhy)
{
    double zbytek=0;// int pro celoèíselný výsledek 
    int vysledek = 0;// celoèíselný výsledek
    vysledek = prvni / druhy;//výsledek dvou realných èísel 

    zbytek = prvni - (vysledek * druhy);// zbytek po dìleni 

    printf("Modulo pro %2.2f / %2.2f = %2.2f\n", prvni, druhy, zbytek);// vypsáni hodnoty %f na dvì desetiná místa
    
}


int main()
{
    double a = 0, b = 0; // float pro realná èísla
   
    a = 2.64;
    b = 1.2;
    Modulo(a, b);// vstup do funkce s hodnotami

    return 0;

}


