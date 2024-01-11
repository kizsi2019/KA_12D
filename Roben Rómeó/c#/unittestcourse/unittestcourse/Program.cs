using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace unittestcourse
{
    public class WorldDumbestFunction
    {
        public string ReturnsPikachuIfZero(int num)
    {
            if (num == 0)
                return "PIKA PIKA!";
            else
                return "a faszorru pikachu nem boldog";
    }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
