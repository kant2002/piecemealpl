use std::fs;

fn main() -> std::io::Result<()>  {
    fs::create_dir("test")?;
    println!("Hello, world!");
    Ok(())
}
