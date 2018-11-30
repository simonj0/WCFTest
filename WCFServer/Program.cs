using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(StringReverserService), new Uri("net.pipe://localhost")))
            {
                host.AddServiceEndpoint(typeof(IStringReverserService), new NetNamedPipeBinding(), "WCFTest");
                host.Open();

                Console.WriteLine("Service started.");
                Console.ReadLine();

                host.Close();
            }
        }
    }
}
