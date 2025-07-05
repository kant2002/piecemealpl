use serde::{Deserialize, Serialize};
use serde_json::{self};

// Define a struct to represent the JSON data
#[derive(Serialize, Deserialize, Debug)]
struct Person<'a> {
    name: &'a str,
    age: i32,
    city: &'a str,
}

fn main() -> Result<(), serde_json::Error> {

    let data: [Person; 4] = [
        Person {name: "Alice", age: 30, city: "New York" },
        Person {name: "Bob", age: 25, city: "Los Angeles" },
        Person {name: "Charlie", age: 35, city: "San Francisco, CA" },
        Person {name: "Dana", age: 28, city: "Chicago \"Windy City\"" },
	];

    // Serialize the Rust struct back into a JSON string
    let serialized = serde_json::to_string_pretty(&data)?;
    println!("{}", serialized);

    Ok(())
}
