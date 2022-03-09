#region

using System;
using System.Collections;
using System.Windows.Forms;

#endregion

namespace 动物运动会_ArrayList {
    public partial class Form10 : Form {
        private readonly ArrayList arrayListAnimal = new ArrayList();

        public Form10() {
            InitializeComponent();
        }

        private void btnShout_Click(object sender, EventArgs e) {
            arrayListAnimal.Add(new Cat("叮当"));
            arrayListAnimal.Add(new Dog("小白"));
            arrayListAnimal.Add(new Dog("旺财"));
            arrayListAnimal.Add(new Cat("加菲"));
            arrayListAnimal.Add(new Dog("古菲"));
        }

        private void button1_Click(object sender, EventArgs e) {
            foreach (Animal animal in arrayListAnimal) {
                MessageBox.Show(animal.Shout());
            }
        }
    }
}