using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem
{
    internal class Test
    {
        static void Main(string[] args)
        {
            MathCalculation mathJob = new MathCalculation();
            mathJob.DoTheMath();
            Console.ReadLine();
        }
    }
}
