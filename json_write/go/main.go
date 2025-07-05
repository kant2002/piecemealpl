package main

import (
	"encoding/json"
	"fmt"
)

type Person struct {
	Name string `json:"name"`
	Age int `json:"age"`
	City string `json:"city"`
}

func main() {
	data := []Person{
        Person {"Alice", 30, "New York"},
        Person {"Bob", 25, "Los Angeles"},
        Person {"Charlie", 35, "San Francisco, CA"},
        Person {"Dana", 28, "Chicago \"Windy City\""},
	}
	bytes, _ := json.Marshal(data)
	fmt.Println(string(bytes))
}
