namespace 观察者模式_股票_抽象观察对象版 {
    internal abstract class Observer {
        protected Subject Subject;
        public abstract void Response();

        public abstract void SetSubject(Subject subject);
    }
}