using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Utility.Ping
{
    public class Network_Service
    {
        public string SendPing()
        {
            return "Succes: Ping send!";
        }

        public int PingTImeout(int a, int b)
        {
            return a + b;
        }
    }
}
