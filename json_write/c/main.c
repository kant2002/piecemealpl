#include <stdio.h>
#include <stdlib.h>
#include "cjson/cJSON.h"

struct Person {
    char* name;
    int age;
    char* city;
};

int main() {
    // Create a JSON object
    cJSON* root = cJSON_CreateArray();

    struct Person data[] = {
        {"Alice", 30, "New York"},
        {"Bob", 25, "Los Angeles"},
        {"Charlie", 35, "San Francisco, CA"},
        {"Dana", 28, "Chicago \"Windy City\""}
    };

    for (size_t i = 0; i < sizeof(data) / sizeof(data[0]); ++i) {
        cJSON* personJson = cJSON_CreateObject();
		struct Person* person = &data[i];
        cJSON_AddStringToObject(personJson, "name", person->name);
        cJSON_AddNumberToObject(personJson, "age", person->age);
        cJSON_AddStringToObject(personJson, "city", person->city);
        cJSON_AddItemToArray(root, personJson);        
    }

    // Print the JSON object as a string
    char* jsonString = cJSON_Print(root);
    printf("%s\n", jsonString);

    // Free allocated memory
    cJSON_Delete(root);
    free(jsonString);

    return 0;
}
