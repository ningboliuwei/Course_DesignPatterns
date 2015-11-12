using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace 装饰模式_小人_新画图版_装饰模式_双人版
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Graphics g = pictureBox1.CreateGraphics();

			#region 基本形象

			Person person = new PersonThin(g);

			#endregion

			#region 正式装扮

			Pants pants = new Pants(g);
			pants.Decorate(person);

			Jacket jacket = new Jacket(g);
			jacket.Decorate(pants);

			Tie tie = new Tie(g);
			tie.Decorate(jacket);

			Shoes shoes = new Shoes(g);
			shoes.Decorate(tie);
			shoes.Show();

			#endregion

//			#region 休闲装扮
//
			//			Shirt shirt = new Shirt(g);
			//			shirt.Decorate(person);
			//
			//			Shorts shorts = new Shorts(g);
			//			shorts.Decorate(shirt);
			//
			//			Hat hat = new Hat(g);
			//			hat.Decorate(shorts);
			//
			//			Sneakers sneakers = new Sneakers(g);
			//			sneakers.Decorate(hat);
			//			sneakers.Show();
//
//			#endregion

//			#region 混搭装扮
//
//			Pants pants = new Pants(g);
//			pants.Decorate(person);
//
//			Shirt shirt = new Shirt(g);
//			shirt.Decorate(pants);
//
//			Hat hat = new Hat(g);
//			hat.Decorate(shirt);
//
//			Tie tie = new Tie(g);
//			tie.Decorate(hat);
//
//			Sneakers sneakers = new Sneakers(g);
//			sneakers.Decorate(tie);
//			sneakers.Show();
//
//			#endregion
		}

		static string s = "";

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				s += string.Format("new Point({0},{1}),", e.X, e.Y);
				Clipboard.SetText(s);
			}
		}
	}
}