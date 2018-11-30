using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFServer;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IStringReverserService> pipeFactory = new ChannelFactory<IStringReverserService>(new NetNamedPipeBinding(), "net.pipe://localhost/WCFTest");

            IStringReverserService pipeProxy = pipeFactory.CreateChannel();

            while (true)
            {
                string str = Console.ReadLine();
                Console.WriteLine(pipeProxy.ReverseString(str));
            }
        }
    }
}
