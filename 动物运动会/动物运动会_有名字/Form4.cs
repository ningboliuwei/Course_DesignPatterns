#region

using System;
using System.Windows.Forms;
using 动物运动会_有名字;

#endregion

namespace 动物运动会 {
    public partial class Form4 : Form {
        public Form4() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            //调用不同参数的构造函数
            //Cat cat = new Cat();
            var cat = new Cat("叮当");

            MessageBox.Show(cat.Shout());
        }
    }
}