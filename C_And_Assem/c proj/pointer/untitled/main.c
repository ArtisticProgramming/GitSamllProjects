
// C program to show Arrow operator
// used in structure

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Creating the structure
struct student {
    char name[80];
    int age;
    float percentage;
};

// Creating the structure object
struct student* emp = NULL;

// Driver code
int main()
{
    int i=0;
    while (1) {
        // Assigning memory to struct variable emp
        emp = (struct student*)
            malloc(sizeof(struct student));

        // Assigning value to age variable
        // of emp using arrow operator
        emp->age = 18;

         strncpy(emp->name, "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee",80);


        // Printing the assigned value to the variable
        printf("%d \n", i);
i=i+1;
    }

    return 0;
}
