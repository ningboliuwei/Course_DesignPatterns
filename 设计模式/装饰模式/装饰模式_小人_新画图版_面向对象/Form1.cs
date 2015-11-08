using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using 装饰模式;

namespace 装饰模式_小人_新画图版_面向对象
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

			//第一种装扮——只显示基础版胖人
//			Person person = new PersonFat(g, new Pen(Color.Maroon));//胖人
//			person.Show();//只显示基础版小人
			//第一种装扮结束

			//第二种装扮——只显示基础版瘦人
			//Person person = new PersonThin(g, new Pen(Color.Maroon));//瘦人
			//person.Show();
			//第二种装扮结束

			//第三种装扮——只穿一条垮裤的瘦人
			//Person person = new PersonThin(g, new Pen(Color.Maroon));
			//BigTrousers bigTrousers = new BigTrousers(g, new Pen(Color.Black));

			//bigTrousers.Decorate(person);
			//bigTrousers.Show();
			//第三种装扮结束

			//第四种装扮——穿领带与球鞋的瘦人
			//Person person = new PersonThin(g, new Pen(Color.Maroon));
			//Sneakers sneakers = new Sneakers(g, new Pen(Color.Red));

			//sneakers.Decorate(person);

			//Tie tie = new Tie(g, new Pen(Color.DarkBlue));

			//tie.Decorate(sneakers);
			//tie.Show();
			//第四种装扮结束

			//第五种装扮——穿球鞋、垮裤与T恤的瘦人
			Person person = new PersonThin(g, new Pen(Color.Maroon));
			Sneakers sneakers = new Sneakers(g, new Pen(Color.Red));

			sneakers.Decorate(person);

			BigTrousers bigTrousers = new BigTrousers(g, new Pen(Color.LightCoral));
			bigTrousers.Decorate(sneakers);

			Shirt shirt = new Shirt(g, new Pen(Color.LightGreen));

			shirt.Decorate(bigTrousers);
			shirt.Show();
			//第五种装扮结束
		}
	}
}