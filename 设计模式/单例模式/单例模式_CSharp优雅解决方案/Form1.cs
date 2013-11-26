using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式_CSharp优雅解决方案
{
    public partial class Form1 : Form
    {
        private frmToolBox ftb;

        public Form1()
        {
            InitializeComponent();
        }

        private void 工具栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmToolBox.Instance.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmToolBox.Instance.Show();
        }
    }
}