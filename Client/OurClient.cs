using System.Net.Sockets;
using System.Text;


namespace Client
{
    class OurClient
    {
        TcpClient client;
        StreamWriter sReader;

        public OurClient()
        {
            client = new TcpClient("127.0.0.1", 5555);
            sReader = new StreamWriter(client.GetStream(), Encoding.UTF8);
            HandleCommunication();

        }
        void HandleCommunication()
        {
            while (true)
            {
                Console.Write("> ");
                string? message = Console.ReadLine();
                sReader.WriteLine(message);
                sReader.Flush();

            }
        }
    }
}