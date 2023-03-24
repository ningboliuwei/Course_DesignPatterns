#region

using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class MaximizemizeCommand : ICommand {
        private readonly MaximizeHandler _maximizeHandler;
        private Form _form;

        public MaximizemizeCommand(Form from) {
            _maximizeHandler = new MaximizeHandler();
            _form = from;
        }

        public void Execute() {
            _maximizeHandler.MaximizeForm(_form);
        }
    }
}