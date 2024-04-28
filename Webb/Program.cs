using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        int port = 2083;

        IPEndPoint endPoint = new IPEndPoint(ip, port);
        Socket socket = new Socket(AddressFamily.InterNetwork,
            SocketType.Stream, ProtocolType.Tcp);
        Console.Title = endPoint.ToString();
        try
        {
            socket.Bind(endPoint);
            socket.Listen();
            Console.WriteLine("Server is running");
            while (true)
            {
                Console.WriteLine("Waiting for requests...");
                Socket client = socket.Accept();
                int bytes = 0;
                byte[] data = new byte[1024];
                do
                {
                    bytes = client.Receive(data);
                    Console.WriteLine("Message : ", Encoding.Unicode.GetString(data, 0, bytes));

                } while (client.Available > 0);
                Console.WriteLine("Client end point : ", client.RemoteEndPoint);
                string message = "Your request was accepted " + DateTime.Now;
                data = Encoding.Unicode.GetBytes(message);
                client.Send(data);
                client.Shutdown(SocketShutdown.Both);
                
            }
            
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}