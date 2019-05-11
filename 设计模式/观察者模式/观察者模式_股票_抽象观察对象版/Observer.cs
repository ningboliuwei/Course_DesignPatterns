using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace 观察者模式_股票_抽象观察对象版 {
    abstract class Observer {
        protected Subject Subject;

        public abstract void SetSubject(Subject subject);
        public abstract void Response();
    }
}

