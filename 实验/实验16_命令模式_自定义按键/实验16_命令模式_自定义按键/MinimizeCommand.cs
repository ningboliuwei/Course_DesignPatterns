#region

using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class MinimizeCommand : ICommand {
        private readonly MinimizeHandler _minimizeHandler;
        private Form _form;

        public MinimizeCommand(Form from) {
            _minimizeHandler = new MinimizeHandler();
            _form = from;
        }

        public void Execute() {
            _minimizeHandler.MinimizeForm(_form);
        }
    }
}