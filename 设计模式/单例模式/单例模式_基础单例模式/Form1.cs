#region

using System;
using System.Windows.Forms;

#endregion

namespace 单例模式_基础单例模式 {
    public partial class Form1 : Form {
        private frmToolBox ftb;

        public Form1() {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            frmToolBox.GetInstance().Show();
        }

        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e) {
            frmToolBox.GetInstance().Show();
        }
    }
}