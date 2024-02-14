using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestCourse
{
    public class WorldDumbestFunctionTests
    {
        //Naming Convention Classname_MethodName_ExpectedResults
        public static void WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString()
        {
            try
            {
                // Arrange - Rendezés - Szerezz be változókat, osztályokat, függvényeket
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                // Act - Cselekvés - Futtasd a függvényt
                string result = worldDumbest.ReturnsPikachuIfZero(num);

                // Assert - Hozzárendelés - Bármit ad vissza, úgy van ahogy akarom
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnsPikachuIfZero_ReturnString");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}