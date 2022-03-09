namespace 命令模式_自定义功能键_命令队列版 {
    internal class FunctionButton {
        private readonly CommandQueue m_commandQueue = new CommandQueue();

        public FunctionButton(string name) {
            Name = name;
        }

        public string Name { get; set; }

        public void AddCommand(Command command) {
            m_commandQueue.Add(command);
        }

        public void Click() {
            m_commandQueue.Execute();
            //增加在点击时写入日志的功能
            m_commandQueue.WriteToLog(string.Format("r:\\{0}log.txt", Name));
        }

        public void RemoveCommand(Command command) {
            m_commandQueue.Remove(command);
        }
    }
}