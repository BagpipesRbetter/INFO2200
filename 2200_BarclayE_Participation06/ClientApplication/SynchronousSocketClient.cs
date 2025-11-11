using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    public class SynchronousSocketClient
    {
        // ClientApplication - SynchronousSocketClient

        // declare constant for port

        const int SERVER_PORT = 11000;

        // declare constant for IP address

        const string IP_ADDRESS = "127.0.0.1";

        // constructor

        public SynchronousSocketClient()
        {

        }

        // method to receive request and returns a string
        public string ContactServer(string request)
        {
            string responseString = "";

            try
            {
                // create an object (reference variable) of the TcpClient class

                TcpClient tcpClient = new TcpClient();

                // create a connection

                tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT);

                // create a network stream

                NetworkStream networkStream = tcpClient.GetStream();

                // get the user's input

                StreamWriter streamWriter = new StreamWriter(networkStream); // pass in port and IP address
                StreamReader streamReader = new StreamReader(networkStream);

                streamWriter.AutoFlush = true; // no leftover bits or bytes

                streamWriter.WriteLine(request); // receives conspiracy or joke

                responseString = streamReader.ReadLine();

                networkStream.Close();
                tcpClient.Close();

            }
            catch (Exception ex)
            {
                responseString = ex.Message;
            }

            return responseString;
        }
    }
}
