namespace 职责链模式_请假_职责链模式 {
    internal abstract class Manager {
        public Manager(string name) {
            Name = name;
        }

        public string Name { get; set; }
        public Manager Superior { get; set; }

        public abstract void HandleRequest(Request request);
    }
}