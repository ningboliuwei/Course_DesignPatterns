using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式
{
	class PersonThin : Person
	{
		public PersonThin(Graphics g) : base(g)
		{
		}


		public override void Show()
		{
			#region 画瘦小人代码

			//head
			_g.DrawEllipse(new Pen(Color.OrangeRed, 2), 50, 20, 45, 45);

			//right arm
			_g.TranslateTransform(80, 77);
			_g.RotateTransform(290);
			_g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 7, 60);
			_g.ResetTransform();
			//right arm end

			//body
			_g.FillRectangle(new SolidBrush(Color.SandyBrown), 65, 70, 17, 70);

			//left arm
			_g.TranslateTransform(65, 70);
			_g.RotateTransform(45);
			_g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 7, 60);
			_g.ResetTransform();
			//left arm end


			//left leg
			_g.TranslateTransform(65, 140);
			_g.RotateTransform(20);
			_g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 10, 80);
			_g.ResetTransform();
			//left leg end

			//right leg
			_g.TranslateTransform(70, 143);
			_g.RotateTransform(320);
			_g.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 10, 80);
			_g.ResetTransform();
			//right leg end

			#endregion
		}
	}
}