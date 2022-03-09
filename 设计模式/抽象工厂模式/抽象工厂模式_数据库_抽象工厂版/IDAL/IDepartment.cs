namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal interface IDepartment {
        Department GetDepartment(int id);
        void Insert(Department department);
    }
}