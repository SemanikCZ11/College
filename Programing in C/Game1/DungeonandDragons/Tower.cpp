#include "DungeonandDragons.h"

void Tower_floor_loop(struct Location* current_location, struct Inventory* playerInventory) {


    struct Location
        secret_door1,
        secret_door2,
        office,
        tower_entrance;

    char input[MAX_INPUT];
    int counter = 0; // pocita mi první vchod do mistnosti abych mohl pokracovat dal
    int dizaster = 0;
    int flow = 0;
    secret_door2.button = 0;
    int oldboots = 0;
    int snitch = 0;
   
    struct Location* global_current_locationP3 = &tower_entrance;

    // definice Majordoma
    struct Majordomus {
        const char* riddle;// otazka 
        const char* answer;//odpoved
        int hasAsked;

    };


    while (1) {

            if (counter == 0) {
                if (flow != 0) {
                    print_location(current_location);// Podívám se do funkce kde jsem print description
                }
                printf("\nCo chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets naètení øetezce  inputu a nastavení maximalního poètu znakù , stdin pro ètení vstupních daz z klavesnice

                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {

                    if (!secret_door2.back) {
                        printf("\nDvere primo predemnou jsou doslova zapecetene, zadna klicova dirka skoro zadny otvor --Jsou tohle vubec dvere--??");
                        dizaster = 1;
                    }
                    else if (secret_door2.back) {

                        printf("\nKdyz jsem pristoupil znova pred dvere , zaznekl hlas a dvere najednou zmizeli a objevil se pruchod,s velikou opatrnosti vstupuji dovnitr");
                        current_location = current_location->forward;
                        global_current_locationP3 = &secret_door1;
                        dizaster = 0;

                    }
                
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    current_location = current_location->left;
                    global_current_locationP3 = &secret_door2;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    current_location = current_location->right;
                    global_current_locationP3 = &office;
                    dizaster = 0;

                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    dizaster = 0;
                    if (global_current_locationP3 == &tower_entrance)break;
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(playerInventory);
                    continue;
                }
                else {
                    printf("Nerozumím tomu pøíkazu.\n");
                }
                if (dizaster == 0) {
                    counter = 1;
                    print_location(current_location);// Podívám se do funkce kde jsem 
                    flow = 1;
                }
            }
            //pokudd chcete skonèit hru
            else if (strncmp(input, "konec", 5) == 0) {
                break;
            }
            else {

                printf("Co chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets naètení øetezce  inputu a nastavení maximalního poètu znakù , stdin pro ètení vstupních daz z klavesnice

                // strncmp porovnává input se stringem pokud se rovnají ve všech charech provede se mužu specifikovat kolik znakù chci
                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    if (global_current_locationP3 == &secret_door2 && !secret_door2.button && hasItemInInventory(playerInventory,10))
                    {
                        printf("%s\n", current_location->forward_description);
                        printf("\nMuzes zkusit obetovat susenku, prece jenom jidlo je popvazovano za nejcenejsi poklad Hmm blazniva myslenka\n\n ");
                        printf("4(Obetovat) - obetovat susenku");

                    }
                    else if (global_current_locationP3 == &secret_door2 && !secret_door2.button) printf("%s\n", current_location->forward_description);
             
                        
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    if (global_current_locationP3 == &secret_door2 && secret_door2.button && snitch==0)
                    {
                        oldboots = 1;
                        printf("\nPred tebou na stojanu stoji boty, ne nejak moc pekne , ale zvalstne sviti bud to je vezmju a nebo se  podivam  jeste na druhou stranu\n\n");
                        printf("\nMuzes vzit boty -- ANO nebo jit zpet ");

                    }
                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && snitch == 1)
                    {
                        printf("\nVzal jsi si zlatonku to co bylo tady uz zmizelo\n\n");

                    }
                    else if(global_current_locationP3 == &secret_door1 || global_current_locationP3 == &office) printf("%s\n", current_location->left_description);
           
                   
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    
                    if (global_current_locationP3 == &secret_door2 && secret_door2.button && oldboots == 0)
                    {
                        snitch = 1;
                        printf("\nPred tebou na stojanu stoji  zlatonka krásna leskla , urcite dost cenna , to hned beru i kdyz, co kdyz je na druhe strane neco lepsiho!!!!!\n\n");
                        printf("\nMuzes vzit zlatonku -- ANO nebo jit zpet ");

                    }
                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && oldboots == 1)
                    {
                        printf("\nVzal jsi si stare boty to co bylo tady uz zmizelo\n\n");

                    }
                    else if (global_current_locationP3 == &secret_door1 || global_current_locationP3 == &office) printf("%s\n", current_location->right_description);
                        
                }
                else if (strncmp(input, "obetovat", 8) == 0)
                {
                    printf("\nVlozil jsi susenku doi nadoby a zavrel, pokusil jsi se zase zmacknout tlacitko a najednou v obou stranach mistnosti"
                        "ze zdi vyjeli dlouhe piliøe a na kazdem znich byl nejaky predmet, na kameni se objevilo POUZE JEDNU VEC JSI MUZES VZIT, mel bych se podivat bliz co tam najdu!!");
                    secret_door2.button = 1;
                }
                else if (strncmp(input, "ano", 3) == 0) {
                    if()

                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    printf("\nTak stojis uprosted ovalne mistnosti Tak co ten popklad??\n\n"
                        "1(jdi dopredu) - Tajne dvere\n"
                        "2(jdi doprava) - Office\n"
                        "3(jdi doleva)  - Tajne Dvere\n");
                    counter = 0;// counter na mistnost když do ni jdu poprve
                    global_current_locationP3 = &tower_entrance;
                    flow = 0;
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(playerInventory);// podivam se jestli mám neco v inventari
                    continue;

                }
                else {
                    printf("Nerozumím tomu pøíkazu.\n");
                }
            }
    }

}