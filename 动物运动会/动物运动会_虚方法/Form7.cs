using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using 动物运动会_虚方法;

namespace 动物运动会
{
	public partial class Form7 : Form
	{
		private Animal[] arrayAnimal;

		public Form7()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			arrayAnimal = new Animal[5];

			arrayAnimal[0] = new Cat("叮当");
			arrayAnimal[1] = new Dog("小白");
			arrayAnimal[2] = new Cat("旺财");
			arrayAnimal[3] = new Cat("加菲");
			arrayAnimal[4] = new Dog("古菲");

			for (int i = 0; i < 5; i++)
			{
				arrayAnimal[i].Shout();
			}

			//arrayAnimal[0].Shout();

			//int type = -1;
			//for (int i = 0; i < 5; i++)
			//{
			//	Random random = new Random();

			//	type = random.Next(0, 2);

			//	if (type == 0)
			//	{
			//		arrayAnimal[i] = new Cat("cat" + i+ type);
			//	}
			//	else if (type == 1)
			//	{
			//		arrayAnimal[i] = new Dog("dog" + i + type);
			//	}
			//}
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