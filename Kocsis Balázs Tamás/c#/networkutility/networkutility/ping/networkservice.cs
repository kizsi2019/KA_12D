using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace networkutility.ping
{
    internal class networkservice
    {
        public string SendPing()
        {
            return "Success: Ping sent!";
        }

        public int PingTimeout(int a, int b)
        {
            return a + b;
        }
    }
}
