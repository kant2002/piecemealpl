#include <corecrt.h>
#include <stdio.h>

int main() {
    remove("output.txt");
    printf("File deleted successfully.\n");
    return 0;
}
