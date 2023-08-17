// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

//Uloha _5 naprogramujte z�sobn�k a implementujte funkce PUSH a POP
#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

typedef struct hodnota// struktuta pro prvek 
{
    int data;// jednotliv� hodnoty 
    struct hodnota* dalsi;// ukazatel na dal�i prvek


}Hodnota;

typedef struct // struktura pro vrchol 
{
    Hodnota* vrchol;


}Zasobnik;

int Push(Zasobnik* zas, int data)// ukazatel na zasobn�k a p��d�n� prvku 
{
    Hodnota* hodnota = (Hodnota*)malloc(sizeof(Hodnota));// Vy��d�n� voln�ho m�sta pro na�� hodnotu INT
    if (hodnota == NULL) return 1;// Pokud nen� misto ,nebo nebyla p�id�lena pam�t 

    hodnota->data = data;// pridav�ni na�i hodnoty
    hodnota->dalsi = zas->vrchol;// dal�i prvek ukazuje na vrchlol
    zas->vrchol = hodnota;// a na�e hodnota je vrchol

    return data;
}
int Pop(Zasobnik* zas)// odebrani prvku
{
    Hodnota* hodnota = zas->vrchol;// najdeme vrchol
    if (hodnota == NULL) return 1;
    int data = hodnota->data; // ziskam data 

    zas->vrchol = hodnota->dalsi;
    free(hodnota);// uvolnim pam�t 
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

    for (i = 0;i <= 6;i++)// naplnen� z�sobn�ku 
    {
        p=Push(&zas, i + 2);
        printf("%d",p);// vyps�n� z�sobn�ku 
    }
  
    printf("\n\n");

    printf("%d", Pop(&zas));// odebr�n� 3 hodnot 
    printf("%d", Pop(&zas));
    printf("%d", Pop(&zas));

    printf("\n\n");

    printZasobnik(&zas);// Vypis Upraven�ho zasobn�ku

    return 0;


}

