﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_单向组合关系版 {
    class Bond : Subject {
        public string Company { get; set; }
        public double Price { get; set; }
    }
}