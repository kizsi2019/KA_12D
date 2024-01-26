using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittestCourse1
{
    public class WorldDumbestFunction
    {
        public string ReturnsPikachuIfZero(int num)
        {
            if (num == 0)
            {
                return "PIACHU";
            }
            else
            {
                return "Sajnos nem Pikachu";
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
