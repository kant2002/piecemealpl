#include <stdio.h>

int main() {
   const char *filePath = "demo.txt";
   FILE *file;
   fopen_s(&file, "READMD.md", "r");
   if (file != NULL) {
       fclose(file);
       printf("File exists!\n");
   } else {
       printf("File does not exist.\n");
   }
   return 0;
}
