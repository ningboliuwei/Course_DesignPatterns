using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 动物运动会_泛型
{
	public partial class Form11 : Form
	{
		/// <summary>
		/// 
		/// </summary>
		//private ArrayList arrayListAnimal = new ArrayList();
		private List<Animal> listAnimal = new List<Animal>();

		public Form11()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			//arrayListAnimal.Add(new Cat("叮当"));
			//arrayListAnimal.Add(new Dog("小白"));
			//arrayListAnimal.Add(new Dog("旺财"));
			//arrayListAnimal.Add(new Cat("加菲"));
			//arrayListAnimal.Add(new Dog("古菲"));
			listAnimal.Add(new Cat("叮当"));
			listAnimal.Add(new Dog("小白"));
			//listAnimal.Add("hello");
			listAnimal.Add(new Monkey());

			//int i = 0;
			//arrayListAnimal.Add(i);
			//listAnimal.Add(i);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//foreach (Animal animal in arrayListAnimal)
			foreach (Animal animal in listAnimal)
			{
				MessageBox.Show(animal.Shout());
			}
		}
	}
}