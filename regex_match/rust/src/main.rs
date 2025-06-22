use regex::Regex;

fn main() {
    let re = Regex::new(r"^\d{4}-\d{2}-\d{2}$").unwrap();
    let test_str = "2025-06-22";
    if re.is_match(test_str) {
        println!("The string matches the pattern!");
    } else {
        println!("The string does not match the pattern.");
    }
}
