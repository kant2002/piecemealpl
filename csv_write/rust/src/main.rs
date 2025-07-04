use std::error::Error;
use std::fs::File;
use csv::Writer;

fn main() -> Result<(), Box<dyn Error>> {
    // Create a CSV writer to a file
    let file = File::create("output.csv")?;
    let mut wtr = Writer::from_writer(file);

    // Write rows
    wtr.write_record(&["Name", "Age", "Address"])?;
    wtr.write_record(&["John Doe", "30", "123, Elm Street"])?;
    wtr.write_record(&["Jane \"JJ\" Smith", "25", "456 Oak Street\nApartment 2B"])?;
    wtr.write_record(&["Alice", "35", "789 Pine Street"])?;

    // Finish writing
    wtr.flush()?;
    println!("CSV written to output.csv");
    Ok(())
}
