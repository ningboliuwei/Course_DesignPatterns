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
			//			Graphics gThin = pictureBox1.CreateGraphics();
			//			gThin.DrawEllipse(p, 50, 20, 30, 30); //head
			//			gThin.DrawRectangle(p, 60, 50, 10, 50); //body
			//
			//			//left arm
			//			gThin.TranslateTransform(60, 50);
			//			gThin.RotateTransform(45);
			//			gThin.DrawRectangle(p, 0, 0, 5, 40);
			//			gThin.ResetTransform();
			//			//left arm end
			//
			//			//right arm
			//			gThin.TranslateTransform(70, 55);
			//			gThin.RotateTransform(290);
			//			gThin.DrawRectangle(p, 0, 0, 5, 40);
			//			gThin.ResetTransform();
			//			//right arm end
			//
			//
			//			//left leg
			//			gThin.TranslateTransform(60, 100);
			//			gThin.RotateTransform(20);
			//			gThin.DrawRectangle(p, 0, 0, 5, 60);
			//			gThin.ResetTransform();
			//			//left leg end
			//
			//			//right leg
			//			gThin.TranslateTransform(65, 100);
			//			gThin.RotateTransform(320);
			//			gThin.DrawRectangle(p, 0, 0, 5, 60);
			//			gThin.ResetTransform();
			//			//right leg end
			//----------------以上为画瘦小人代码


			//----------------以下为画胖小人代码
			Graphics gFat = pictureBox1.CreateGraphics();
			gFat.DrawEllipse(p, 50, 20, 30, 30); //head
			gFat.DrawEllipse(p, 50, 50, 30, 50); //body

			//left arm
			gFat.TranslateTransform(50, 50);
			gFat.RotateTransform(45);
			gFat.DrawEllipse(p, 0, 0, 10, 40);
			gFat.ResetTransform();
			//left arm end

			//right arm
			gFat.TranslateTransform(70, 60);
			gFat.RotateTransform(290);
			gFat.DrawEllipse(p, 0, 0, 10, 40);
			gFat.ResetTransform();
			//right arm end


			//left leg
			gFat.TranslateTransform(60, 100);
			gFat.RotateTransform(20);
			gFat.DrawEllipse(p, 0, 0, 10, 60);
			gFat.ResetTransform();
			//left leg end

			//right leg
			gFat.TranslateTransform(65, 100);
			gFat.RotateTransform(320);
			gFat.DrawEllipse(p, 0, 0, 10, 60);
			gFat.ResetTransform();
			//right leg end
			//----------------以上为画胖小人代码
		}
	}
}