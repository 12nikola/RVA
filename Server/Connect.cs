using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Connect
    {
        public static void ConnectWCF()
        {
            Uri baseAddress = new Uri("net.tcp://localhost:53200/Common");

            NetTcpBinding binding = new NetTcpBinding();

            ServiceHost host = new ServiceHost(typeof(Contract));
            try
            {
                host.AddServiceEndpoint(typeof(IContract), binding, baseAddress);

                host.Open();

                Console.WriteLine("The service is ready.");

                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                host.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                host.Abort();
            }
        }
    }
}
