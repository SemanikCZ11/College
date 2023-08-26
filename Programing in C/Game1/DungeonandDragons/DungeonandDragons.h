#ifndef DUNGEONANDDRAGONS_H
#define DUNGEONANDDRAGONS_H

#include <iostream>
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <stdlib.h>

#define MAX_INPUT 100

// pohybování se po místnostech a jejich popis
struct Location {

    const char* description;
    const char* forward_description;
    const char* right_description;
    const char* left_description;
    struct Location* forward;
    struct Location* left;
    struct Location* right;
    struct Location* back;
    int trap;
    int treasure;
    int visited;
    int chef_distracted; // flag pro rozptýlení kuchaøe 
    int TheMaid;
    int button;

};
// vìci které pouužívám
struct Inventory {

    int lighter;
    int treat;
    int torch;
    int key;
    int code_part1;
    int code_part2;
    int code_part3;
    int shoes;
    int disguise;
    int biscuit;
    int flower;
    int compelet_code;
    int golden_snitch;
};


// extern pro  deklaraci a definece je v main.cpp a v dalsich souborech kde budu pouzivat danne mistnosti
 extern struct Location
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

extern int counter;
extern struct Inventory playerInventory;
extern struct Location* current_location;
extern struct Location* global_current_locationP1;
extern struct Location* global_current_locationP2;
extern struct Location* global_current_locationP3;

void Tower_floor_loop(struct Location* current_location, struct Inventory* playerInventory);
void Second_floor_loop(struct Location* current_location, struct Inventory* playerInventory);
void print_location(struct Location* loc);
void addItemToInventory(struct Inventory* inv, int item);
void removeItemFromInventory(struct Inventory* inv, int item);
int hasItemInInventory(struct Inventory* inv, int item);
void showInventory(struct Inventory* inv);

extern char input[MAX_INPUT];

#endif // !DUNGEONANDDRAGONS_H
