#include <corecrt.h>
#include <stdio.h>

int main() {
    FILE* fp;
    errno_t result = fopen_s(&fp, "output.txt", "wb");
    if (result == 0) {
		fclose(fp);
	}
    printf("Hello, world!");
    return 0;
}
