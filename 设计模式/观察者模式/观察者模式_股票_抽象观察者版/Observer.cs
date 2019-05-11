using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace 观察者模式_股票_抽象观察者版 {
    abstract class Observer {
        protected Stock Stock;

        public abstract void SetStock(Stock stock);
        public abstract void Response();
    }
}