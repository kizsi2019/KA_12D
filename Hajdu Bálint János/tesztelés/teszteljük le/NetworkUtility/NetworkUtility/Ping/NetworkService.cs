using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            return "Succes:Ping Sent!";
        }
        public int PingTImeout(int a, int b)
        {
            return a + b;
        }
    }
}
