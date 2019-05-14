using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 观察者模式_更改数据事件 {
    public partial class Form3 : Form {
        private string _data;

        public Form3(string data) {
            InitializeComponent();
            _data = data;
        }

        private void Form3_Load(object sender, EventArgs e) {
            numericUpDown1.Value = Convert.ToInt32(_data);
        }
    }
}