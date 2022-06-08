#region

using System.IO;
using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public class HelpHandler {
        public void Display() {
            var path = Directory.GetCurrentDirectory() + "\\" + "help.chm";
            Help.ShowHelp(null, path);
        }
    }
}