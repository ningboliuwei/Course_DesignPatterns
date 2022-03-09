namespace 抽象工厂模式_数据库_抽象工厂_非反射版 {
    internal class MysqlFactory : IFactory {
        public IDepartment CreateDepartment() {
            return new MysqlDepartment();
        }

        public IUser CreateUser() {
            return new MysqlUser();
        }
    }
}