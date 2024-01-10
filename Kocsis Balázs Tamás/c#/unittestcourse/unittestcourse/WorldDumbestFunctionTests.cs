using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unittestcourse
{
    public class WorldDumbestFunctionTests
    {
        //naming convention classname_methodname_expectedresults
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
