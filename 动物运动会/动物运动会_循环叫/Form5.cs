using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using 动物运动会_循环叫;

namespace 动物运动会
{
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			Cat cat = new Cat("加菲");

			cat.ShoutNum = 3;
			//MessageBox.Show(cat.ShoutNum.ToString());
			MessageBox.Show(cat.Shout());
		}
	}
}