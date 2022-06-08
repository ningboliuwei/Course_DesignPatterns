#region

using System;
using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class FunctionButton : Button {
        private ICommand _command;

        protected override void OnClick(EventArgs e) {
            base.OnClick(e);
            _command.Execute();
        }

        public void SetCommand(ICommand command) {
            _command = command;
        }
    }
}