using Common;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait while service check database and prepares connection");
            var inicijalizacija = new InAdmin();
            inicijalizacija.Check();

            Connect.ConnectWCF();
        }
    }
}
