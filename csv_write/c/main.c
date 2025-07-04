#include <stdio.h>
#include <string.h>

// Function to escape special characters in a CSV field
void escape_csv_field(const char* input, char* output) {
    const char* special_chars = ",\"\n";
    int needs_quotes = 0;

    for (const char* p = input; *p; ++p) {
        if (strchr(special_chars, *p)) {
            needs_quotes = 1;
            break;
        }
    }

    if (needs_quotes) {
        *output++ = '"';
        for (const char* p = input; *p; ++p) {
            if (*p == '"') {
                *output++ = '"';
            }
            *output++ = *p;
        }
        *output++ = '"';
        *output = '\0';
    }
    else {
        strcpy(output, input);
    }
}

int main() {
    // Example data to write to the CSV file
    const char* data[][3] = {
        {"Name", "Age", "City"},
        {"Alice", "30", "New York"},
        {"Bob", "25", "Los Angeles"},
        {"Charlie", "35", "San Francisco, CA"},
        {"Dana", "28", "Chicago \"Windy City\""}
    };

    FILE* file = fopen("output.csv", "w");
    if (!file) {
        perror("Failed to open file");
        return 1;
    }

    char escaped_field[1024];
    for (size_t i = 0; i < sizeof(data) / sizeof(data[0]); ++i) {
        for (size_t j = 0; j < 3; ++j) {
            escape_csv_field(data[i][j], escaped_field);
            fprintf(file, "%s%s", escaped_field, (j < 2) ? "," : "\n");
        }
    }

    fclose(file);
    printf("CSV file written successfully.\n");
    return 0;
}
