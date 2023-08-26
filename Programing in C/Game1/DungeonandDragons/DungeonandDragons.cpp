// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody 
// Nikdo me pri vypracovani neradil 
// Pokud nektery radek porusuje toto pravidlo je oznacen komentarem
// NENI MOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Lukas Semecky 36991

#include <iostream>
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <stdlib.h>
#include "Patro1.h"
#include"DungeonandDragons.h"

#define MAX_INPUT 100

//loc ukazatel na strukturu location -> přistup k atributum
void print_location(struct Location* loc) {
    printf("%s\n", loc->description);

  /*  if (loc->trap) {
        printf("Narazili jste na past! Konec hry.\n");
        exit(0);
    }
    if (loc->treasure) {
        printf("Našli jste poklad! Gratuluji!\n");
        exit(0);
    }*/
   
}

//přidání do inventáře předávám struct inventory a cislo pod kterým budu přidávat
void addItemToInventory(struct Inventory* inv, int item) {
    switch (item) {
    case 1: inv->lighter = 1; break;
    case 2: inv->treat = 1; break;
    case 3: inv->torch = 1; break;
    case 4: inv->key = 1; break;
    case 5: inv->code_part1 = 1; break;
    case 6: inv->code_part2 = 1; break;
    case 7: inv->code_part3 = 1; break;
    case 8: inv->shoes = 1; break;
    case 9: inv->disguise = 1; break;
    case 10: inv->biscuit = 1; break;
    case 11: inv->flower = 1;break;
    case 12: inv->compelet_code = 1; break;
    case 13: inv->golden_snitch = 1; break;
    }
}
//odstranění z inventaře při použití
void removeItemFromInventory(struct Inventory* inv, int item) {
    switch (item) {
    case 1: inv->lighter = 0; break;
    case 2: inv->treat = 0; break;
    case 3: inv->torch = 0; break;
    case 4: inv->key = 0; break;
    case 5: inv->code_part1 = 0; break;
    case 6: inv->code_part2 = 0; break;
    case 7: inv->code_part3 = 0; break;
    case 8: inv->shoes = 0; break;
    case 9: inv->disguise = 0; break;
    case 10: inv->biscuit = 0; break;
    case 11: inv->flower = 0;break;
    case 12: inv->compelet_code = 0; break;
    case 13: inv->golden_snitch = 0; break;
    }
}
// pokud mám v inventaři interakce pro dalši postup v mistnosti
int hasItemInInventory(struct Inventory* inv, int item) {
    switch (item) {
    case 1: return inv->lighter;
    case 2: return inv->treat;
    case 3: return inv->torch;
    case 4: return inv->key;
    case 5: return inv->code_part1;
    case 6: return inv->code_part2;
    case 7: return inv->code_part3;
    case 8: return inv->shoes;
    case 9: return inv->disguise;
    case 10: return inv->biscuit;
    case 11: return inv->flower;
    case 12: return inv->compelet_code;
    case 13: return inv->golden_snitch;
    }
    return 0; // Pokud předmět neexistuje
}
//zobrazení inventáře pokud je 1 mám v inventáři pokud je 0 nemám v inventaři a vypsani
void showInventory(struct Inventory* inv) {
    printf("Vas inventar:\n");
    if (inv->lighter) printf("- Zapalovac\n");
    if (inv->treat) printf("- Pamlsek\n");
    if (inv->torch) printf("- Pochoden\n");
    if (inv->key) printf("- Klice\n");
    if (inv->code_part1) printf("- Utrzek kodu_1\n");
    if (inv->code_part2) printf("- Utrzek kodu_2\n");
    if (inv->code_part3) printf("- Utrzek kodu_3\n");
    if (inv->shoes) printf("- boty\n");
    if (inv->disguise) printf("- prevlek\n");
    if (inv->biscuit) printf("- susenka\n");
    if (inv->flower) printf("- Kvetina\n");
    if (inv->compelet_code) printf("- Desifrovany Kod");
    if (inv->golden_snitch) printf("-Zlatonka");
}
// definice ducha
struct Ghost {
    const char* riddle;// otazka 
    const char* answer;//odpoved
    int hasAsked;

};


int main() {
    // definice lokací které mužu procházet 
    struct Location
        entrance,
        kitchen,
        cellar,
        stairs1,
        guest_room,
        servant_room,
        bathroom,
        office,
        laundry,
        stairs2,
        tower_entrance,
        secret_door1,
        secret_door2,
        treasure_room;

    // inventory hráče pro další interkaci 
    struct Inventory playerInventory { 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0, 0};// nastaveni inventare na 0 znamena ze nic po kapsach nema
    kitchen.chef_distracted = 0;// interakce s kucharem dokud ho nerozptilim nemužu se pohnout jinym smerem v kuchyni

    //----------------Vstupni hala---------------------
    entrance.description = "\nNachazi te se ve velke hale kde je celkem chladno, na strope se houpe krasny dobovy lustr, ktery porsvitil celou mistnost zlutym svetlem,neni tu moc oken,ale"
        "nachazi se tu dvoje dvere, jedny jsou stare a umastene s napisem ??K UCH NE??, ktere jsou primo predemnou a vpravo je vchod do sklepeni ktere lemuje mnoho pavucin "
        ",na leve strane je celkem ciste shodicte do dalsiho patra a uprostred spinavy cerveny koberec.\n\n"
        "1(jdi dopredu) - Kuchyne\n"
        "2(jdi doprava) - Sklep\n"
        "3(jdi doleva)  - Shody do 1 patra\n";
    entrance.forward = &kitchen;
    entrance.right = &cellar;
    entrance.left = &stairs1;

    //_____________________Kuchyne___________________________________
    kitchen.description = "\n Nachazis se v kuchyni,ten smrad je strasny, na prvni pohled vypada celkem odporne v rohu stoji kuchar, ktery kdyz jsi vesel na tebe upre svuj zrak a neco mumla. AGERDAG DGAS GTE GASD GWG."
        "Vubec nerozumis co rika ale ocividne se mu tva pritomnost vubec nelibi, ale z toho si hlavu nedelas.Porozhlednes se zrakem po kuchyni a vsimnes si par veci"
        ", naproti tobě jsou policky a na nich naberacky ,panvicky , hrnce a takovy neporadek na stole pod nim jsou nejake veci od zapalovace az po dymku, kterou asi kuchar rad kouri"
        "na pravo je velký stos spinaveho nadobi, talire vydlicky,sklenicky a sposuta bordelu znaci ze vcera vecer asi byla pekna party "
        "v levo je potom nejake psí zradlo, psi hracky a pochoutky. zvlastni nikdy jsem si nevsiml ze je tu nekde pes, mozna ma kuchar rad psi jidlo proto vypada jak velkej bernardin\n\n"
        "1(jdi dopredu) - Police s nadobim\n"
        "2(jdi doprava) - spinave nadobi\n"
        "3(jdi doleva)  - psi pamlsky a jidlo\n";

    kitchen.forward_description = "\nKdyz jsi konecne odlakal kuchare, ktery zrovna zameta a uklizi( divim se ze mu to vadi v takovem bordelu) :-D,prohlizis jsi polici neni na ni nic zajimaveho,"
                                  " spousta nadobí, uschle zbytky jidla ,mrtva krysa. Podivas se dolu a je tam pracovni plocha, par zbytecnych veci dimka kterou asi kuchar kouri a zapalova"
                                  ", asi jedina normalni vec ktera by se hodila. Nevahas ani minutu a zapalovac jsi davas do kapsy. Kuchar porad zameta jeste je cas se podivat dal\n\n";
    kitchen.right_description = "";
    kitchen.left_description = "\nJdes se podivat na psi pochoutky, voni to priserne skoro jako kocicinec je zde i vydlicka a talir ÷>* TEN KUCAR TO SNAD VAZNE OBEDVA  bleeeeeee!!!"
                               "jsou tu asi i nejake pochoutky pro psi, vezmu si jich par do kapsy a dam je potom sousedovic psovi ten je ma rad. Jinak tu nic zajimaveho neni, muzu se tady jeste porozhlednou"
                                "nebo uz radsi pujdu,vypada se ze kuchar uz ma skoro uklizeno\n\n";
    kitchen.back = &entrance;

    //_____________________Sklep______________________________
    cellar.description = "\nVesel jsi do sklepa, jeste do poloviny shodu jsi neco videl,ale ted kdyz jsi sesel dolu uz nevidis vubec nic nevidis jsi ani na ruce jaka je tu tma:!!!!"
                         "marne hledas nejaky zdroj svetla,marny pohyb rukou okolo zdi kam dosahnes nic neudela a ty se rozhodujes jestli se mas nekam vidat a nebo se radsi vratis pozdeji\n\n "
                         "1(jdi dopredu) - Nic nevidis\n"
                         "2(jdi doprava) - Nic nevidis\n"
                         "3(jdi doleva)  - Nic nevidis";
    cellar.forward_description ="\nPrijdes dopredu mezi dva velke sloupy ktere jsou zanesene prachem, oba je sfouknes a najednou se objevi duch podhradniho který tu zil pred 250 lety kdyz slouzil cisari Drogonovy de Caleras "
                                "Duch se na tebe podiva a rekne ' Zdravim poutniku, uz jsem tu dlouho nikoho nevidel potreboval bych pomoct abych mohl toto misto opustit staci kdyz uhodnes moji hadanku'"
                                "na chvilku se zamyslis '\n\n "
                                "1(Otazka) - At polozi duch otazku\n"
                                "2(jdi zpet) - Odejdi jako že nic\n";

    cellar.left_description = "\nKdyž jsi konecne rozsvitil a vydal se na levo je tu nejaké zarizeni ktere produkuje elektricky naboj,vsude je harampadi ostre plechove strepy a pohazene kusy plechu, tady asi "
                              "dlouho nikdo nebyl, jinak tu nic zajímaveho nevidis asi by jsi se mel jit porozhlednout jinam treba tady bude neco zajimavejsiho\n\n";
    cellar.right_description = "\nKdy se vydas doprava obchazis obrovbskou diru v podlaze ktera je hluboka snad 450 km :-D, hodis tam kus cihly která je vedle  a slysis jenom zvuk jak se cihla rozletela na kousky"
                               "prijdes ke staremu ponku je zde jenom prach pavuciny a prilepena zvejkacka a rozlamane pravitko , jsou tu i nejakej nastroje ale nic z toho nefunguje vse je uplne k nicemu"
                               "je moudre porozhlednou se jinde treba tam bude vetsi stesti\n\n";
    cellar.back = &entrance;

    //________________________________Shody do 1 patra_________________________ Zacína Soubor 1 patra
    stairs1.description = "\nVysel jsi nahoru po starsich schodech, drzel jsi se ve prostred aby jsi sel po koberci a nedelal zbytecny hluk. V polovine se zastavis a podivas se zpet a dopredu"
                          ", neveris kolik schodu uz jsi vysel a kolik te jeste ceka. 'To neni mozny' pomyslel jsi si a sel jsi dal az jsi konecne vystoupal nahoru. Rozhlednes se a vidis  ze je pred "
                          "tebou otevrena pradelna kde pokojske davaji spinave pradlo a hazi ho rovnou do pracky. Na prave strane jsi vsimnes pokoje pro sluzebnictvo na kterem je napsano 'ONLY STAFF' "
                          " a na leve strane opet ty priserne vypadajici schody, mozna stejne nekonecne jak tyto\n\n"
                          "1(jdi dopredu) - Vstup do pradelny\n"
                          "2(jdi doprava) - Pokoj pro sluzebnictvo\n"
                          "3(jdi doleva)  - Nekonecne shodiste\n";
    stairs1.forward = &laundry;
    stairs1.right = &servant_room;
    stairs1.left = &stairs2;
    stairs1.back = &entrance;

    ///----------------------------Laundry------------------------------------------------
    laundry.description = "\nPrisel jsi se podivat do pradelny, je tu hromada spinaveho obleceni a spousty ubrusu a prosteradel, je tu i slusna kupa cistích veci, ktere v zadni mistnosti zehli krasna blond"
                          "slecna se sirokym usmevem a je vysoka jako Eifelovka. Porozhlednes se po mistnosti na levo vidis jenom bezici pracky ktere vydavaji zvlastni zvuk.Na pravé strane je jenom velká hromada"
                          "spinaveho pradla\n\n"
                          "1(jdi dopredu) - Jdi se podivat na slecnu\n"
                          "2(jdi doprava) - Hromada Ale HROMADA pradla\n"
                          "3(jdi doleva)  - Pracky\n";
    laundry.forward_description = "\nPrijdes ke slecne a vzhlednes hodne vysoko do jejich ' :-D :-D :-D ' samozrejme oci. Predstavis se a i ona ti rekne ze se jmenuje je to Judita. Chvilku jsi spolu povidate,ale "
                                  "hovor je nenuceny a celkem prijemny, kdyz jsi vsimnes pekneho uboru pro majordoma a zeptas se ji jestli by jsi si ho mohl zkusit, ze te to zajima podiva se na tebe a rekne 'To neni mozne' "
                                  "a zase se pusti do zehleni\n\n";
    laundry.right_description ="\nHm jak jsem si myslel hromada spinaveho pradla nahazena na hromadu v tom se ani hrabat nebudu ,navic to strasne smrdi\n\n ";
    laundry.left_description ="\nVelke pracky ktere jedou naplno , podle zvuku co vydavaji uz maji lepsi leta zasebou rvou jak kdyby se prali retezi i s certem uvnitr, divim se ze to slecne nejde na nervy"
                              ",nic zajimaveho tu ale neni myslim ze se pujdu porozhlednout zase dal\n\n ";
    laundry.back = &stairs1;
    //________________________________Pokoj sluzebnictva---

    servant_room.description ="\n Dostal jsi se v prevleku do pokoje pro sluzebnictvo, dovnitr te pustila nerudna pokojska ktera odstoupi a neco jsi tam dela v rohu v mistnosti, mezitim se porozhlednes po pokoji "
                              "ve predu je stara skrin ktera uz zazila lepsi casi je tam toaletka a par prazdných lahvi od vina, male zrcadlo a fotka Justina Biebra :-D  na leve strane je odpocinkova cast s televizi ,lednici a par kresly"
                              "v televizi zrovna bezi esmeralda na prave strane jsou postele, uniformy pro sluzebnictvo a dalůsi skrine a velké hodiny\n\n"
                              "1(jdi dopredu) - Jdi ke skrini\n"
                              "2(jdi doprava) - Postele\n"
                              "3(jdi doleva)  - Obyvak\n";
    servant_room.forward_description = "\nKdyz prijdes dopredu ke skrini tak ji otevres ale nic zajimaveho v tom neni na toaletce lezi tuny makeupu par minci a flasky od vina v zrcadlu vidis jak se ti pokojska prohlizi jestli ji asi neco neukradnes"
                                       "ale jinak tady nic potrebneho neni\n\n ";
    servant_room.left_description = "\nKdyz se vydas na levo vidis stare sedacky, ty uz zazili lepsi casi navic smrdi nejakou kockou smichanou z hamburgrem, stary koberec a na stolku spoustu nedopalku cigaret, tady se asi hodne cvadi"
                                    "televize je taky stará a barvy na ni jsou vybledle,ale zrovna u serialu esmeralda je to stejne jedno Chose armando zrovna slepej nikam jde :-D, radsi bych jsi tam dal hokej, ale nejsem tady abych se koukla na Tv\n\n";
    servant_room.right_description = "\nJdes se jeste podivat doprava, spoustu posteli , napocital jsem jich 6  skrine a stolky  jedine zajimave jsou ty krasne hodiny, absolutne se nehodi do takoveho pokoje, ty maji urcite i nejakou cenu"
                                     "Kdyz se ale na hodiny podivas bliz na rucicce je nejaky papirek, lehce se podivas jak te porad pokojská sleduje a premyslis jak udelat to aby jsi si te nevsimla nebo te nevyhodila\n\n";
    servant_room.back =&stairs1;
    //----------------------Shody do 2 patrta -----------------------------Zacina soubor 2 patra 
    stairs2.description = "\n Vyjdes do druheho patra, tyhle schody uz jsou celkem prijemne par shodu a jsi nahore , nevypadaji uz tak strasidelne jako ty z prizemi, koberec je udrzovany a nikde zadna pavucina "
                          ", kdyz se priskokem zhopnes az nahoru rozhlednes jse na vsechny strany ve predu je tvuj pokoj dvere vypadaji masivne a ciste,na pravo je vchod do koupelny a na levé strane staré ale presto hezké dvere s napisem "
                          " VSTUP DO VEZE tam se urcite skrivá ten zahadny poklad pomyslim jsi \n\n"
                          "1(jdi dopredu) - Pokoj pro hosty\n"
                          "2(jdi doprava) - Koupelna\n"
                          "3(jdi doleva)  - vstup do veze\n";
    stairs2.forward = &guest_room;
    stairs2.left = &tower_entrance;
    stairs2.right = &bathroom;
    stairs2.back = &stairs1;

    //______________________Nastevnicky pokoj_____________________________________________
    guest_room.description = "\n Tvuj pokoj vypada celkem dobre, je tady krasna velka postel s nebesy  cisté rucniky a povleceni ,v krbu se lehce houpe plamen a praska drevo a celkove to pusoby prijemne. Naproti me jsou moje kufry hned vedle skrine"
                             " a na stolu lezi velká flaska sampanskeho. Na levo u krbu jsou dve kresla ,nocni stolek a knihovnma a krásny obraz nejakeho slechtice v pravo hned u kraje postele je srovnany zupan , papuce "
                             "a ovladac na televizy\n\n"
                             "1(jdi dopredu) - Jdi se podivat na kufry\n"
                             "2(jdi doprava) - Postel\n"
                             "3(jdi doleva)  - Jdi ke krbu\n";
    guest_room.forward_description = "\nKdyz se jdu podivat jestli mam vsechny kufry tak zakopnu o nejake klice je to velky svazek asi patri pokojske nebo nekomu ze sluzebnictva, no prozatim jsi je necham, treba se jeste budou hodit"
                                      ",nicmene kufry mam vsechny , dokonce je tam i moje susenka co jsem jsi schovaval, vezmu si ji na pozdeji\n\n";
    guest_room.left_description = "\nNachvili jsem si sedl na pohodlna kresla a jenom se koukal jak plaminek preskakuje z jednoho dreva na druhy, je to uklidnujici nachvilku se zdrzim!!\n\n";
    guest_room.right_description = "\nPrijdu se podivat k posteli a je opravdu krasne mekka, uzasna. Zupane je jeste teply, asi ho zrovna nekdo prinesl na polstari nechybi cokoladka a male zvykacky, hned vedle postele je malí bar "
                                   " je celkem rozmanity,mozná jsi pak neco vezmu :-D\n\n ";
    guest_room.back = &stairs2;
    
    ///----------------------------Koupelna---------
     bathroom.description = "\nPrijdes do koupelny, ktera je velice prostorna a cista vsude je to sami chrom pozlaceny kohoutky ve tvaru labute, sprcha velka jako muj byt a prijemne svetlo ktere reaguje na vstup do mistnosti"
                            "to je rozhodne ta nejlepsi mistnost v celem objektu. Kdyz se porozhlednes tak na pravo jsou 4 velka zrcadla vsechny jsou stejne az na jedno,pod nimy jsou umyvadla a rucniky v levo je pekna toaleta\n\n"
                            "1(jdi dopredu) - jdi ke sprse\n"
                            "2(jdi doprava) - jdi k zrcadlu\n"
                            "3(jdi doleva)  - Jdi na zachod\n";
     bathroom.forward_description = "\n Kdyz prijdes ke sprse nestacis se divit, ta sprcha je asi to nejvic modernejsi co tady muze byt, jsem zvedavej jestli aspon tece tepla voda. Pustil jsi kohoutek a at jsi kroutil jak jsi kroutil voda "
                                    "byla ledova jak na sibiri, no parada pomyslel jsi si sice sprcha pekna ale ve studeny vode je to stejne za trest jinak uz jsi si niceho zajimaveho nevsiml\n\n";
     bathroom.left_description = "\n No nepotrebuju, ale kdyz uz jsem tady byla by skoda to nevyzkouset, sednu jsi na to jako holcicka..........5 minutes later .... No parada vyhrivane prkenko, sem se urcite vratim\n\n";
     bathroom.right_description = "\n Jdes se ze zajimavosti podivat na to jedine zrcadlo ktere je jine nez ostatni zda se ze trosku sviti, ale jinak nic zvlastniho to nedela. Docela divne. zkusim se sem vratit pozdeji\n\n";
     bathroom.back = &stairs2;

     ///----------Vstup do veze-----------------------------Zacina soubor 3
     tower_entrance.description = "\n Ha konecne jsem vstoupil do veze. Tady me ceka urcite to co hledam, to o cem mi najezdni mistr povidal tam u nas v hospode, nekonecny poklad ktery ma vetsi cenu nez korunovacni klenoty."
                                  "porozhlednes se po mistnosti a vidis 3 stejne dvere neni na nich nic jineho nez napisy TAJEMNE DVERE , TAJEMNE DVERE a KANCELAR hm zajimave, budu to asi muset prozkoumat postupne,a uvidim co zjistim "
                                  "doufam ze za jednemi Tajemnymi dveri na me ceka ten poklad a ja si ho budu moct odnest\n\n"
                                  "1(jdi dopredu) - Tajemne dvere 1\n"
                                  "2(jdi doprava) - kancelar\n"
                                  "3(jdi doleva)  - Tajemne dvere 2\n";
     tower_entrance.forward = &secret_door1;
     tower_entrance.left = &secret_door2;
     tower_entrance.right = &office;
     tower_entrance.back = &stairs2;
 
     ///-------------------------Secret door 1
     secret_door1.description = "\nKonecne jsem se dostal to techto zpropadenych dveri zatim vsechno vypada ze bude bezpecne ale radeji budu postupovat obezretne neni cas na zadne chyby, porozhlednu se po mistnosti jestli neco neuvidimi"
                                " naproti vidim obrovske zrcalo ve zlatem ramu primo uprostred zdi kolem nic neni, v levo je nejaky stul kde jsou pohazene knihy a ruzne svitky a horici svicka na pravo vidim  hromadu krabic s napisem obrazy\n\n";
                                "1(jdi dopredu) - Tajemne zrcadlo 1\n"
                                "2(jdi doprava) - Jdi ke krabicim\n"
                                "3(jdi doleva)  - Jdi ke stolu 2\n";
     secret_door1.forward_description = "\nWow zrcadlo vypada nadherne, vubec se sem nehodi stara zed na ktere nic neni a uprostred tohle nadherne zrcadlo, zkusim nekde najit nejaky tajny spinac nebo tlacitko, ale jako by to opravdu bylo jenom"
                                        "jenom zrcadlo uprostred zdi, zkusim se vratit pozdeji treba najdu nejake indicie jak s tim zrcaldem zachazet porozhlednu se jeste jestli neco nenajdu\n\n";
     secret_door1.left_description = "\nVydam se ke stolu je tady spousta knih a svitku,treba najdu nejakou tajnou zpravu nebo indicii jak otevrit nebo se dostat pres zrcadlo. HM ani po hodine prochazeni vseho co tu je jsem nenasel odpoved "
                                      "asi tu vazne nic neni prosel jsem uplne vse co slo i desku jsem prohledal a nic porozhlednu se dal\n\n";
     secret_door1.right_description = "\nKdyz se podivam ke krabicim par jich otevru, ale jsou v nich pouze obrazy, spoustu obrazu par jich vyndam abych se podival co na nich je,ale jsou to jenom cmaranice tohle nic neprinese "
                                      "zadny tajny zpravy jenom stare obrazy, cas ji zase o kus dal\n\n";
     secret_door1.back = &tower_entrance;

     //-----------------------Secret door 2
     secret_door2.description = "\nVesel jsi do mistnosti nazvane tajemne dvere, je to celkem prazdna mistnost pred tebou je akorat nejaky sloupek a na nem nejaka znacka, jinak okolo nic moc neni\n\n"
                                "1(jdi dopredu) - Jdi ke sloupku 1\n"
                                "2(jdi doprava) - Jdi doprava \n"
                                "3(jdi doleva)  - jdi doleva 2\n";
     secret_door2.forward_description = "\n Kdyz prijdes ke sloupku uvidis nadobu a vedle znacku nejakeho stromu s napisem daruj co muzes,snazis se mackat strom ale nic se nedeje, prohlizis si sloupek ale nic jineho tu proste neni\n\n ";
     secret_door2.left_description = "\n Nic proste nic opravdu uplne prazdna mistnost\n\n";
     secret_door2.right_description = "\nKdyby nic bylo pocitatelne tak tady je 6x nic na druhou\n\n";
     secret_door2.back = &tower_entrance;

     // -------------------------------office 

     office.description = "\nVejdes do mistnosti ktera ke celkem upravena, komorna atmosfera doplnuje kourici osobu v zadu v mistnosti jak pise do nejakeho deniku, porozhlednes se a je to pekna mistnost se spousty knih, krbem par obrazy"
                          "a nekolika hlavami ulovenych zvirat, podle pohledu pana ty zvirata neulovil on , ten by neublizil ani mouse ,vzdyt by ani neudrzel zbran jak je hubeny\n\n";
                          "1(jdi dopredu) - Dojdi k Majordomovi 1\n"
                          "2(jdi doprava) - Podivej se ke knihovne \n"
                          "3(jdi doleva)  - Jdi se podivat na vytrinu 2\n";
     office.forward_description = "\nKdyz prijdes k majordomovi s usmevem se na tebe podiva vynda fajfku’ ’ ’ ’ ’ ’ ’ a rika, dobry den mladiku uz dlouho ke me zadna navsteva nezavitala, moc lidi uz jsem nechodi "
                                  ", vydávam prikazi telefonem a jidlo mi sem vozi vytahem, proto jsem moc rád ze te vidim ja jsem Majordomus ZANOVIC DE LIPOS, aby jsi vedel mam rad hadanky pokud jsi budes chtit semnou zahrat "
                                  "prozradim ti tajemstvi o tomto dome, co na to rikas???\n\n";
     office.left_description = "\nVydas se doleva podivat se na vytriny plne trofeji a poct patrici majordomovi jsou moc pekne a je videt ze se o ne stara a je na ne hrdy , dokonce je tady medaile cti z prvni svetove valky"
                               ", nevypdada ze byl ve valce je to zajimave ,ale jdu se podivat dal \n\n";
     office.right_description = "\nJedna z mnoha knihoven kterich je tu spousta , ale tyhle knihy jsou pekne udrzovane a je videt ze i pouzivane, asi to bude vasnivi ctenar, sposuta knih je tu o svetovych valkach,asi milovnik historie"
                                "Na zapadni fronte klid tu jsem nedavno precetl, no nic cas jit \n\n";
     office.back = &tower_entrance;

    // inicializice ducha hadanka odpoved a bollean
    struct Ghost ghost = {
     "Mame ji vsichni, ale nikdy ji neuvidime",
     "budoucnost",
     0,
    };

    struct Location* current_location = &entrance;
    char input[MAX_INPUT];

    int counter = 0; // pocita mi první vchod do mistnosti abych mohl pokracovat dal
    int dizaster = 0;
    int light = 0;
    int fakeerror = 0;

    struct Location* global_current_location = NULL;


    while (1) {

        if (current_location == &stairs1) {

            struct Location* global_current_location = &stairs1;
            first_floor_loop(global_current_location, &playerInventory);
            current_location = current_location->back;
            print_location(current_location);
            counter = 0;
        }
        else {

            if (counter == 0) {

                print_location(current_location);// Podívám se do funkce kde jsem print description
                printf("\nCo chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets načtení řetezce  inputu a nastavení maximalního počtu znaků , stdin pro čtení vstupních daz z klavesnice


                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    current_location = current_location->forward;
                    fakeerror = 0;
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    current_location = current_location->left;
                    fakeerror = 0;
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    current_location = current_location->right;
                    fakeerror = 0;
                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    fakeerror = 0;
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(&playerInventory);
                    continue;
                    fakeerror = 0;
                }
                else {
                    printf("Nerozumím tomu příkazu.\n");
                    fakeerror = 1;
                }

                if (fakeerror == 0) {
                    counter = 1;
                    print_location(current_location);// Podívám se do funkce kde jsem 

                }
            }
            //pokudd chcete skončit hru
            else if (strncmp(input, "konec", 5) == 0) {
                break;
            }
            else {
                
                if (current_location == &cellar && hasItemInInventory(&playerInventory, 1) && hasItemInInventory(&playerInventory, 3) && light==0 && fakeerror == 0)// pridavam podminku plus kdyz mam zapalovac a pochoden
                {
                    printf("4(Pouzit zapalovac a pochoden) - Rozsvit\n\n");
                }

                printf("Co chcete delat? ");
                fgets(input, MAX_INPUT, stdin);// fgets načtení řetezce  inputu a nastavení maximalního počtu znaků , stdin pro čtení vstupních daz z klavesnice

                // strncmp porovnává input se stringem pokud se rovnají ve všech charech provede se mužu specifikovat kolik znaků chci
                if (strncmp(input, "jdi dopredu", 11) == 0 && current_location->forward) {
                    if (current_location == &kitchen && !kitchen.chef_distracted) {
                        printf("\nKuchar te zastavi dloubne te do oka a rekne: 'Co tu pohledavas a co mi tady okounis, neplet se mi do cesty'\n\n");
                    }
                    else {
                        if (current_location == &kitchen && !hasItemInInventory(&playerInventory, 1)) {
                            printf("%s\n", current_location->forward_description);
                            addItemToInventory(&playerInventory, 1);
                        }
                        else if (current_location == &kitchen){
                            printf("\nNic zajimaveho tu uz neni:'Zapalovac jsi sebral navic se zacina kuchar zvedat rychle pryc'\n\n");
                        }
                    }
                    //--------------------------
                    if (current_location == &cellar && hasItemInInventory(&playerInventory, 1) && hasItemInInventory(&playerInventory, 3) && light == 1) {
                        if (!hasItemInInventory(&playerInventory, 5)) {

                            printf("%s\n", current_location->forward_description);
                        }
                        else if (current_location == &cellar) {

                            printf("\n Duchovi jsi pomohl ted uz odpociva ve Valhale, nic zajimaveho tady uz neni\n\n ");
                        }

                    }
                    else if (current_location == &cellar){
                        printf("\nPo 6 letech se probouzis v nemocnici, nepamatujes jsi vubec nic kdo jsi, jak se jmenujes, prijde jenom sestricka ti rict ze musis zaplatit 7,5 milionu dolaru za osetreni. Jo a vytejte mezi nami :-D  ' Žaidimas baigtas '\n\n");
                        printf("\nSNad Vas hra bavila :D D Thanks for playing ");
                        break;
                    }
                }
                else if (strncmp(input, "jdi doleva", 10) == 0 && current_location->left) {
                    if (current_location == &kitchen && !kitchen.chef_distracted) {
                        printf("\nKuchar te zastavi dloubne te do zebra a rekne: 'Co tu porad pohledavas a co mi tady okounis, neplet se mi do cesty jdi pryc'\n\n");
                    }
                    else {
                        if (current_location == &kitchen && !hasItemInInventory(&playerInventory, 2)) {
                            printf("%s\n", current_location->left_description);
                            addItemToInventory(&playerInventory, 2);
                        }
                        else if (current_location == &kitchen){
                            printf("\nNic zajimaveho tu uz neni:'Pamlsky mas v kapse navic se zacina kuchar zvedat a jde k tobě rychle pryc'!!!!!!!\n\n");
                        }
                    }
                    ///----------------Sklep
                    if (current_location == &cellar && hasItemInInventory(&playerInventory, 1) && hasItemInInventory(&playerInventory, 3) && light == 1)
                    {
                        printf("%s\n", current_location->left_description);
                    }
                    else if(current_location == &cellar){
                        printf("\n Nevim co se stalo ale najednou jsi dostal strasnou ranu, spadl na zem a zabodl jsi si kus plechu do břicha jak se klasicky rika 'Mäng läbi'\n\n\n\n\n\n\n\n ");
                        printf("\nSNad Vas hra bavila :D D Thanks for playing ");
                        break;
                    }
                }
                else if (strncmp(input, "jdi doprava", 11) == 0 && current_location->right) {
                    if (current_location == &kitchen) {
                        printf("\nKdyz jsi se dostal nepozorovane ke spinavemu nadobi, napadlo te ze by jsi mohl prevrhnout a treba tim odlakat kuchare aby jsi se mohl dostat do dalsich casti kuchyne\n\n."
                            "Wow Povedlo se, rychle nez se zase vzpamatuje\n\n");
                        kitchen.chef_distracted = 1;
                    }
                    else if(current_location == &kitchen) {
                        printf("%s\n", current_location->right_description);
                    }
                    ////------------------------SKlep
                    if (current_location == &cellar && hasItemInInventory(&playerInventory, 1) && hasItemInInventory(&playerInventory, 3)&& light == 1)
                    {
                        printf("%s\n", current_location->right_description);
                    }
                    else if(current_location == &cellar){
                        printf("\n Udelal jsi nekolik kroku a najednou jsi se propadl podlahou a spadl jsi do hromady skla, ktere te rorzrezalo po chvili uz vidis jenom svetlo jak vstoupa vzhuru '게임 종료'\n\n ");
                        printf("\nSNad Vas hra bavila :D D Thanks for playing\n\n ");
                        break;
                    }

                }
                else if (strncmp(input, "Rozsvit", 7) == 0 && hasItemInInventory(&playerInventory, 1) && hasItemInInventory(&playerInventory, 3))// Podminka pro pouziti svetla pouze v cellar
                {
                    printf("\nVzal jsi svoji pochoden a zapalovac co jsi nasel v kuchyny a rozsvitil najendou se celej sklep zalil svetlem a ty vidis hrozny neporadek na levo nejaky stroj kterej obcas zajiskri"
                        " a hromadu ostrych a nebezpecnich odrezku, na levo je velka dira a za ni je nejaky stary pracovni stul. Ve predu jsou dva starodavne sloupy. Vypada to tady desive zkusim se porozhlednout\n\n"
                        "1(jdi dopredu) - Sloupy\n"
                        "2(jdi doprava) - Neznami stroj\n"
                        "3(jdi doleva)  - Pracovni stul\n");
                    light = 1;
                    continue;
                }
                else if (strncmp(input, "otazka", 6) == 0 && !ghost.hasAsked) // Podminka pro otazku
                {

                    printf("%s\n", ghost.riddle);// duchova hadanka 
                    // podminka abych mohl odpovidat na otazku nekolikrat
                    while(!ghost.hasAsked){
                    
                        printf("Odpovez (nebo napis'zpet' pro navrat): ");
                        fgets(input, MAX_INPUT, stdin);
                        input[strcspn(input, "\n")] = 0; // odstranění nového řádku z konce vstupu

                        if (strcmp(input, "zpet") == 0) {
                            printf("\nPokud se budes chtit vratit budu tu cekat!!!!!!!!\n");
                            break;
                        }
                        else if (strcmp(input, ghost.answer) == 0) {
                            printf("\nDuch rika: 'Spravne! Konecne, uz vidim svetlo valhaly, dekuju ti jeste nez odejdu dam ti cast kodu k pokladu, ktery mi kdysi venoval muj pan abych to strezil'\n\n");
                            addItemToInventory(&playerInventory, 5);
                            ghost.hasAsked = 1;
                        }
                        else {
                            printf("\nDuch rika: 'To neni spravne!'\n\n");
                        }
                    }
                }
                else if (strncmp(input, "jdi zpet", 8) == 0 && current_location->back) {
                    current_location = current_location->back;
                    counter = 0;// counter na mistnost když do ni jdu poprve
                    kitchen.chef_distracted = 0;// Kdyz odejdu z kuchyne kuchar uklidi takže bych zase musel shodit ty taliře
                    light = 0;
                }
                else if (strncmp(input, "inventory", 9) == 0) {

                    showInventory(&playerInventory);// podivam se jestli mám neco v inventari
                    fakeerror = 1;
                    continue;
                }
                else {
                    printf("Nerozummm tomu prikazu.\n");
                    fakeerror = 1;
                }
            }
        }
    }
    return 0;
}
