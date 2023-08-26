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


    struct Majordomus majodromus = {
    "Za tim oknem neni nebe,kazdi spatri jen sam sebe. Tak co je to ??",
    "zrcadlo",
    0,
    };

    while (1) {

            if (counter == 0) {
                if (flow != 0) {
                    print_location(current_location);// Podívám se do funkce kde jsem print description
                }
                printf("\nCo chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets naètení øetezce  inputu a nastavení maximalního poètu znakù , stdin pro ètení vstupních daz z klavesnice

                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {

                    if (!secret_door2.button) {
                        printf("\nDvere primo predemnou jsou doslova zapecetene, zadna klicova dirka skoro zadny otvor --Jsou tohle vubec dvere--??\n\n");
                        dizaster = 1;
                    }
                    else if (secret_door2.button) {

                        printf("\nKdyz jsem pristoupil znova pred dvere , zaznekl hlas a dvere najednou zmizeli a objevil se pruchod,s velikou opatrnosti vstupuji dovnitr\n\n");
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
                    if (global_current_locationP3 == &secret_door2 && !secret_door2.button && hasItemInInventory(playerInventory, 10))
                    {
                        printf("%s\n", current_location->forward_description);
                        printf("Muzes zkusit obetovat susenku, prece jenom jidlo je popvazovano za nejcenejsi poklad Hmm blazniva myslenka\n");
                        printf("1(Obetovat) - obetovat susenku\n"
                            "2(utec) - jdi zpet\n");

                    }
                    else if (global_current_locationP3 == &secret_door2 && !secret_door2.button) printf("%s\n", current_location->forward_description);
                    //--------poklad
                    else if (global_current_locationP3 == &secret_door1 && hasItemInInventory(playerInventory, 12)) {

                        printf("\nKdyz nahlas vyslouvis Alarwa raimë zrcadlo se rozsviti  a zmizi a pred tebou je truhla s pokladem... Gratuluju\n\n\n ");

                    }
                    else if (global_current_locationP3 == &secret_door1 && !hasItemInInventory(playerInventory, 12) && hasItemInInventory(playerInventory, 7)) {

                        printf("%s\n", current_location->forward_description);
                        printf("\nHm sice mam vsechny kody,ale z nejakeho duvodu kdyz je zopakuji nic se nestane, majordomus mi neco rekl o zrcadlo, co zkusit to v koupelne ???\n\n");
                    }
                    else if (global_current_locationP3 == &secret_door1 && !hasItemInInventory(playerInventory, 7))printf("%s\n", current_location->forward_description);
                   // office
                    else if (global_current_locationP3 == &office && hasItemInInventory(playerInventory, 7) || hasItemInInventory(playerInventory, 12)) {

                        printf("\nDiky ze jsi si semnou zahral, zkusim pripravit dalsi hadanky, vrat se zase pozdeji\n\n");

                    }
                    else if (global_current_locationP3 == &office && !hasItemInInventory(playerInventory, 7) || !hasItemInInventory(playerInventory, 12)) printf("%s\n", current_location->forward_description);

                }
                
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    snitch = 0;

                    if (global_current_locationP3 == &secret_door2 && hasItemInInventory(playerInventory, 8)) printf("\nUz jsi si je vzal nic tu neni\n\n");

                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && snitch==0 && !hasItemInInventory(playerInventory, 13))
                    {
                        oldboots = 1;
                        printf("\nPred tebou na stojanu stoji boty, ne nejak moc pekne , ale zvalstne sviti bud to je vezmu a nebo se  podivam  jeste na druhou stranu\n\n");
                        printf("\nMuzes vzit boty -- ANO nebo jit zpet\n\n ");

                    }
                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && hasItemInInventory(playerInventory, 13))
                    {
                        printf("\nVzal jsi si zlatonku to co bylo tady uz zmizelo\n\n");

                    }
                    else if(global_current_locationP3 == &secret_door1 || global_current_locationP3 == &office || global_current_locationP3 == &secret_door2) printf("%s\n", current_location->left_description);
           
                   
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {

                    oldboots = 0;
                    if(global_current_locationP3 == &secret_door2 && hasItemInInventory(playerInventory, 13)) printf("\nUz jsi si ji vzal nic tu neni\n\n");

                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && !hasItemInInventory(playerInventory,8))
                    {
                        snitch = 1;
                        printf("\nPred tebou na stojanu stoji  zlatonka krasna leskla , urcite dost cenna , to hned beru i kdyz, co kdyz je na druhe strane neco lepsiho!!!!!\n\n");
                        printf("\nMuzes vzit zlatonku -- ANO nebo jit zpet\n\n ");

                    }
                    else if (global_current_locationP3 == &secret_door2 && secret_door2.button && hasItemInInventory(playerInventory, 8))
                    {
                        printf("\nVzal jsi si stare boty to co bylo tady uz zmizelo\n\n");

                    }
                    else if (global_current_locationP3 == &secret_door1 || global_current_locationP3 == &office || global_current_locationP3 == &secret_door2) printf("%s\n", current_location->right_description);
                        
                }
                else if (strncmp(input, "obetovat", 8) == 0)
                {
                    printf("\nVlozil jsi susenku doi nadoby a zavrel, pokusil jsi se zase zmacknout tlacitko a najednou v obou stranach mistnosti"
                           "ze zdi vyjeli dlouhe piliøe a na kazdem znich byl nejaky predmet, na kameni se objevilo POUZE JEDNU VEC JSI MUZES VZIT, mel bych se podivat bliz co tam najdu!!\n"
                            "1(jdi doleva) - Prvni sloup\n"
                            "2(jdi doprava) - Druhy sloup\n");
                    secret_door2.button = 1;
                }
                else if (strncmp(input, "ano", 3) == 0) {
                    if (snitch == 1) {

                        printf("\nRozhodl jsi se vzit zlatonku je pekna a urcite bude velmi cenna,mozna jsi ji necham!!\n\n");
                        addItemToInventory(playerInventory, 13);

                    }
                    else if (oldboots == 1) {

                        printf("\nRozhodl jsi se vzit boty,no tak snad mi budou aspon sluset hned si je dam na sebe .. Pani jako bych se vznasel!!\n\n");
                        addItemToInventory(playerInventory, 8);
                    }
                }
                else if (strncmp(input, "otazka", 6) == 0 && !majodromus.hasAsked) // Podminka pro otazku
                {

                    printf("%s\n", majodromus.riddle);// Majordomova hadanka 
                    // podminka abych mohl odpovidat na otazku nekolikrat
                    while (!majodromus.hasAsked) {

                        printf("Odpovez (nebo napis'zpet' pro navrat): ");
                        fgets(input, MAX_INPUT, stdin);
                        input[strcspn(input, "\n")] = 0; // odstranìní nového øádku z konce vstupu

                        if (strcmp(input, "zpet") == 0) {
                            printf("\nPokud se budes chtit vratit budu tu cekat!!!!!!!!\n"
                                "1(jdi dopredu) - zkusim to znovu\n"
                                "2(jdi doprava) - mel bych jit spis pro otazku ne koukat na medaile\n"
                                "3(jdi doleva)  - V knihach najdes moudrost ale Majordomus ceka\n");
                            break;
                        }
                        else if (strcmp(input, majodromus.answer) == 0) {
                            printf("\nMajordomus vynda cigaretu a  rika: 'Spravne! Zrcadlo, u zrcadla se ti zjevi prave ja'\n\n"
                                "1(jdi dopredu) - Majordomus vypada zamlkle\n"
                                "2(jdi doprava) - Tam uz jsi byl asi nic noveho\n"
                                "3(jdi doleva)  - Hoooooodne knih\n");
                            addItemToInventory(playerInventory, 7);
                            majodromus.hasAsked = 1;
                        }
                        else {
                            printf("\nDuch rika: 'To neni spravne!'\n\n");
                        }
                    }
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