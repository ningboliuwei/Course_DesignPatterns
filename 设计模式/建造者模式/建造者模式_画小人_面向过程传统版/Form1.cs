using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 建造者模式_画小人_面向过程传统版
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Pen p = new Pen(Color.Magenta);

			//----------------以下为画瘦小人代码
			Graphics gThin = pictureBox1.CreateGraphics();
			gThin.DrawEllipse(p, 50, 20, 30, 30); //head
			gThin.DrawRectangle(p, 60, 50, 10, 50); //body
			gThin.DrawLine(p, 60, 50, 40, 100); //left arm
			gThin.DrawLine(p, 70, 50, 90, 100); //right arm
			//gThin.DrawLine(p, 60, 100, 45, 150); //left leg
			gThin.DrawLine(p, 70, 100, 85, 150); //right leg
			//----------------以上为画瘦小人代码

			//----------------以下为画胖小人代码
			//Graphics gFat = pictureBox1.CreateGraphics();

			//gFat.DrawEllipse(p, 50, 20, 30, 30);//head
			//gFat.DrawEllipse(p, 45, 50, 40, 50);//body
			//gFat.DrawLine(p, 50, 50, 30, 100);//left arm
			//gFat.DrawLine(p, 80, 50, 100, 100);//right arm
			//gFat.DrawLine(p, 60, 100, 45, 150);//left leg
			//gFat.DrawLine(p, 70, 100, 85, 150);//right leg
			//----------------以上为画胖小人代码
		}
	}
}