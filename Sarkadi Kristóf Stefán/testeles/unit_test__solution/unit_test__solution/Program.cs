using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test__solution
{
    public class WorldDumbestFunction 
    { 
        public string ReturnsPikachuifZero(int num)
        {
            if (num == 0)
            {
                return "PIKACHU!";
            }
            else 
            {
                return "Sajnos nem Pikachu...";           
            }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WorldDumbestFunctionTests.WorldDumbestFunction_ReturnPikachuifZero_ReturnString();
            Console.ReadKey();
        }
    }
}
