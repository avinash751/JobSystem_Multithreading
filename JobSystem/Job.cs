﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSystem
{
    public class Job<T>
    {
        public Action<T> FinishedJob;

        public virtual void DoJob()
        {
        
        }
       
    }
}
