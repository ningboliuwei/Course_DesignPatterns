#region

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace 建造者模式_画小人_静态工厂版 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e) {
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var p = new Pen(Color.Magenta);

            var g = pictureBox1.CreateGraphics();
            // PersonBuilder.CreatePersonFat(g, p); //创建一个胖小人

            PersonBuilder.CreatePersonThin(g, p);//创建一个瘦小人
        }
    }
}