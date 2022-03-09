using System;
using System.Windows.Forms;

namespace 观察者模式_Winform控件事件
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("button be clicked");
        }

        private void button2_Click(object sender, EventArgs e) {
        }
    }
}