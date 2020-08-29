#include <stdlib.h>
#include <stdio.h>
#include <windows.h>

int main(void)
{
    int i, j;
    HWND window;
    HDC dc;

    printf("\n");
    window = GetActiveWindow();
    dc = GetDC(window);
    Rectangle(dc, 400, 800, 400, 400);
    for (i = 0; i < 100; i++)
    {
        for (j = 0; j < 100; j++)
            SetPixel(dc, i, j, RGB(55, 22, 33));
    }
    ReleaseDC(window, dc);
    return 0;
}