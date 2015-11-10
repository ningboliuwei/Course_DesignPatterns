using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace 装饰模式_小人_新画图版_面向过程
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			#region 画瘦小人代码

			Graphics gThin = pictureBox1.CreateGraphics();

			//head
			gThin.DrawEllipse(new Pen(Color.OrangeRed, 2), 50, 20, 45, 45);

			//right arm
			gThin.TranslateTransform(80, 77);
			gThin.RotateTransform(290);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 7, 60);
			gThin.ResetTransform();
			//right arm end

			//body
			gThin.FillRectangle(new SolidBrush(Color.SandyBrown), 65, 70, 17, 70);

			//left arm
			gThin.TranslateTransform(65, 70);
			gThin.RotateTransform(45);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 7, 60);
			gThin.ResetTransform();
			//left arm end


			//left leg
			gThin.TranslateTransform(65, 140);
			gThin.RotateTransform(20);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 10, 80);
			gThin.ResetTransform();
			//left leg end

			//right leg
			gThin.TranslateTransform(70, 143);
			gThin.RotateTransform(320);
			gThin.FillRectangle(new SolidBrush(Color.DarkRed), 0, 0, 10, 80);
			gThin.ResetTransform();
			//right leg end

			#endregion

//			#region 休闲装扮
//
//			//hat
//			gThin.FillPie(new SolidBrush(Color.DarkBlue), 50, 20, 45, 35, 180, 180);
//			gThin.DrawLine(new Pen(Color.DarkBlue, 3), 50, 37, 120, 35);
//			//hat end
//
//			//shorts
//			gThin.FillPolygon(
//				new SolidBrush(Color.YellowGreen),
//				new Point[]
//				{
//					new Point(60, 130), new Point(85, 130), new Point(110, 160), new Point(85, 175), new Point(75, 165),
//					new Point(65, 180), new Point(45, 175)
//				});
//			//shorts end
//
//			//shirt
//			gThin.FillPolygon(
//				new SolidBrush(Color.DarkCyan),
//				new Point[]
//				{
//					new Point(59, 68), new Point(48, 82), new Point(59, 95), new Point(66, 85), new Point(62, 116), new Point(86, 116),
//					new Point(85, 84), new Point(97, 94), new Point(100, 71), new Point(85, 65), new Point(60, 66)
//				});
//
//
//			//shirt end
//
//			//shoes
//			gThin.FillPolygon(
//				new SolidBrush(Color.GreenYellow),
//				new Point[]
//				{
//					new Point(34, 215), new Point(29, 221), new Point(56, 226), new Point(48, 218)
//				});
//
//			gThin.FillPolygon(
//				new SolidBrush(Color.GreenYellow),
//				new Point[]
//				{
//					new Point(118, 206), new Point(123, 213), new Point(147, 189), new Point(131, 196)
//				});
//			//			//shoes end
//
//			#endregion

//			#region 正装装扮
//
//			//shoes
			gThin.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(34, 215), new Point(29, 221), new Point(56, 226), new Point(48, 218)
				});

			gThin.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(118, 206), new Point(123, 213), new Point(147, 189), new Point(131, 196)
				});
//			//shoes end
//
//			//pants
			gThin.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(61, 138), new Point(39, 204), new Point(55, 208), new Point(76, 154), new Point(109, 195),
					new Point(120, 184), new Point(85, 140), new Point(62, 139)
				});


//			//pants end
//
//			//jacket
			gThin.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(63, 70), new Point(27, 104), new Point(37, 111), new Point(63, 84), new Point(63, 135),
					new Point(83, 135), new Point(83, 81), new Point(126, 98), new Point(131, 86), new Point(83, 68)
				});
//			//jacket end
//
//			//tie
			gThin.FillPolygon(
				new SolidBrush(Color.IndianRed),
				new Point[]
				{
					new Point(71, 73), new Point(67, 118), new Point(71, 130), new Point(75, 116), new Point(73, 72)
				});

//			//tie end
//
//			#endregion

			#region 其他服饰

			//vest 
//			gThin.FillPolygon(
//				new SolidBrush(Color.DarkCyan),
//				new Point[]
//				{
//					new Point(70, 70), new Point(74, 84), new Point(81, 64), new Point(84, 84), new Point(89, 86), new Point(87, 118),
//					new Point(56, 118), new Point(57, 91), new Point(64, 86), new Point(65, 71)
//				});

			#endregion
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