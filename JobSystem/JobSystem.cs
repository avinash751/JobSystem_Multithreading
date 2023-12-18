using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem
{
    internal class JobSystem
    {
        public static void GiveJob<T>(Job<T> submittedJob)
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback((object state) => { submittedJob.DoJob();}),null);
        }
    }
}
