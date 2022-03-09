#region

using System;
using System.Windows.Forms;

#endregion

namespace 观察者模式_事件机制_系统控件 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void AnotherThingToDoAfterClick(object sender, EventArgs e) {
            MessageBox.Show("another thing to do");
        }

        private void button1_Click(object sender, EventArgs e) {
        }

        private void Form1_Load(object sender, EventArgs e) {
            button1.Click += SomethingToDoAfterClick;
            button1.Click += AnotherThingToDoAfterClick;
        }

        private void SomethingToDoAfterClick(object sender, EventArgs e) {
            MessageBox.Show("something to do");
        }
    }
}