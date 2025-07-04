use std::net::{TcpListener, TcpStream};
use std::io::{Write};

fn handle_client(mut stream: TcpStream) {
    let response = "Hello World!";
    stream.write_all(response.as_bytes()).unwrap();
}

fn main() -> std::io::Result<()> {
	let listener = TcpListener::bind("127.0.0.1:19080")?;
	println!("Server listening on port 19080");

	for stream in listener.incoming() {
		match stream {
			Ok(stream) => {
				std::thread::spawn(move || handle_client(stream));
			}
			Err(e) => eprintln!("Connection failed: {}", e),
		}
	}

	Ok(())
}