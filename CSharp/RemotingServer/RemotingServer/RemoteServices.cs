using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServer
{
    //service class
    public class RemoteServices : MarshalByRefObject
    {
        public int WriteMessage(int n1, int n2)
        {
            int maxval = (Math.Max(n1, n2));
            Console.WriteLine("Remote Call Executed...");
            return maxval;
        }
    }
}
