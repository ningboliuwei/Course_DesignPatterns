#region

using System;
using System.Windows.Forms;
using 动物运动会_类;

#endregion

namespace 动物运动会 {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            var cat1 = new Cat();
            var cat2 = new Cat();

            cat1.Shout();
            cat2.Shout();
        }
    }
}