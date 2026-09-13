use std::path::Path;
fn main() {
   let path = Path::new("README.md");
   if path.exists() {
       println!("File exists!");
   } else {
       println!("File does not exist.");
   }
}
