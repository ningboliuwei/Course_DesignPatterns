namespace 迭代器模式_普通 {
    internal abstract class Iterator {
        public abstract object Current();
        public abstract object First();

        public abstract object Last();

        public abstract object Next();
    }
}