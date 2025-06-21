package main

import (
	"fmt"
	"os"
)

func main() {
	data := []byte("Hello, World!")	
	err := os.WriteFile("test.txt", data, 0644)
	if err != nil {
		panic(err)
	}
	fmt.Println("Hello, World!")
}
