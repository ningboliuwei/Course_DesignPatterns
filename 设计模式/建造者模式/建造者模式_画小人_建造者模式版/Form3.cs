#region

using System;
using System.Windows.Forms;

#endregion

namespace 建造者模式_画小人_建造者模式版 {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            var thinBuilder = new PersonThinBuilder(pictureBox1.CreateGraphics());
            var thinDirector = new PersonDirector(thinBuilder);
            thinDirector.CreatePerson(); //创建瘦小人

            var fatBuilder = new PersonFatBuilder(pictureBox1.CreateGraphics());
            var fatDirector = new PersonDirector(fatBuilder);
            fatDirector.CreatePerson(); //创建胖小人
        }
    }
}