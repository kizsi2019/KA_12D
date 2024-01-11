using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using unittestcourse;

namespace UnittestCourse1
{
    public class WorldDumbestFunction
    {
        public string ReturnPikachuIfZero(int num)
        {
            if (num == 0)
            {
                return "Pikachu";
            }
            else
            {
                return "sajnos nem Pikachu ";
            }
            }
        }
    }
internal class Program
    {
        static void Main(string[]args)
        {
        WorldDumbestFunctionTests.WorldDumbestFunction_ReturnPikachuIfZero_ReturnString();
        Console.WriteLine();
            
        }
    }
