using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using 动物运动会_继承;

namespace 动物运动会
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			//猫叫
			Cat cat = new Cat("加菲");
			MessageBox.Show(cat.Shout());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//狗叫
			Dog dog = new Dog("旺财");
			MessageBox.Show(dog.Shout());
		}
	}
}