// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

//Uloha_2 Napište program, který v zadaném souboru vyhledá a zahvìzdièkuje nevhodná slova, která jsou uložená v jiném souboru - slovníku

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
        printf("Soubor se nepodarilo otevrit pro cteni, zkontrolujte prosim zda existuje nebo není prázdný.\n");
        return 1;
    }
     int i = 0;
     char buffer[15];
     char buffers[15];
     int pointer = 0,citac=0;

     while (fscanf(f_soubor, "%s", buffer) != EOF)//pøecteni slova a ulozeni do buffru
     {
         citac = 0;
         pointer = 0;
         fseek(s_soubor, 0, SEEK_SET);// vracím pointer ve slovníku na zacatek 

         while (fscanf(s_soubor, "%s",buffers)!= EOF)//pøecteni slovniku po slovech a ulozeni do buffru EOF nedošlo k chybì
         {
             for (i = 0;buffer[i] !='\0';i++)// cyklus který pomáhá jestli jsou slova stejná
             {
                 if (buffer[i] == buffers[i])
                 {
                     citac= citac + 1;
                     continue;
                 }
                 else break;


             }

             if (citac >=4)// predpoklad že když už jsou slova stejná schoduji se ve více jak 4 parametrech 
             {
                 printf("*%s ", buffer);// vypsáni s hvìzdickou
                 pointer = 1;
                 break;
             }
             else continue;

         }
          if(pointer==0) printf("%s ", buffer);// vypsání normalne

     }
     printf("\n");

    //fclose(f_soubor);

    if (fclose(f_soubor) && fclose(s_soubor) == EOF)// zavøeni souboru 
    {
        printf("Soubory se nepodarilo uzavrit.");
        return 1;
    }

    return (0);

    // neohrabany kod, muže zpùsobyt zpoustu chyb,není ošetøena velká malá pismena, a možnost podobných slov 
}





