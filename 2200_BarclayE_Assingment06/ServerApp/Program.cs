using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To UVU Fact/Major Server!");
            Console.WriteLine("=================================");
            SynchronousSocketServer Server = new SynchronousSocketServer();
            Server.StartListening();
        }
    }
}
