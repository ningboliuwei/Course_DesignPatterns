#region

using System;
using System.Windows.Forms;

#endregion

namespace 动物运动会 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            Shout();
        }

        private void Form2_Load(object sender, EventArgs e) {
        }

        public void Shout() {
            MessageBox.Show("喵~");
        }
    }
}