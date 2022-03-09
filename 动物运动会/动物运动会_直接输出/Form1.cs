#region

using System;
using System.Windows.Forms;

#endregion

namespace 动物运动会 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            MessageBox.Show("喵~");
        }
    }
}