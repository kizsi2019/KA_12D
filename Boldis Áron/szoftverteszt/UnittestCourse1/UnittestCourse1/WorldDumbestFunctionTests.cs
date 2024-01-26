using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittestCourse1
{
    public class WorldDumbestFunctionTests
    {
        //Naming Convention Classname_MethodName_ExpectedResults
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - intézkedés - szerezd be a változókat, osztályokat, függvényeket
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();
                // Act - Cselekvés - Futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);
                // Assert - Hozzárendelés - bármit ad vissza, ugy van ahogy akarom
                if (result == "PIKACHU")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }

                

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
