using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

// Define the port and IP address to listen on
int port = 19080;
IPAddress localAddr = IPAddress.Any;

TcpListener server = new TcpListener(localAddr, port);

try
{
    // Start the server
    server.Start();
    Console.WriteLine($"Server started on port {port}. Waiting for a connection...");

    while (true)
    {
        // Accept a client connection
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Client connected!");

        // Handle the client in a separate method
        HandleClient(client);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
finally
{
    // Stop the server
    server.Stop();
}



static void HandleClient(TcpClient client)
{
    try
    {
        // Get the network stream
        NetworkStream stream = client.GetStream();

        byte[] response = Encoding.ASCII.GetBytes("Hello World!");
        stream.Write(response, 0, response.Length);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Client error: {ex.Message}");
    }
    finally
    {
        // Close the client connection
        client.Close();
        Console.WriteLine("Client disconnected.");
    }
}