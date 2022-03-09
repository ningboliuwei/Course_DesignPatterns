#region

using System;
using System.IO;
using System.Windows.Forms;

#endregion

namespace 观察者模式_更改数据事件 {
    public partial class Form2 : Form {
        public delegate void DataEventHandler();

        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            WriteData(textBox1.Text);
            OnDataChanged();
            Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        public event DataEventHandler DataChanged;

        protected virtual void OnDataChanged() {
            DataChanged?.Invoke();
        }

        private void WriteData(string data) {
            var filePath = $"{Application.StartupPath}\\data.txt";

            try {
                File.WriteAllText(filePath, data);
            }
            catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}