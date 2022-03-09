namespace 观察者模式_气象站_观察者模式 {
    public interface ISubject {
        void NotifyObserver();
        void RegisterObserver(IObserver observer);

        void RemoveObserver(IObserver observer);
    }
}