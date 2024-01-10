using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNITTESTCOURSE
{
    public class WorldDumbestFunctionTests
    {
        //Naming Convention Classname_MethodName_espectedResults
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
            try
            {
                //Arrange - Intézkedés - Szerezd be a változókat, osztályokat, függvényeket
                int num = 0;
                WorldDumbestFunction wordDumbest = new WorldDumbestFunction();
                //Act - Cselekvés - futtasd a függvényt
                string result = wordDumbest.ReturnsPikachuIfZero(num);
                //Assert - Hozzárendelés - bármit ad vissza, úgy 
                if (result == "PIKACHU!")
                {
                    Console.WriteLine( "Passed: WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
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
