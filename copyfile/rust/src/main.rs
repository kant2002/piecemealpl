use std::fs;
fn main() -> std::io::Result<()> {
    fs::copy("source.txt", "destination.txt")?;
    Ok(())
}
