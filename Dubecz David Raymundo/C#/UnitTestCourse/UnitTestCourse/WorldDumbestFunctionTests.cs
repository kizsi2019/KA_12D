using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                string result = worldDumbest.ReturnsPikachuIfZero(num);

                if (result == "PIKACHU")
                {
                    Console.WriteLine("passed");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
