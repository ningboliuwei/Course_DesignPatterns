#region

using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class MaximizeHandler {
        public void MaximizeForm(Form form) {
            form.WindowState = FormWindowState.Maximized;
        }
    }
}