using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittestCourse
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
			try
			{
                //Arrange - Intézkedés - szerezd be változókat, osztályokat, fügvényeket
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();
                // Act - Cselekvés - Futtasd a fügvényt
                string resault = worldDumbest.ReturnsPikachuIfZero(num);
                //Assert - Hozzárendelés - bármi ad vissza, úgy van ahogy akarom
                if(resault == "Pikachu!")
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
			}
        }
    }
}
