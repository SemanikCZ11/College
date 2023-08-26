#include "DungeonandDragons.h"

void Second_floor_loop(struct Location* current_location, struct Inventory* playerInventory) {


    struct Location
        stairs2,
        guest_room,
        bathroom,
        tower_entrance;

    char input[MAX_INPUT];
    int counter = 0; // pocita mi první vchod do mistnosti abych mohl pokracovat dal
    int dizaster = 0;
    int flow = 0;
    int questroom = 0;
    int bath_room = 0;
    int flower = 0;

    struct Location* global_current_locationP2 = &stairs2;


    while (1) {

        if (global_current_locationP2 == &tower_entrance) {

            Tower_floor_loop(current_location, playerInventory);
            current_location = current_location->back;
            print_location(current_location);
            global_current_locationP2 = &stairs2;
            counter = 0;
        }
        else {


            if (counter == 0) {
                if (flow != 0) {
                    print_location(current_location);// Podívám se do funkce kde jsem print description
                }
                printf("\nCo chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets naètení øetezce  inputu a nastavení maximalního poètu znakù , stdin pro ètení vstupních daz z klavesnice

                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    current_location = current_location->forward;
                    global_current_locationP2 = &guest_room;
                    dizaster = 0;
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {

                    if (!hasItemInInventory(playerInventory, 4)) {
                        printf("\nI kdy  se snazis, jak se snazis bez klicu to rozhodne nepujde, chtelo by nekde nejake sehnat\n\n"
                            "Zatim se muzes porozhlednout\n "
                            "1(jdi dopredu) - Pokoj pro hosty\n"
                            "2(jdi doprava) - Koupelna\n"
                            "3(jdi doleva)  - zamceny vstup do veze\n");
                        dizaster = 1;
                    }
                    else if (hasItemInInventory(playerInventory, 4) && !hasItemInInventory(playerInventory, 2)) {
                        printf("\nPopdarilo se ti dostat pres zamcene dvere ,svazek klicu ktere jsi nasel byly uzitecne,bouzel kdyz jsi visel nahoru"
                              "tak pred dvermi je nastvany pes ktery vrci a kouka na tebe , snazis se ho obejit ale okamzite se po tobe ozene , nastesti"
                              "stihnes uskocit, ale pres toho psa se nejak musim dostat!!"
                              "1(jdi dopredu) - porozhlednoput se v pokoji\n"
                              "2(jdi doprava) - KOUPELNA hm asi ne \n"
                              "3(jdi doleva)  - Zpatky bez neceho je zbytecny\n");
                        dizaster = 1;

                    }
                    else if (hasItemInInventory(playerInventory, 4) && hasItemInInventory(playerInventory, 2))
                    {
                        printf("\nDvere jsi otevrel jako nic a pes jak videl pamlsek tak se okamzite s pratelil,moc milej pejsek, ale uz hura nahoru..");
                        current_location = current_location->left;
                        global_current_locationP2 = &tower_entrance;
                        dizaster = 0;
                    }
                   
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                        current_location = current_location->right;
                        global_current_locationP2 = &bathroom;
                        dizaster = 0;
                    
                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    dizaster = 0;
                    if (global_current_locationP2 == &stairs2)break;
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
                    if (global_current_locationP2 == &guest_room && !hasItemInInventory(playerInventory,4)) {
                        printf("%s\n", current_location->forward_description);
                        addItemToInventory(playerInventory, 4);
                        questroom = 1;
                    }
                    else if (global_current_locationP2 == &guest_room && questroom == 1)printf("\nVsechno potrebne jsem si vzal a kufry necham prozatim tady,klice mam schovane v zadni kapse!!\n\n");
                    
                    ///-------------
                    if (global_current_locationP2 == &bathroom)printf("%s\n", current_location->forward_description);
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    if (global_current_locationP2 == &guest_room && !hasItemInInventory(playerInventory, 1)) {
                        printf("%s\n", current_location->left_description);
                    }
                    else if (global_current_locationP2 == &guest_room && hasItemInInventory(playerInventory, 1)) {
                        printf("%s\n", current_location->left_description);
                        printf("\nPochvili jsem si vsiml ze jsou na stene pochodne, s tim zapalovacem co mam bych jsi mohl rozsviti ve sklepe!!\n\n");
                        addItemToInventory(playerInventory, 3);
                    }
                    else if (global_current_locationP2 == &bathroom)printf("%s\n", current_location->left_description); 
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    if (global_current_locationP2 == &bathroom && bath_room == 0) {
                        printf("%s\n", current_location->right_description);
                        bath_room = 1;
                    }
                    else if (global_current_locationP2 == &bathroom && bath_room == 1 && !hasItemInInventory(playerInventory, 12) && !hasItemInInventory(playerInventory, 11) && flower == 0) {
                        printf("\nVracis se k zrcadlum a vidis tam nove krasne kvetiny,par jich vezmes ,urcite nikomu nebudou chybet!!Zrcadlo porad divne sviti\n\n");
                        addItemToInventory(playerInventory, 11);
                        flower = 1;
                    }
                    else if (global_current_locationP2 == &bathroom && bath_room == 1 && !hasItemInInventory(playerInventory, 12) && flower ==1 && !hasItemInInventory(playerInventory, 5) || !hasItemInInventory(playerInventory, 6) || !hasItemInInventory(playerInventory, 7)){
                        printf("\nVracis se k zrcadlum je tam jenom dira po sebranych kvetinach:-D!!\n\n");
                      
                    }
                    else if (global_current_locationP2 == &bathroom && bath_room == 1 && !hasItemInInventory(playerInventory, 12) && flower == 1 && hasItemInInventory(playerInventory, 5) && hasItemInInventory(playerInventory, 6) && hasItemInInventory(playerInventory, 7)) {
                        printf("\nWoW to svitici zrcaldlo mi spojilo vsechny kody dohromady jako by vedelo co ma udelat , po skonceni zrcadlo ztmavlo a najednou je stejne jako vsechny ostatni\n\n");
                        addItemToInventory(playerInventory, 12);
                        removeItemFromInventory(playerInventory, 5);
                        removeItemFromInventory(playerInventory, 6);
                        removeItemFromInventory(playerInventory, 7);
                    }
                    else if (global_current_locationP2 == &guest_room) printf("%s\n", current_location->right_description);

                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    printf("\nTak stojis u shodu a nevic co dal??\n\n"
                        "1(jdi dopredu) - Tvuj pokoj\n"
                        "2(jdi doprava) - Koupelna\n"
                        "3(jdi doleva)  - Shody do veze\n");
                    counter = 0;// counter na mistnost když do ni jdu poprve
                    global_current_locationP2 = &stairs2;
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

}