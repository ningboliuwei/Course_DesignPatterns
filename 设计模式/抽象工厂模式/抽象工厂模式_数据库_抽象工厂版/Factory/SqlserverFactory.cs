namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal class SqlserverFactory : IFactory {
        public IDepartment CreateDepartment() {
            return new SqlserverDepartment();
        }

        public IUser CreateUser() {
            return new SqlserverUser();
        }
    }
}