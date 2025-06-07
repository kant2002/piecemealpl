#include <stdio.h>
#include <string.h>

int main() {
    char str[] = "Hello, world!";
    size_t b = strlen(str);
    if (b)
        printf(str);
    return 0;
}