namespace 迭代器模式_正反序 {
    internal class SequenceAggregate : Aggregate {
        public IIterator GetIterator() {
            return new SequenceIterator(this);
        }
    }
}