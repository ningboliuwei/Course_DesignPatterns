#region

using System;
using System.Windows.Forms;

#endregion

namespace 动物运动会_抽象类 {
    public partial class Form9 : Form {
        private Animal[] arrayAnimal;

        public Form9() {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            arrayAnimal = new Animal[5];

            //无法创建抽象类Animal的实例
            // Animal animal1 = new Animal();

            arrayAnimal[0] = new Cat("叮当");
            arrayAnimal[1] = new Dog("小白");
            arrayAnimal[2] = new Dog("旺财");
            arrayAnimal[3] = new Cat("加菲");
            arrayAnimal[4] = new Dog("古菲");
        }

        private void btnShout_Click(object sender, EventArgs e) {
            foreach (var animal in arrayAnimal) {
                MessageBox.Show(animal.Shout());
            }
        }
    }
}