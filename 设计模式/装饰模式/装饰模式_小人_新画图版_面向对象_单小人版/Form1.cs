using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace 装饰模式_小人_新画图版_面向对象_单小人版
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Person person = new Person(pictureBox1.CreateGraphics());

			person.Show();
		}
	}
}