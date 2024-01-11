using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_16_unittestcourse
{
    internal class WorldDumbestFunctionTests
    {
        //naming
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //arrange
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if(result == "PIKACHU")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
