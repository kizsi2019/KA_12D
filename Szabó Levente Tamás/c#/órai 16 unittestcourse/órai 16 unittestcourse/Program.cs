using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_16_unittestcourse
{
    public class WorldDumbestFunction
    {
        public string ReturnsPikachuIfZero( int num)
        {
            if (num == 0)
            {
                return "PIKACHU";
            }
            else
            {
                return "PIKASONIC";
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WorldDumbestFunctionTests.WorldDumbestFunction_ReturnPikachuIfZero_ReturnString();
            Console.ReadKey();
        }
    }
}
