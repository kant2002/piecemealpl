#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main() {
    FILE* fptr = fopen("test.txt", "w");
    fprintf(fptr, "Hello, world!");
    fclose(fptr);
    printf("Hello, world!");
    return 0;
}