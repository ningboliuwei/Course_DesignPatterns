using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace 装饰模式_小人_新画图版_装饰模式_演示版
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			#region 基本形象
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);
			Person person = new PersonThin(g);
			person.Show();
			#endregion
		}

		private void button2_Click(object sender, EventArgs e)
		{
			#region 裤子

			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);
			Pants pants = new Pants(g);

			pants.Decorate(person);
			pants.Show();
			#endregion
		}

		private void button3_Click(object sender, EventArgs e)
		{
			#region 裤子+上衣

			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

			Pants pants = new Pants(g);
			pants.Decorate(person);

			Jacket jacket = new Jacket(g);
			jacket.Decorate(pants);
			jacket.Show();

			#endregion
		}

		private void button4_Click(object sender, EventArgs e)
		{
			#region 裤子+领带
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

			Pants pants = new Pants(g);
			pants.Decorate(person);

			Tie tie = new Tie(g);
			tie.Decorate(pants);
			tie.Show();
			#endregion
		}

		private void button5_Click(object sender, EventArgs e)
		{
			#region 短裤
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

			Shorts shorts = new Shorts(g);
			shorts.Decorate(person);
			shorts.Show();

			#endregion
		}

		private void button6_Click(object sender, EventArgs e)
		{
			#region 短裤
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

			Shorts shorts = new Shorts(g);
			shorts.Decorate(person);


			Hat hat = new Hat(g);
			hat.Decorate(shorts);
			hat.Show();

			#endregion
		}

		private void button7_Click(object sender, EventArgs e)
		{
			#region 正式装扮
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

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
		}

		private void button8_Click(object sender, EventArgs e)
		{
			#region 休闲装扮
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(pictureBox1.BackColor);

			Person person = new PersonThin(g);

			Shorts shorts = new Shorts(g);
			shorts.Decorate(person);

			Shirt shirt = new Shirt(g);
			shirt.Decorate(shorts);

			Hat hat = new Hat(g);
			hat.Decorate(shirt);

			Sneakers sneakers = new Sneakers(g);
			sneakers.Decorate(hat);
			sneakers.Show();

			#endregion
		}
	}
}