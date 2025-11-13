using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
    public class SynchronousSocketServer
    {
        // ServerApplication - SynchronousSocketListener.cs file

        // fields

        const int PORT = 11000;
        const string IP_ADDRESS = "127.0.0.1";
        const string FACT = "UVU FACT";
        const string MAJOR = "UVU MAJOR";
        string[] facts;
        string[] majors;
        const string FACT_FILE = "UVUFacts.txt";
        const string MAJOR_FILE = "UVUCourseDescriptions.txt";
        TcpListener tcpListener;

        // constructor
        public SynchronousSocketServer()
        {
            try
            {
                facts = File.ReadAllLines(FACT_FILE);
                majors = File.ReadAllLines(MAJOR_FILE);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void StartListening()
        {
            IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
            tcpListener = new TcpListener(iPAddress, PORT);
            tcpListener.Start();
            Thread thread = new Thread(new ThreadStart(ProcessSocket));
            thread.Start();
        }

        public void ProcessSocket()
        {
            while (true)
            {
                try
                {
                    Socket socket = tcpListener.AcceptSocket();
                    NetworkStream ns = new NetworkStream(socket);
                    StreamReader reader = new StreamReader(ns);
                    StreamWriter writer = new StreamWriter(ns);

                    writer.AutoFlush = true;

                    string clientinput = reader.ReadLine();

                    Console.WriteLine($"Received from client: {clientinput}");

                    Random rand = new Random();

                    if (clientinput.ToUpper() == FACT)
                    {
                        string fact = facts[rand.Next(facts.Length)];
                        Console.WriteLine(fact);
                        writer.WriteLine(fact);

                    }
                    else if (clientinput.ToUpper() == MAJOR)
                    {
                        string major = majors[rand.Next(majors.Length)];
                        Console.WriteLine(major);
                        writer.WriteLine(major);
                    }
                    else
                    {
                        Console.WriteLine($"Could not do anything with : {clientinput}");
                        writer.WriteLine($"Could not do anything with : {clientinput}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
