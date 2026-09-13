package main
import (
   "fmt"
   "os"
)
func main() {
   _, err := os.Stat("README.md")
   if err != nil {
       fmt.Println("File does not exist.")
   } else {
       fmt.Println("File exists!")
   }
}
