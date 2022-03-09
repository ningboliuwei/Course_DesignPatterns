namespace 迭代器模式_正反序 {
    internal class ReverseAggregate : Aggregate {
        public IIterator GetIterator() {
            return new ReverseIterator(this);
        }
    }
}