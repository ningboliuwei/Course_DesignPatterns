#region

using System;
using System.Windows.Forms;
using 动物运动会_继承;

#endregion

namespace 动物运动会 {
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            //猫叫
            var cat = new Cat("加菲");
            MessageBox.Show(cat.Shout());
        }

        private void button1_Click(object sender, EventArgs e) {
            //狗叫
            var dog = new Dog("旺财");
            //dog.ShoutNum = 5;
            MessageBox.Show(dog.Shout());

            var s = "hello world";
        }

        private void button2_Click(object sender, EventArgs e) {
        }
    }
}