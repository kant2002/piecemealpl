use std::fs;

fn main() -> std::io::Result<()>  {
    fs::create_dir_all("test/test2")?;
    println!("Hello, world!");
    Ok(())
}
