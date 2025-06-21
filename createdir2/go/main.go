package main

import (
	"fmt"
	"os"
)

func main() {
	err := os.MkdirAll("test/test2", os.ModePerm);
	if err != nil {
		panic("Failed to create test folder")
	}
	fmt.Println("Hello, World!")
}
