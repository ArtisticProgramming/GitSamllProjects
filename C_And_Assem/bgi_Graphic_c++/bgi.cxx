//#include <cstdlib>
//#include <string>
//#include <iostream>
#include "graphics.h"

using namespace std;

void Stealth()
{
    HWND Stealth;
    AllocConsole();
    Stealth = FindWindowA("ConsoleWindowClass", NULL);
    ShowWindow(Stealth, 0);
}


int main(int argc, char* argv[])
{
    Stealth(); 
    initwindow(400, 300, "First Sample");
    circle(160, 60, 60);
    while (!kbhit())
    {
        delay(200);
    }
    return 0;
//    string command = "g++ ";
//    string blank = " ";
//    int i;
//
//    for (i = 1; i < argc; i++)
//	command += blank + argv[i];
//
//#ifdef WINDOWS
//    command += " -mwindows";
//#endif
//    command += " -lbgi -lgdi32 -lcomdlg32 -luuid -loleaut32 -lole32";
//    return system(command.c_str( ));
}
