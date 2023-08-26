#include "DungeonandDragons.h"

void first_floor_loop(struct Location* current_location, struct Inventory* playerInventory) {


    struct Location
        stairs1,
        laundry,
        servant_room,
        stairs2;

    char input[MAX_INPUT];
    int counter = 0; // pocita mi prvn� vchod do mistnosti abych mohl pokracovat dal
    int dizaster = 0;
    int flow = 0;
    servant_room.TheMaid = 0;
    int servantRoomCounter = 0;

    struct Location* global_current_locationP1 = &stairs1;// 


    while (1) {

        if (global_current_locationP1 == &stairs2) {

            Second_floor_loop(current_location, playerInventory);
            current_location = current_location->back;
            print_location(current_location);
            global_current_locationP1 = &stairs1;
            counter = 0;
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
                    global_current_locationP1 = &laundry;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    current_location = current_location->left;
                    global_current_locationP1 = &stairs2;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {

                    if (!hasItemInInventory(playerInventory, 9)) {
                        printf("\n Zaklepes na dvere a pokojska ti rekne ze je vstup pouze pro zamestnannce a zabouchne dvere\n\n");
                        dizaster = 1;
                    }
                    else if(hasItemInInventory(playerInventory, 9)) {
                        current_location = current_location->right;
                        global_current_locationP1 = &servant_room;
                        dizaster = 0;
                    }
                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    dizaster = 0;
                    if (global_current_locationP1 == &stairs1)break;
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
                    if(global_current_locationP1 == &laundry && hasItemInInventory(playerInventory,11)){

                        printf("\nZamyslis se ze jsi nasel kvetinu a zeny kvetiny radi, tak ji nabydnes slecne jestli by prece jenom nezmenila nazor, podavas slecne kvetinu ta ma obrovskou radost a souhlasi\n\n");
                        addItemToInventory(playerInventory, 9);
                        removeItemFromInventory(playerInventory, 11);
                    
                    }
                    else if (global_current_locationP1 == &laundry) {
                        printf("%s\n", current_location->forward_description);
                    }
                    ///-------------
                    if(global_current_locationP1 == &servant_room)printf("%s\n", current_location->forward_description);
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    if (global_current_locationP1 == &servant_room && servantRoomCounter == 0) {
                        printf("%s\n", current_location->left_description);
                    }
                    else if (global_current_locationP1 == &servant_room && servantRoomCounter == 1 && !servant_room.TheMaid) {
                        printf("\nMusim nejak odlakat pozornost pokojske.. ale jak OOOOOHHHHHH ChoSSe Armando umira,verila by jste tomu"
                               " Pokojska se otoci a bezi k TV sedne na kreslo a uprene se diva co se to deje.. Super necekla jsem ze to bude tak lehke\n\n");
                        servant_room.TheMaid = 1;
                    }
                    else if (global_current_locationP1 == &servant_room && servantRoomCounter == 1 && servant_room.TheMaid) {

                        printf("\nMyslim ze ta uz se od televize dneska nehne :-D, presto tady uz asi nic jineho nesvedu\n\n");
                    }
                    else if (global_current_locationP1 == &laundry)printf("%s\n", current_location->left_description);
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    if (global_current_locationP1 == &servant_room && servantRoomCounter==0) {
                        servantRoomCounter = 1;
                        printf("%s\n", current_location->right_description);

                    }
                    else if (global_current_locationP1 == &servant_room && servantRoomCounter == 1 && !servant_room.TheMaid) {
                        printf("\nSakra musim nejdriv nejak rozptilit tu pokojskou,takhle to nejde ,hned by jsi me vsimla\n\n");
                    }
                    else if (global_current_locationP1 == &servant_room && servantRoomCounter == 1 && servant_room.TheMaid && !hasItemInInventory(playerInventory, 6)) {
                        printf("\nDobre je cas se podivat na to co je uvnitr hodin, hm zajimave nejaky cast kodu super!!!\n\n");
                        addItemToInventory(playerInventory, 6);
                    }
                    else if (global_current_locationP1 == &servant_room && servantRoomCounter == 1 && servant_room.TheMaid==1 && hasItemInInventory(playerInventory, 6)) {
                        printf("\nHodiny nastesti porad bezi ale uz nic zajimaveho tu neni\n\n");
                    }
                    else if(global_current_locationP1 == &laundry) printf("%s\n", current_location->right_description);

                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    printf("\nJsi mezi Pradelnou a Pokojem zamestnancu co dal\n\n??"
                        "1(jdi dopredu) - Pradelna\n"
                        "2(jdi doprava) - Pokoj sluzebnictva\n"
                        "3(jdi doleva)  - Shody\n");
                    counter = 0;// counter na mistnost kdy� do ni jdu poprve
                    global_current_locationP1 = &stairs1;
                    flow = 0;
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