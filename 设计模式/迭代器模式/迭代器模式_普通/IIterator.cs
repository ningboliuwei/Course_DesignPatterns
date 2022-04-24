namespace 迭代器模式_普通 {
    public interface IIterator {
        public object CurrentItem();
        public void First();
        public bool HasNext();
        public void Next();
    }
}