using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 动物运动会_抽象类
{
	public partial class Form8 : Form
	{
		private Animal[] arrayAnimal;

		public Form8()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			arrayAnimal = new Animal[5];

			//Animal animal1 = new Animal();
			//无法创建抽象类Animal的实例

			arrayAnimal[0] = new Cat("叮当");
			arrayAnimal[1] = new Dog("小白");
			arrayAnimal[2] = new Dog("旺财");
			arrayAnimal[3] = new Cat("加菲");
			arrayAnimal[4] = new Dog("古菲");
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (Animal animal in arrayAnimal)
			{
				MessageBox.Show(animal.Shout());
			}
		}
	}
}