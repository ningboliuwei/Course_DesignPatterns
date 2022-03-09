#region

using System;
using System.Windows.Forms;

#endregion

namespace 观察者模式_事件机制_系统控件 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // 原生的写法，等同于 DoMethod method = MethodA;
            DoMethod method = MethodA;
//          DoMethod method = MethodB;
//            method += MethodB;
//            method -= MethodA;
            method.Invoke();
        }

        private void MethodA() {
            MessageBox.Show("MethodA");
        }

        private void MethodB() {
            MessageBox.Show("MethodB");
        }

        private delegate void DoMethod();
    }
}