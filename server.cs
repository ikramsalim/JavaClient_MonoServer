namespace chatroom
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.IO;
    using System.Threading;
    using System.Collections;
    using System.Collections.Generic;

    class Server {
        static void Main(string[]args) {
            
            //TcpClient client;
            //Int32 port = 8000;
            //IPAddress localAddr = Dns.GetHostEntry(Dns.GetHostName()).AddressList[0];

            TcpListener server = new TcpListener(8080);
            server.Start();
            

            while ((true)) {
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine ("Chat Server Started ....");
                //Console.WriteLine("connection");

                //get streams
                StreamReader reader = new StreamReader(client.GetStream());
                StreamWriter writer = new StreamWriter(client.GetStream());

                // read and write
                writer.WriteLine("ECHO >> " + reader.ReadLine());
                writer.WriteLine("Bye");
                writer.Flush();


            }
        }

    }


}