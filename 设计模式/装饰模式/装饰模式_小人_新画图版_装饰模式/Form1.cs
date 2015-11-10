using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace 装饰模式_小人_新画图版_装饰模式
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

			Person person = new PersonThin(g);
			person.Show();

			//#region 正式装扮

			Jacket jacket = new Jacket(g);
			jacket.Decorate(person);
			jacket.Show();

			Shirt shirt = new Shirt(g);
			shirt.Decorate(person);
			shirt.Show();
//
//			Pants pants = new Pants(g);
//			pants.Decorate(shirt);
//			pants.Show();
//
//			Tie tie = new Tie(g);
//			tie.Decorate(pants);
//			tie.Show();
//
//
//
//			Shoes shoes = new Shoes(g);
//			shoes.Decorate(pants);
//			shoes.Show();
//
//			#endregion

			

			

			//#endregion
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