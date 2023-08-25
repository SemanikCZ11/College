#include "Patro1.h"
#include "DungeonandDragons.h"

void first_floor_loop(struct Location* current_location, struct Inventory* playerInventory) {


    struct Location
        stairs1,
        laundry,
        servant_room,
        stairs2,
        entrance;

    struct Location* current_locationP1 = current_location;

    char input[MAX_INPUT];
    int counter = 0; // pocita mi prvn� vchod do mistnosti abych mohl pokracovat dal
    int dizaster = 0;
    int flow = 0;

    printf("Adresa current_location v PATRO1.cpp: %p\n", (void*)current_locationP1);
    if (current_locationP1 == &entrance)printf("ahoj");

    while (1) {

        if (current_locationP1 == &stairs2) {

            printf("test");
        }
        else {


            if (counter == 0) {
                if (flow != 0) {
                    print_location(current_location);// Pod�v�m se do funkce kde jsem print description
                }
                printf("\nCo chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets na�ten� �etezce  inputu a nastaven� maximaln�ho po�tu znak� , stdin pro �ten� vstupn�ch daz z klavesnice

                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    current_location = current_location->forward;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    current_location = current_location->left;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {

                    if (!hasItemInInventory(playerInventory, 9)) {
                        printf("\n Zaklepes na dvere a pokojska ti rekne ze je vstup pouze pro zamestnannce a zabouchne dvere\n\n");
                        dizaster = 1;
                    }
                    else {
                        current_location = current_location->right;
                        dizaster = 0;
                    }
                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    dizaster = 0;
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(playerInventory);
                    continue;
                }
                else {
                    printf("Nerozum�m tomu p��kazu.\n");
                }
                if (dizaster == 0) {
                    counter = 1;
                    print_location(current_location);// Pod�v�m se do funkce kde jsem 
                    flow = 1;
                }
            }
            //pokudd chcete skon�it hru
            else if (strncmp(input, "konec", 5) == 0) {
                break;
            }
            else {

                printf("Co chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets na�ten� �etezce  inputu a nastaven� maximaln�ho po�tu znak� , stdin pro �ten� vstupn�ch daz z klavesnice

                // strncmp porovn�v� input se stringem pokud se rovnaj� ve v�ech charech provede se mu�u specifikovat kolik znak� chci
                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    if(current_location == &laundry && hasItemInInventory(playerInventory,11)){

                        printf("\nZamyslis se ze jsi na�el kvetinu a zeny kvetiny radi, tak ji nabydnes slecne jestli by prece jenom nezmenila nazor, podav�s slecne kvetinu ta m� obrovskou radost a souhlasi\n\n");
                        addItemToInventory(playerInventory, 9);
                        removeItemFromInventory(playerInventory, 11);
                    
                    }
                    else if (current_location == &laundry) {
                        printf("%s\n", current_location->forward_description);
                    }
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    printf("%s\n", current_location->left_description);
                   
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    printf("%s\n", current_location->right_description);

                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    counter = 0;// counter na mistnost kdy� do ni jdu poprve
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(playerInventory);// podivam se jestli m�m neco v inventari
                    continue;

                }
                else {
                    printf("Nerozum�m tomu p��kazu.\n");
                }
            }
        }
    }
    
}