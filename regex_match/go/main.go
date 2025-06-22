package main

import (
	"fmt"
	"regexp"
)

func main() {
	re, err := regexp.Compile(`^\d{4}-\d{2}-\d{2}$`)
	if err != nil {
		fmt.Println("Error compiling regex:", err)
		return
	}

	text := "2025-06-22"
	if re.MatchString(text) {
		fmt.Println("The string matches the pattern!")
	} else {
		fmt.Println("The string does not match the pattern.")
	}
}