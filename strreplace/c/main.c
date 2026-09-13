#include <stdio.h>
#include <string.h>
#include <stdlib.h>

// Replace only the first occurrence of oldWord with newWord
char* replaceFirst(const char* str, const char* oldWord, const char* newWord) {
    if (!str || !oldWord || !newWord) return NULL;

    size_t oldLen = strlen(oldWord);
    size_t newLen = strlen(newWord);

    if (oldLen == 0) return NULL; // Avoid infinite loop

    // Find first occurrence
    const char* pos = strstr(str, oldWord);
    if (!pos) {
        // No occurrence found, return a copy of the original string
        char* copy = malloc(strlen(str) + 1);
        if (copy) strcpy(copy, str);
        return copy;
    }

    // Calculate new string size
    size_t newSize = strlen(str) - oldLen + newLen + 1;
    char* result = malloc(newSize);
    if (!result) {
        perror("Memory allocation failed");
        return NULL;
    }

    // Copy part before oldWord
    size_t prefixLen = pos - str;
    memcpy(result, str, prefixLen);

    // Copy newWord
    memcpy(result + prefixLen, newWord, newLen);

    // Copy the rest after oldWord
    strcpy(result + prefixLen + newLen, pos + oldLen);

    return result;
}

int main() {
    char* text = "Search needle in the haystack";
    char* oldWord = "needle", *newWord = "pen";

    char* replaced = replaceFirst(text, oldWord, newWord);
    if (replaced) {
        printf("%s\n", replaced);
        free(replaced);
    }

    return 0;
}
