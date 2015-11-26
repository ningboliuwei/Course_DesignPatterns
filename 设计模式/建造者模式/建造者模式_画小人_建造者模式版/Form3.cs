using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 建造者模式_画小人_建造者模式版
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			PersonThinBuilder thinBuilder = new PersonThinBuilder(pictureBox1.CreateGraphics());
			PersonDirector thinDirector = new PersonDirector(thinBuilder);
			thinDirector.CreatePerson(); //创建瘦小人

			PersonFatBuilder fatBuilder = new PersonFatBuilder(pictureBox1.CreateGraphics());
			PersonDirector fatDirector = new PersonDirector(fatBuilder);
			fatDirector.CreatePerson(); //创建胖小人
		}
	}
}