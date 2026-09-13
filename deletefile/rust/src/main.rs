use std::fs;
fn main() -> std::io::Result<()> {
   fs::remove_file("output.txt")?;
   println!("File deleted successfully!");
   Ok(())
}
