﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 动物运动会
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void btnShout_Click(object sender, EventArgs e)
		{
			Shout();
		}

		public void Shout()
		{
			MessageBox.Show("喵~");
		}
	}
}