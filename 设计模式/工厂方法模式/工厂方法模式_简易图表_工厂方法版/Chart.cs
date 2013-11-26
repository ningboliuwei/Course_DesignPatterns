using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式_简易图表_工厂方法版
{
	using System.Drawing;

	internal abstract class Chart
	{
		protected Graphics _g;

		protected Pen _p;

		protected int[] _data;

		public Chart(Graphics g, Pen p)
		{
			_g = g;
			_p = p;
			//X230 添加
			//OFFICE 添加
		}

		public int[] Data
		{
			get
			{
				return _data;
			}
			set
			{
				_data = value;
			}
		}

		public virtual void Display()
		{
		}
	}
}