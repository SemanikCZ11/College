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
#include <stdlib.h>
//_________________________________ Jednosm�rn� SEZNnam________________________SSS

typedef struct JEDNOSMER { 
    int data;  // Hodnota datoveho prvku
    struct JEDNOSMER* next; // ukazatel dal�ich prvk�
} JEDNOSMER;

typedef struct SEZNNAM {
    JEDNOSMER* start; // ukazatel na prvni prvek
} SEZNNAM;
//_________________________________________________________________



//----------------------------------- Obousm�rna Struktura--------------
typedef struct SEZN {
    int data;
    struct SEZN* prev; // ukazatel na p�edchudce 
    struct SEZN* next; // ukazatel na Nasledovnika
} SEZN;

typedef struct OBOUSMER {
    SEZN* zac;  // ukazatel na prvn� prvek
    SEZN* posled; // ukazatel na posledn� prvek
} OBOUSMER;
//-----------------------------------------------------------------------------------


void NastOBOUSMER(OBOUSMER* list) { // nastaven� hodnot na NULL
    list->zac = NULL; 
    list->posled = NULL;
}

void NastavSEZNnam(SEZNNAM* ukaz) { // Ukazatel na strukturu 
    ukaz->start = NULL;
}

// P�id�v�n� hodnot do SEZNnamu
void insert(SEZNNAM* ukaz, int data) {
    JEDNOSMER* newJEDNOSMER = (JEDNOSMER*)malloc(sizeof(JEDNOSMER));
    newJEDNOSMER->data = data; // P�id�n� dat
    newJEDNOSMER->next = NULL;// Dal�i je null

    if (ukaz->start == NULL) {// Pokud zadavame prvn� prvek �ad� se na za�atek SEZNnamu
        ukaz->start = newJEDNOSMER;
    }
    else {// pokud p�id�v�me nov� prvek a SEZNnam u� nen� pr�zdn�
        JEDNOSMER* current = ukaz->start;
        while (current->next != NULL) {
            current = current->next;
        }
        current->next = newJEDNOSMER;
    }
}
// Hled�n� Hodnoty 
JEDNOSMER* find(SEZNNAM* ukaz, int data) {
    JEDNOSMER* current = ukaz->start; // koukneme se na za��tek SEZNnamu a proch�z�me postupn� dop�edu 
    while (current != NULL) {
        if (current->data == data) {
            return current;
        }
        current = current->next;
    }
    return NULL;// pokud nenajdedeme vrac�me NULL
}
// Nalezeno na Internetu Zkopirov�no !!!!!!!!!!
void deleteJEDNOSMER(SEZNNAM* ukaz, int data) {
    if (ukaz->start == NULL) {
        return;
    }

    if (ukaz->start->data == data) {
        JEDNOSMER* toDelete = ukaz->start;
        ukaz->start = ukaz->start->next;
        free(toDelete);
        return;
    }
    JEDNOSMER* current = ukaz->start;
    while (current->next != NULL) {
        if (current->next->data == data) {
            JEDNOSMER* toDelete = current->next;
            current->next = current->next->next;
            free(toDelete);
            return;
        }
        current = current->next;
    }
}

void printSEZN(SEZNNAM* ukaz) {
    JEDNOSMER* current = ukaz->start;
    while (current != NULL) {
        printf("%d ", current->data);
        current = current->next;
    }
    printf("\n");
}
/// <summary>
// Za�atek Obousm�rn�ho SEZNnamu
/// </summary>
/// <returns></returns>

void insertO(OBOUSMER* list, int data) {
    SEZN* newSEZN = (SEZN*)malloc(sizeof(SEZN));
    newSEZN->data = data;
    newSEZN->prev = NULL;
    newSEZN->next = NULL;

    if (list->zac == NULL) { // pokud je za�azen prvn� prvek 
        list->zac = newSEZN;
        list->posled = newSEZN;
    }
    else {
        newSEZN->prev = list->posled;
        list->posled->next = newSEZN;// p�edchozi prvek se stav� p�edchudcem nov�ho prvku
        list->posled = newSEZN; // p��azen� prvku nakonec
    }
}

SEZN* findO(OBOUSMER* list, int data) { //Stejn� hled�ni jako v p�ipade Jednosm�rn�ho
    SEZN* current = list->zac;
    while (current != NULL) {
        if (current->data == data) {
            return current;
        }
        current = current->next;
    }
    return NULL;
}
// Nalezeno na Internetu Zkopirov�no !!!!
void deleteSEZN(OBOUSMER* list, int data) {
    if (list->zac == NULL) {
        return;
    }

    if (list->zac->data == data) { // Hled�n� hodnoty pro smaz�n�
        SEZN* toDelete = list->zac;
        list->zac = list->zac->next;
        if (list->zac != NULL) {
            list->zac->prev = NULL;
        }
        else {
            list->posled = NULL;
        }
        free(toDelete);
        return;
    }

    SEZN* current = list->zac;
    while (current != NULL) {
        if (current->data == data) {
            SEZN* toDelete = current;
            current->prev->next = current->next;
            if (current->next != NULL) {
                current->next->prev = current->prev;
            }
            else {
                list->posled = current->prev;
            }
            free(toDelete);
            return;
        }
        current = current->next;
    }
}

void printListO(OBOUSMER* list) {// Stejn� vypisov�ni jako na jednosmernem
    SEZN* current = list->zac;
    while (current != NULL) {
        printf("%d ", current->data);
        current = current->next;
    }
    printf("\n");
}

int main() {
    SEZNNAM ukaz;
    NastavSEZNnam(&ukaz);

    insert(&ukaz, 5);// P�id�v�n� hodnot 
    insert(&ukaz, 20);
    insert(&ukaz, 22);
    insert(&ukaz, 18);
    insert(&ukaz, 11);

    printf("SEZNnam: ");
    printSEZN(&ukaz);

    JEDNOSMER* found = find(&ukaz, 20);

    if (found != NULL) {
        printf("Nalezeno v SEZNnamu Cislo: %d\n", found->data);
    }
    else {
        printf("Zadan� hodnota nen� v SEZNnamu.\n");
    }

    deleteJEDNOSMER(&ukaz, 18);//SMazani �isla

    printf("Novy SEZNnam:  ");
    printSEZN(&ukaz);
    
 //-------------------------------------------------
    OBOUSMER list;
    NastOBOUSMER(&list);

    insertO(&list, 18);
    insertO(&list, 200);
    insertO(&list, 5);
    insertO(&list, 158);
    insertO(&list, 13); 
    insertO(&list, 20);

    printf("Obousmer: ");
    printListO(&list);

    SEZN* foundO = findO(&list, 20);
    if (foundO != NULL) {
        printf("Found: %d\n", foundO->data);
    }
    else {
        printf("Nenalezeno.\n");
    }

    deleteSEZN(&list, 20);

    printf("Obousmer po Delete: ");
    printListO(&list);

    return 0;
}
