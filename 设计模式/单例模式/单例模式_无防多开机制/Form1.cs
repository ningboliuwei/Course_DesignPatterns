#region

using System;
using System.Windows.Forms;

#endregion

namespace 单例模式_无防多开机制 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e) {
            var ftb = new frmToolBox();
            ftb.TopLevel = false; //不加就变成顶级，无法添加
            ftb.Parent = this;
            ftb.Show();
        }
    }
}