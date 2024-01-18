using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace unittestcourse
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                string result = worldDumbest.ReturnsPikachuIfZero(num);

                if (result == "PIKA PIKA!")
                {
                    Console.WriteLine("passed:WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed:WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
            {
            catch (Exception ex)
            }

                Console.WriteLine(ex);
        }
    }
}
