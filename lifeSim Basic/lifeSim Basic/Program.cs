using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace lifeSim_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lifeSim 0.1 by tankstrr");
            Console.WriteLine();
            int startPop = 10000;
            int startYear = -200000;

            double currPop = startPop;
            int currYear = startYear;
            int endYear = 2000;
            double growthRate = 0.0001;
            while (currYear < endYear)
            {
                currPop = currPop + (currPop * growthRate);
                Console.WriteLine("Year: {0}         Pop: {1:N0}", currYear, currPop);
                currYear++;
            }
            Console.WriteLine("..press any key to exit");
            Console.ReadKey();
        }
    }
}
