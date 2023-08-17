// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

//Uloha _5 naprogramujte zásobník a implementujte funkce PUSH a POP
#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

typedef struct hodnota// struktuta pro prvek 
{
    int data;// jednotlivé hodnoty 
    struct hodnota* dalsi;// ukazatel na dalši prvek


}Hodnota;

typedef struct // struktura pro vrchol 
{
    Hodnota* vrchol;


}Zasobnik;

int Push(Zasobnik* zas, int data)// ukazatel na zasobník a pøídání prvku 
{
    Hodnota* hodnota = (Hodnota*)malloc(sizeof(Hodnota));// Vyžádání volného místa pro naší hodnotu INT
    if (hodnota == NULL) return 1;// Pokud není misto ,nebo nebyla pøidìlena pamìt 

    hodnota->data = data;// pridaváni naši hodnoty
    hodnota->dalsi = zas->vrchol;// dalši prvek ukazuje na vrchlol
    zas->vrchol = hodnota;// a naše hodnota je vrchol

    return data;
}
int Pop(Zasobnik* zas)// odebrani prvku
{
    Hodnota* hodnota = zas->vrchol;// najdeme vrchol
    if (hodnota == NULL) return 1;
    int data = hodnota->data; // ziskam data 

    zas->vrchol = hodnota->dalsi;
    free(hodnota);// uvolnim pamìt 
    return data;


}
// Vypis zasovniku po funkci POP
void printZasobnik(Zasobnik* zasobnik) {
    if (zasobnik->vrchol == NULL) {
        printf("Zasobnik je prazdny.\n");
        return;
    }

    printf("Obsah zasobniku:\n");
    Hodnota* aktualni = zasobnik->vrchol;
    while (aktualni != NULL) {
        printf("%d\n", aktualni->data);
        aktualni = aktualni->dalsi;
    }
}

int main()
{
    int i = 0,p=0;

    Zasobnik zas;

    zas.vrchol = NULL;

    for (i = 0;i <= 6;i++)// naplnení zásobníku 
    {
        p=Push(&zas, i + 2);
        printf("%d",p);// vypsání zásobníku 
    }
  
    printf("\n\n");

    printf("%d", Pop(&zas));// odebrání 3 hodnot 
    printf("%d", Pop(&zas));
    printf("%d", Pop(&zas));

    printf("\n\n");

    printZasobnik(&zas);// Vypis Upraveného zasobníku

    return 0;


}

