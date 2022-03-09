namespace 实验05_数据库抽象工厂 {
    internal class DbConnection {
        public string ConnectionString { get; set; }

        public virtual void Close() {
        }

        public virtual void Open() {
        }
    }
}