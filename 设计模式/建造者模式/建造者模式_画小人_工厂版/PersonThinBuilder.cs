using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 建造者模式_画小人_工厂版
{
	using System.Data.SqlClient;

	internal class PersonThinBuilder
	{
		private Graphics _g;

		private Pen _p;

		public PersonThinBuilder(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
		}

		public void Build()
		{
			_g.DrawEllipse(_p, 50, 20, 30, 30); //head
			_g.DrawRectangle(_p, 60, 50, 10, 50); //body
			_g.DrawLine(_p, 60, 50, 40, 100); //left arm
			_g.DrawLine(_p, 70, 50, 90, 100); //ri_ght arm
			_g.DrawLine(_p, 60, 100, 45, 150); //left le_g
			_g.DrawLine(_p, 70, 100, 85, 150); //ri_ght le_g
		}
	}
}