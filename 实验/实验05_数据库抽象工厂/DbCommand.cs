namespace 实验05_数据库抽象工厂 {
    internal class DbCommand {
        public string CommandText { get; set; }
        public DbConnection Connection { get; set; }

        public virtual void Execute() {
        }
    }
}