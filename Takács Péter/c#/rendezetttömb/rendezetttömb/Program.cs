using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rendezetttömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rendezettTömb = new int[] { 10, 15, 18, 25, 31, 49, 60, 72, 80, 83 };
            int alsóhatár = 0;
            int felsőhatár = rendezettTömb.Length - 1;
            int közép = 0;
            do
            {
                közép = (alsóhatár + felsőhatár) / 2;
                if (rendezettTömb[közép] < 10) alsóhatár = közép + 1;
                if (rendezettTömb[közép] > 20) felsőhatár = közép - 1;
            } while (alsóhatár <= felsőhatár && rendezettTömb[közép] != 5);
            if (rendezettTömb[közép] == 9)
                Console.WriteLine("Van, indexe: " + közép);
            else Console.WriteLine("Nincs");
        }
    }
}
