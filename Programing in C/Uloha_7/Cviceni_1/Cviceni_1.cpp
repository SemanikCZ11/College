// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

//Uloha_2 Napi�te program, kter� v zadan�m souboru vyhled� a zahv�zdi�kuje nevhodn� slova, kter� jsou ulo�en� v jin�m souboru - slovn�ku

#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
	FILE* f_soubor = fopen("Text.txt", "r");//otevreni souboru pro text a slovnik
    FILE* s_soubor = fopen("Slovnik.txt", "r");
    if (f_soubor == NULL || s_soubor == NULL)// zkontlolujeme jestli  neni prazny nebo neexistujici soubor
    {
        printf("Soubor se nepodarilo otevrit pro cteni, zkontrolujte prosim zda existuje nebo nen� pr�zdn�.\n");
        return 1;
    }
     int i = 0;
     char buffer[15];
     char buffers[15];
     int pointer = 0,citac=0;

     while (fscanf(f_soubor, "%s", buffer) != EOF)//p�ecteni slova a ulozeni do buffru
     {
         citac = 0;
         pointer = 0;
         fseek(s_soubor, 0, SEEK_SET);// vrac�m pointer ve slovn�ku na zacatek 

         while (fscanf(s_soubor, "%s",buffers)!= EOF)//p�ecteni slovniku po slovech a ulozeni do buffru EOF nedo�lo k chyb�
         {
             for (i = 0;buffer[i] !='\0';i++)// cyklus kter� pom�h� jestli jsou slova stejn�
             {
                 if (buffer[i] == buffers[i])
                 {
                     citac= citac + 1;
                     continue;
                 }
                 else break;


             }

             if (citac >=4)// predpoklad �e kdy� u� jsou slova stejn� schoduji se ve v�ce jak 4 parametrech 
             {
                 printf("*%s ", buffer);// vyps�ni s hv�zdickou
                 pointer = 1;
                 break;
             }
             else continue;

         }
          if(pointer==0) printf("%s ", buffer);// vyps�n� normalne

     }
     printf("\n");

    //fclose(f_soubor);

    if (fclose(f_soubor) && fclose(s_soubor) == EOF)// zav�eni souboru 
    {
        printf("Soubory se nepodarilo uzavrit.");
        return 1;
    }

    return (0);

    // neohrabany kod, mu�e zp�sobyt zpoustu chyb,nen� o�et�ena velk� mal� pismena, a mo�nost podobn�ch slov 
}





