#region

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace 建造者模式_画小人_工厂版 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var builder = new PersonFatBuilder(pictureBox1.CreateGraphics(), new Pen(Color.Magenta));
            //创建一个瘦小人
            builder.Build();

            //PersonFatBuilder ptb2 = new PersonFatBuilder(pictureBox1.CreateGraphics(), new Pen(Color.LightBlue));
            //ptb2.Build();//创建一个胖小人

            //PersonFatBuilder ptb3 = new PersonFatBuilder(pictureBox1.CreateGraphics(), new Pen(Color.DeepPink));
            //ptb3.Build();//创建另一个胖小人
        }
    }
}