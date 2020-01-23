using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleDependency.Services
{
    public class CounterService
    {
        protected internal ICounter Counter;
        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
        
    }
}
