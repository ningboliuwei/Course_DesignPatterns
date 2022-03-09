namespace 命令模式_自定义功能键_命令模式版 {
    internal class FunctionButton {
        private Command m_command;

        public FunctionButton(string name) {
            Name = name;
        }

        public string Name { get; set; }

        public void Click() {
            m_command.Execute();
        }

        public void SetCommand(Command command) {
            m_command = command;
        }
    }
}