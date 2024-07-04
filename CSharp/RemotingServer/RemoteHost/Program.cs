using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;
using System.Threading.Tasks;
using RemotingServer;

namespace RemoteHost
{
    class Program 
    {
        static void Main(string[] args)
        {
            //create a channel
            HttpChannel hc = new HttpChannel(86);

            //register the created channel
            ChannelServices.RegisterChannel(hc);

            //configuration info. about remote life services
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(RemoteServices), "OurRemoteServices",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Server Services started at Port No. 86.......");
            Console.WriteLine("Press any key to stop the server");
            Console.Read();
        }
    }
}
