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
//Uloha_1 Setøidte pole minimem ( Bubblesort,margesort,quicksort..)
// Uloha _2 Najdìte medián v setøídìném poli

/*
int Bublinka(int pole[], int length)
{
    int i=0, j=0, temp=0;

    
    for (i = 0; i < length; i++)// Vnejsi cyklus pro kontrolu pole
    {
        
        for (j = 0; j < length - i; j++)// Vnitrni cyklus porovnáva prvky
        {
           
            if (pole[j] > pole[j + 1])// if pokud je cislo s indexem  vetsi nez následující ,prvky se prohodí
            {
                temp = pole[j];
                pole[j] = pole[j + 1];
                pole[j + 1] = temp;
            }
        }
    }
    return 0;
}
*/

int quick(int pole[], int prvni, int posledni)
{
    int i =0, j = 0, pivot = 0, temp = 0;// deklarujeme promìné 

    if (prvni < posledni)// podminka pro nastavení pivota neboli hodnoty se kterou budeme porovnávat
    {
        pivot = prvni;// nastavíme pivota jako první prvek s indexem 0
        i = prvni;// i = leví pointer nastavíme na zaèátek 
        j = posledni;// j = pravý pointer nastavíme na konec 

        while (i < j)// podminka pokud je levý pointr menší než pravý 
        {
            while (pole[i] <= pole[pivot] && i < posledni) i++;// posunuti levého ukazatele 
            while (pole[j] > pole[pivot])j--;// posunuti pravého ukazatele 
            if (i < j)// potvrzení podmínky 
            {
                temp = pole[i];// prohazování prvkù 
                pole[i] = pole[j];
                pole[j] = temp;

            }

        }

        temp = pole[pivot];// usazení pivota na místo
        pole[pivot] = pole[j];
        pole[j] = temp;

        quick(pole, prvni, j - 1);// rekurzivní voláni na prvky menší nez pivot 
        quick(pole, j + 1, posledni);// rekurzivní volání na prvky vetsí nez pivot 
    }


    return 0;
}
void median(int p2[], int delka)// funkce pro median
{
    int li = 0, pi = 0, p = 0;

    if (delka % 2 == 0)// pokud je pole se sudým poètem prvkù 
    {
        li = (delka-1) / 2;// najdeme levý prvek (musíme snížit delku o 1)
        pi = li + 1;// najdeme pravý prvek
        //printf("%d", p2[li]);
        //printf("%d", p2[pi]);
        p = (p2[li] + p2[pi]) / 2;// spoèteme arytmetický prumìr
    }
    else// pokud je lichý poèet median je prostøední prvek
    {
        p = delka / 2;
        p = p2[p];
    }
    printf("MEDIAN pro pole je %d\n", p);// výpis

}
void vypispole(int p[], int delka)// vypis pole
{
    int i = 0;
    printf("pole\n");
    for (i = 0;i < delka;i++)printf("index %d -- %d\n", i, p[i]);

}

int main()
{   
    const int p = 8;
    int pole[p] = { 5, 28,3,11,1,8,16,9,};// inicializace pole

    /*vypispole(pole, p);
    Bublinka(pole, 0, p - 1);
    vypispole(pole, p);
    median(pole, p);*/


    vypispole(pole, p);
    quick(pole, 0, p - 1);
    vypispole(pole, p);
    median(pole, p);

    return 0;
}


