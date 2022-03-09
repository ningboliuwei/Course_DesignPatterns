namespace 抽象工厂模式_数据库_抽象工厂_反射版 {
    internal interface IUser {
        User GetUser(int id);
        void Insert(User user);
    }
}