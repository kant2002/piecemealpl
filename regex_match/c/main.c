#define PCRE2_CODE_UNIT_WIDTH 8
#include <stdio.h>
#include <string.h>
#include <pcre2.h>

int main() {
    PCRE2_SPTR pattern = (PCRE2_SPTR)"\\b\\d{4}-\\d{2}-\\d{2}$\\b";
    PCRE2_SPTR subject = (PCRE2_SPTR)"2025-06-22";

    pcre2_code* re;
    int errornumber;
    PCRE2_SIZE erroroffset;

    // Compile the regex pattern
    re = pcre2_compile(pattern, PCRE2_ZERO_TERMINATED, 0, &errornumber, &erroroffset, NULL);
    if (re == NULL) {
        PCRE2_UCHAR buffer[256];
        pcre2_get_error_message(errornumber, buffer, sizeof(buffer));
        printf("Regex compilation failed at offset %d: %s\n", (int)erroroffset, buffer);
        return 1;
    }

    // Create a match data structure
    pcre2_match_data* match_data = pcre2_match_data_create_from_pattern(re, NULL);

    // Match the regex against the subject string
    int rc = pcre2_match(re, subject, strlen((char*)subject), 0, 0, match_data, NULL);
    if (rc > 0) {
        printf("Match found!\n");
    }
    else if (rc == PCRE2_ERROR_NOMATCH) {
        printf("No match found.\n");
    }
    else {
        printf("Matching error: %d\n", rc);
    }

    // Free resources
    pcre2_match_data_free(match_data);
    pcre2_code_free(re);

    return 0;
}
