using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.IO;

namespace Echo
{
    class EchoServer
    {
        [Obsolete]
        static void Main(string[] args)
        {

            Console.CancelKeyPress += delegate
            {
                System.Environment.Exit(0);
            };

            TcpListener ServerSocket = new TcpListener(5000);
            ServerSocket.Start();

            Console.WriteLine("Server started.");
            while (true)
            {
                TcpClient clientSocket = ServerSocket.AcceptTcpClient();
                handleClient client = new handleClient();
                client.startClient(clientSocket);
            }


        }
    }

    public class handleClient
    {
        TcpClient clientSocket;
        public void startClient(TcpClient inClientSocket)
        {
            this.clientSocket = inClientSocket;
            Thread ctThread = new Thread(Echo);
            ctThread.Start();
        }



        private void Echo()
        {
            NetworkStream stream = clientSocket.GetStream();
            BinaryReader reader = new BinaryReader(stream);
            BinaryWriter writer = new BinaryWriter(stream);

            while (true)
            {

                string[] str = reader.ReadString().Split(" ");
                string text = "";
                if (str[0] == "GET")
                {
                    text = File.ReadAllText("C:\\Users\\Alexandre MAZURIER\\Documents\\Documents Cours\\Polytech\\SI4\\Soc-WS\\TD1\\Echo\\ChatServer\\www\\pub\\" + str[1], Encoding.UTF8);
                    Console.WriteLine("Accès au fichier " + str[1]);
                    Console.WriteLine(text);
                }
                Console.WriteLine(str);
                writer.Write("http/1.0 200 OK\n\n" + text);
            }
        }



    }

}