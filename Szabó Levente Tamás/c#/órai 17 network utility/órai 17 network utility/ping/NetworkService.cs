using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace órai_17_network_utility.ping
{
    public class NetworkService
    {
            public string SendPing()
            {
                return "Succes: ping sent!";
            }
            public int PingTimeout(int a, int b)
            {
                return a + b;
            }
    }
}
