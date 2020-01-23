﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleDependency.Services
{
    public class RandomCounter : ICounter
    {
        static Random rnd = new Random();
        private int _value;
        public RandomCounter()
        {
            _value = rnd.Next(0, 1000000);
        }
        public int Value
        {
            get { return _value; }
        }

    }
}
