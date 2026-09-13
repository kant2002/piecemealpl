package main

import (
	"fmt"
	"os"
)

func main() {
	os.Remove("output.txt")
	fmt.Println("File deleted successfully.")
}
