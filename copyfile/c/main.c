#include <stdio.h>
#include <stdlib.h>

#define BUFFER_SIZE 8192  // 8 KB buffer for efficient copying

int main() {
    FILE *sourceFile, *destFile;
    size_t bytesRead, bytesWritten;
    unsigned char buffer[BUFFER_SIZE];

    // Open source file for reading in binary mode
    fopen_s(&sourceFile, "source.txt", "rb");
    if (!sourceFile) {
        perror("Error opening source file");
        return EXIT_FAILURE;
    }

    // Open destination file for writing in binary mode
    fopen_s(&destFile, "target.txt", "wb");
    if (!destFile) {
        perror("Error opening destination file");
        fclose(sourceFile);
        return EXIT_FAILURE;
    }

    // Copy data in chunks
    while ((bytesRead = fread(buffer, 1, BUFFER_SIZE, sourceFile)) > 0) {
        bytesWritten = fwrite(buffer, 1, bytesRead, destFile);
        if (bytesWritten != bytesRead) {
            fclose(sourceFile);
            fclose(destFile);
            return EXIT_FAILURE;
        }
    }

    // Check for read error
    if (ferror(sourceFile)) {
        fclose(sourceFile);
        fclose(destFile);
        return EXIT_FAILURE;
    }

    printf("File copied successfully from 'source.txt' to 'target.txt'.\n");

    // Close files
    fclose(sourceFile);
    fclose(destFile);

    return EXIT_SUCCESS;
}
