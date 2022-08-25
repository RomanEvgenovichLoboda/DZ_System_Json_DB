using Server.Classes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

const int PORT = 8088;
const string IP = "127.0.0.1";
Console.WriteLine("Server start...");
IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(IP), PORT);
Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
try
{
    string str = "";

    serverSocket.Bind(iPEnd);
    serverSocket.Listen(10);
    Socket clientSocket = serverSocket.Accept();
    do
    {
        Console.WriteLine($"Server listen on {IP}:{PORT}");
        int bytes = 0;
        byte[] buffer = new byte[1024];
        StringBuilder builder = new StringBuilder();
        do
        {
            bytes = clientSocket.Receive(buffer);
            builder.Append(Encoding.Unicode.GetString(buffer, 0, bytes));
        } while (clientSocket.Available > 0);
        str = builder.ToString();
        var user_data = JsonConvert.DeserializeObject<Data>(str);
        if(user_data.Registration)
        {
            Registration reg = new Registration();
            reg.Regestration(user_data.Email, user_data.Password);
        }
        else
        {
            Registration reg = new Registration();
            reg.signIn(user_data.Email, user_data.Password);
            if(reg.sidn_in)
            {
                Console.WriteLine($"\t Hallo {user_data.Email}");
                reg.GetUsers().ForEach(Console.WriteLine);
            }
            else {
                Console.WriteLine("Wrong Data !"); ;
            }
        }
    } while (true);
    clientSocket.Close();
    serverSocket.Shutdown(SocketShutdown.Both);
    serverSocket.Close();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Server end...");
Console.ReadLine();