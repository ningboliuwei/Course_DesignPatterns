#region

using System;
using System.Windows.Forms;
using 动物运动会_循环叫;

#endregion

namespace 动物运动会 {
    public partial class Form5 : Form {
        public Form5() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            var cat = new Cat("加菲");
            cat.ShoutNum = 5;
            //MessageBox.Show(cat.ShoutNum.ToString());
            MessageBox.Show(cat.Shout());
        }
    }
}