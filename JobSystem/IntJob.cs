using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem
{
    public class IntJob : Job<int>
    {
        int sum = 0;
        public override void DoJob()
        {
            for (int i = 0; i < 10; i++)
            {
                sum += i;
                int j = 0;
                while (j < 10)
                {
                    sum += (j+sum)*2;
                    j++;
                    Console.WriteLine($"The current Sum = {sum}");
                }  
            }
           
            FinishedJob?.Invoke(sum);
        }
    }
}
