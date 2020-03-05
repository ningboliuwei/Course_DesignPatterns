using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using 动物运动会_类;

namespace 动物运动会
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			Cat cat1 = new Cat();
			Cat cat2 = new Cat();

			cat1.Shout();
			cat2.Shout();

		}
	}
}