namespace 迭代器模式_电视机机顶盒遥控器公共父类;

public abstract class IRemote {
    public abstract bool HasNext();
    public abstract Channel Next();
}