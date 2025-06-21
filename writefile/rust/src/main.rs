use std::fs::File;
use std::io::Write;

fn main() -> std::io::Result<()> {
    let content = "Hello, world!";
    let mut file = File::create("test.txt")?;
    file.write_all(content.as_bytes())?;
    println!("Hello, world!");
    Ok(())
}
