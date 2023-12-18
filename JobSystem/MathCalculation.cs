using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem
{
    internal class MathCalculation
    {
        public void DoTheMath()
        {
            IntJob intJob = new IntJob();
            intJob.FinishedJob += OnMathJobFinished;
            JobSystem.GiveJob(intJob);
        }

        private void OnMathJobFinished(int mathResult)
        {
           Console.WriteLine($"The Final Sum = {mathResult}");
        }
    }
}
