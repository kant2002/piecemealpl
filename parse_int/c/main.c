#include <stdio.h>

int main() {
    const char* flt = "272733";
    int i;
    sscanf_s(flt, "%i", &i);
    return 0;
}
