package main

import (
	"fmt"
	"strings"
)

func main() {
	s := "Search needle in the haystack"
	reversed := strings.Replace(s, "needle", "pen", 1)
	fmt.Println(reversed)
}
