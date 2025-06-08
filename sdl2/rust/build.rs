fn main() {
    // Check if the target OS is Windows
    if std::env::var("CARGO_CFG_TARGET_OS").as_deref() == Ok("windows") {
        println!("cargo:rustc-link-lib=Advapi32");
    }
}
