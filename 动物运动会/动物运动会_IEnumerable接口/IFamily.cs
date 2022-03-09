namespace 动物运动会_泛型 {
    public interface IFamily<T> where T : class {
        public void Add(T member);
        public void Remove(T member);
    }
}