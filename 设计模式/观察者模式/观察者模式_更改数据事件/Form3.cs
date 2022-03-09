#region

using System;
using System.Windows.Forms;

#endregion

namespace 观察者模式_更改数据事件 {
    public partial class Form3 : Form {
        private readonly string _data;

        public Form3(string data) {
            InitializeComponent();
            _data = data;
        }

        private void Form3_Load(object sender, EventArgs e) {
            numericUpDown1.Value = Convert.ToInt32(_data);
        }
    }
}