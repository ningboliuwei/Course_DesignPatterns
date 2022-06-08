namespace 迭代器模式_电视机机顶盒迭代器模式;

public interface IIterator {
    public Channel GetCurrentItem();
    public bool HasNext();
    public void Next();
}