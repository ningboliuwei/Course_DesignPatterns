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
			PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), new Pen(Color.Magenta));
			PersonDirector pbThin = new PersonDirector(ptb);
			pbThin.CreatePerson(); //创建瘦小人

			PersonFatBuilder ptb2 = new PersonFatBuilder(pictureBox1.CreateGraphics(), new Pen(Color.Magenta));
			pbThin = new PersonDirector(ptb2);
			pbThin.CreatePerson(); //创建胖小人

			PersonSmallBuilder ptb3 = new PersonSmallBuilder(pictureBox1.CreateGraphics(), new Pen(Color.Green));
			pbThin = new PersonDirector(ptb3);
			pbThin.CreatePerson();
		}
	}
}