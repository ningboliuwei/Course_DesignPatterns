using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_股票_抽象观察对象版 {
    class Stock : Subject {
        public string Symbol { get; set; }
        public double Price { get; set; }
    }
}