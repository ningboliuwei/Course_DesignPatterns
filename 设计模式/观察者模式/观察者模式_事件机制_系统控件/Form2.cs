using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 观察者模式_事件机制_系统控件 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        delegate void DoMethod();

        private void MethodA() {
            MessageBox.Show("MethodA");
        }

        private void MethodB() {
            MessageBox.Show("MethodB");
        }

        private void button1_Click(object sender, EventArgs e) {
            // 原生的写法，等同于 DoMethod method = MethodA;
            DoMethod method = new DoMethod(MethodA);
//          DoMethod method = MethodB;
//            method += MethodB;
//            method -= MethodA;
            method.Invoke();
        }
    }
}