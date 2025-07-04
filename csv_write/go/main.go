package main

import (
	"encoding/csv"
	"fmt"
	"os"
)

func main() {
	// Data to write to the CSV file
	data := [][]string{
		{"Name", "Age", "Address"},
		{"John Doe", "30", "123, Elm Street"},
		{"Jane Smith", "25", "456 \"Oak\" Avenue"},
		{"Alice Brown", "35", "789 Pine\nRoad"},
	}

	// Create a CSV file
	file, err := os.Create("output.csv")
	if err != nil {
		panic(err)
	}
	defer file.Close()

	// Create a CSV writer
	writer := csv.NewWriter(file)
	defer writer.Flush() // Ensure all data is written to the file

	// Write data to the CSV file
	for _, record := range data {
		if err := writer.Write(record); err != nil {
			panic(err)
		}
	}

	// Check for any errors during the flush
	if err := writer.Error(); err != nil {
		panic(err)
	}

	fmt.Println("CSV file written successfully.")
}
