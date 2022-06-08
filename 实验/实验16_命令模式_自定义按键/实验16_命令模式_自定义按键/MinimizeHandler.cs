#region

using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class MinimizeHandler {
        public void MinimizeForm(Form form) {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}