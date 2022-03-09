#region

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace 观察者模式_更改数据事件 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var frm = new Form2();
            frm.DataChanged += ShowDataInForm1;
            frm.DataChanged += ShowDataInForm3;
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e) {
            ShowDataInForm1();
        }

        private void ShowDataInForm1() {
            var filePath = $"{Application.StartupPath}\\data.txt";

            try {
                label1.Text = File.ReadAllText(filePath);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        private void ShowDataInForm3() {
            var frm = new Form3(label1.Text);
            frm.Show();
        }
    }
}