package main

import (
    "io"
    "os"
    "fmt"
)

func main() {
    sourceFile, err := os.Open("source.txt")
    if err != nil {
    	fmt.Println("Error opening source file!")
        return
    }
    defer sourceFile.Close()

    destinationFile, err := os.Create("destination.txt")
    if err != nil {
   		fmt.Println("Error opening destination file!")
        return
    }
    defer destinationFile.Close()

    io.Copy(destinationFile, sourceFile)
    fmt.Println("File copied successfully from 'source.txt' to 'target.txt'.")
}
