using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    internal class NetworkService
    {z
        public string SendPing()
        {
            return "Succes: Ping sent!";
        }
        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
