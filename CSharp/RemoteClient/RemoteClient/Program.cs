using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using RemotingServer;

namespace RemoteClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel c = new HttpChannel(8002);
            ChannelServices.RegisterChannel(c);


            //create a service class object (that is the proxy for the remote object)
            RemoteServices rserviceproxy = (RemoteServices)Activator.GetObject(typeof(RemoteServices),
                "http://localhost:86/OurRemoteServices");

            //invoke the methods of the remote object thru the proxy object
            Console.WriteLine("The max number is :" + rserviceproxy.WriteMessage(28,7));
            Console.Read();
        }
    }
}
