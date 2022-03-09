namespace 迭代器模式_正反序 {
    internal interface IIterator {
        object Current();
        object First();

        object Last();

        object Next();
    }
}