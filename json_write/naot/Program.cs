using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        // Create an object
        var data = new [] {
            new Person { Name = "Alice", Age = 30, City = "New York" },
            new Person { Name = "Bob", Age = 25, City = "Los Angeles" },
            new Person { Name = "Charlie", Age = 35, City = "San Francisco, CA" },
            new Person { Name = "Dana", Age = 28, City = "Chicago \"Windy City\"" },
	    };

        string jsonString = JsonSerializer.Serialize(data, PersonJsonContext.Default.Person);
        Console.WriteLine(jsonString);
    }
}

public class Person
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("age")]
    public int Age { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }
}

[JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Serialization)]
[JsonSerializable(typeof(Person))]
internal partial class PersonJsonContext : JsonSerializerContext { }
