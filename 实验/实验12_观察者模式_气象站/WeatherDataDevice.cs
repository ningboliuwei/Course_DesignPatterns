﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实验12_观察者模式_气象站
{
    abstract class WeatherDataDevice
    {
        public virtual void Update(Subject subject) {
            
        }
    }
}
