#region

using System;
using System.Windows.Forms;

#endregion

namespace 单例模式_菜单事件判断防多开 {
    public partial class Form1 : Form {
        private frmToolBox ftb;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            toolStrip1.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e) {
            if (ftb == null || ftb.IsDisposed) //if (ftb == null)//关掉工具栏后无法重开
            {
                ftb = new frmToolBox();
                ftb.TopLevel = false; //不加就变成顶级，无法添加
                ftb.Parent = this;
                ftb.Show();
            } //与菜单项事件完全一样的代码
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (ftb == null || ftb.IsDisposed) //关掉工具栏后可以重开
                //if (ftb == null)//关掉工具栏后无法重开
            {
                ftb = new frmToolBox();
                ftb.TopLevel = false; //不加就变成顶级，无法添加
                ftb.Parent = this;
                ftb.Show();
            }
        }
    }
}