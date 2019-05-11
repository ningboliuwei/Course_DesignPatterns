using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace 观察者模式_股票_单向组合关系版 {
    abstract class Observer {
        public abstract void Response(Subject subject);
    }
}