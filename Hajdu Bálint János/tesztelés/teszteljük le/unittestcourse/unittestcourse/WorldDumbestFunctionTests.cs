using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnittestCourse1;

namespace unittestcourse
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnPikachuIfZero_ReturnString()
        {
			try
			{
				int num = 0;
				WorldDumbestFunction worldDumbest = new WorldDumbestFunction();
				string result worldDumbest.ReturnsPikachuIfZero(num);
				if (result == "Pikachu") ;
				{
					Console.WriteLine("WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
				}
			    else
				{
                    Console.WriteLine("Failed:WorldDumbestFunction_ReturnPikachuIfZero_ReturnString");
                }


			}
			catch (Exception ex)
			{
                Console.WriteLine(ex);

                
			}
        }
    }
}
