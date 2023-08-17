// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

// Uloha 3 -	Modifikujte program z (2), tak aby jeho návratovou hodnotou byl poèet znakù 
#include <iostream>
//#include <stdio.h>
//#include <conio.h>

int prvnislovo()
{
	return printf("Hello");
}

int druheslovo()
{
	return printf(" World\n");
}
int main(int argc, char** argv)
{
	int x = 0;
	int y = 0;

	x = prvnislovo();
	y = druheslovo();

	printf("Pocet znaku v retezci je %d\n", x+y);
	
	return 0;
}
