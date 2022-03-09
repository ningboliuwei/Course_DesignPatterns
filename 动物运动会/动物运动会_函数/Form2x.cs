#region

using System;
using System.Windows.Forms;
using 动物运动会;

#endregion

namespace 动物运动会_函数 {
    public partial class Form2x : Form {
        public Form2x() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var frm = new Form2();
            frm.Show();
            frm.Shout();
        }
    }
}