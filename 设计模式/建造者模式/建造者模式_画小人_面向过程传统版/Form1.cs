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
			//----------------以下为画瘦小人代码
			Graphics gThin = pictureBox1.CreateGraphics();

			//head
			gThin.DrawEllipse(new Pen(Color.OrangeRed), 50, 15, 30, 30);

			//body
			gThin.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);

			//left arm
			gThin.TranslateTransform(60, 50);
			gThin.RotateTransform(45);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
			gThin.ResetTransform();
			//left arm end

			//body
			gThin.FillRectangle(new SolidBrush(Color.SandyBrown), 60, 50, 10, 50);

			//right arm
			gThin.TranslateTransform(70, 55);
			gThin.RotateTransform(290);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 5, 40);
			gThin.ResetTransform();
			//right arm end

			//left leg
			gThin.TranslateTransform(60, 100);
			gThin.RotateTransform(20);
			gThin.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
			gThin.ResetTransform();
			//left leg end

			//right leg
			gThin.TranslateTransform(65, 100);
			gThin.RotateTransform(320);
			gThin.FillRectangle(new SolidBrush(Color.Navy), 0, 0, 5, 60);
			gThin.ResetTransform();
			//right leg end
			//----------------以上为画瘦小人代码


			//----------------以下为画胖小人代码
			//			Graphics gFat = pictureBox1.CreateGraphics();
			//
			//			//head
			//			gFat.DrawEllipse(p, 50, 20, 30, 30);
			//
			//			//body
			//			gFat.FillEllipse(new SolidBrush(Color.SandyBrown), 50, 50, 30, 50); 
			//
			//			//left arm
			//			gFat.TranslateTransform(50, 50);
			//			gFat.RotateTransform(45);
			//			gFat.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
			//			gFat.ResetTransform();
			//			//left arm end
			//
			//			//right arm
			//			gFat.TranslateTransform(70, 60);
			//			gFat.RotateTransform(290);
			//			gFat.FillEllipse(new SolidBrush(Color.DarkRed), 0, 0, 10, 40);
			//			gFat.ResetTransform();
			//			//right arm end
			//
			//
			//			//left leg
			//			gFat.TranslateTransform(60, 100);
			//			gFat.RotateTransform(20);
			//			gFat.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
			//			gFat.ResetTransform();
			//			//left leg end
			//
			//			//right leg
			//			gFat.TranslateTransform(65, 100);
			//			gFat.RotateTransform(320);
			//			gFat.FillEllipse(new SolidBrush(Color.Navy), 0, 0, 10, 60);
			//			gFat.ResetTransform();
			//			//right leg end
			//----------------以上为画胖小人代码
		}
	}
}