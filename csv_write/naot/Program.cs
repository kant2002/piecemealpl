using System;
using System.IO;
using System.Text;

string filePath = "example.csv";

// Sample data
var data = new[]
{
    new[] { "Name", "Age", "Address" },
    new[] { "John Doe", "30", "123, Elm Street" },
    new[] { "Jane \"JJ\" Smith", "25", "456 Oak Street\nApartment 2B" },
    new[] { "Alice", "35", "789 Pine Street" }
};

// Write CSV file
using (var writer = new StreamWriter(filePath, false, Encoding.UTF8))
{
    foreach (var row in data)
    {
        writer.WriteLine(EscapeCsvRow(row));
    }
}

Console.WriteLine($"CSV file written to {filePath}");

static string EscapeCsvRow(string[] row)
{
    for (int i = 0; i < row.Length; i++)
    {
        row[i] = EscapeCsvField(row[i]);
    }
    return string.Join(",", row);
}

static string EscapeCsvField(string field)
{
    if (field.Contains(",") || field.Contains("\"") || field.Contains("\n"))
    {
        // Escape double quotes by doubling them
        field = field.Replace("\"", "\"\"");
        // Wrap the field in double quotes
        field = $"\"{field}\"";
    }
    return field;
}