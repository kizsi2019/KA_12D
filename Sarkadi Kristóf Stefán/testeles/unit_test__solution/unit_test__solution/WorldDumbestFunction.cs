using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit_test__solution
{
    public class WorldDumbestFunctionTests
    {
        //Naming Convention Classname_MethodName_EspectedResult
        public static void WorldDumbestFunction_ReturnPikachuifZero_ReturnString()
        {
            try
            {
                //Arrange - Rendezés - szerezd be a változókat, osztályokat, fügvényeket
                int num = 0;
                WorldDumbestFunction worldDumbest = new WorldDumbestFunction();

                //Act - Cselekvés - Futtasd a fügvényt
                string result = worldDumbest.ReturnsPikachuifZero(num);

                //Assert - Hozzárendelés - bármit ad vissza, úgy van ahogy akarod
                if (result == "PIKACHU!")
                {
                    Console.WriteLine("Passed: WorldDumbestFunction_ReturnPikachuifZero_ReturnString");
                }
                else
                {
                    Console.WriteLine("Failed: WorldDumbestFunction_ReturnPikachuifZero_ReturnString");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }
    }
}
