using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 装饰模式_小人_新画图版_面向对象_单小人版
{
	class Person
	{
		private Graphics _g;

		public Person(Graphics g)
		{
			_g = g;
		}

		public void Show()
		{
			//head
			_g.DrawEllipse(new Pen(Color.Navy), 50, 15, 30, 30);

			//body
			_g.DrawRectangle(new Pen(Color.Navy), 60, 50, 10, 50);

			//left arm
			_g.TranslateTransform(60, 50);
			_g.RotateTransform(45);
			_g.DrawRectangle(new Pen(Color.Navy), 0, 0, 5, 40);
			_g.ResetTransform();
			//left arm end

			//right arm
			_g.TranslateTransform(70, 55);
			_g.RotateTransform(290);
			_g.DrawRectangle(new Pen(Color.Navy), 0, 0, 5, 40);
			_g.ResetTransform();
			//right arm end

			//left leg
			_g.TranslateTransform(60, 100);
			_g.RotateTransform(20);
			_g.DrawRectangle(new Pen(Color.Navy), 0, 0, 5, 60);
			_g.ResetTransform();
			//left leg end

			//right leg
			_g.TranslateTransform(65, 100);
			_g.RotateTransform(320);
			_g.DrawRectangle(new Pen(Color.Navy), 0, 0, 5, 60);
			_g.ResetTransform();
			//right leg end
		}
	}
}
