package main

import (
	"fmt"
	"os"
)

func main() {
	err := os.Mkdir("test", os.ModePerm);
	if err != nil {
		panic("Failed to create test folder")
	}
	fmt.Println("Hello, World!")
}
