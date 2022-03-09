#region

using System;
using System.Windows.Forms;
using 动物运动会_虚方法改进;

#endregion

namespace 动物运动会 {
    public partial class Form8 : Form {
        private Animal[] arrayAnimal;

        public Form8() {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e) {
            arrayAnimal = new Animal[5];

            arrayAnimal[0] = new Cat("叮当");
            arrayAnimal[1] = new Dog("小白");
            arrayAnimal[2] = new Dog("旺财");
            arrayAnimal[3] = new Cat("加菲");
            arrayAnimal[4] = new Dog("古菲");

            // int type = -1;
            // for (var i = 0; i < 5; i++) {
            //     var random = new Random();
            //
            //     type = random.Next(0, 2);
            //
            //     if (type == 0) {
            //         arrayAnimal[i] = new Cat("cat" + i + type);
            //     }
            //     else if (type == 1) {
            //         arrayAnimal[i] = new Dog("dog" + i + type);
            //     }
            // }

            //第一行若这么写会如何
            //arrayAnimal[0] = new Animal();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            foreach (var animal in arrayAnimal) {
                MessageBox.Show(animal.Shout());
            }
        }
    }
}