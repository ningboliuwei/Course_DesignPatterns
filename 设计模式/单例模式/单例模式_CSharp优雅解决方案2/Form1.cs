using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式_CSharp优雅解决方案2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmToolBox.Instance.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmToolBox.Instance.Show();
        }
    }
}