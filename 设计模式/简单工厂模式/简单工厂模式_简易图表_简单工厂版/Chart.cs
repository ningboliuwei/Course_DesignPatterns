using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式_简易图表_简单工厂版
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
			//X230 再次添加 
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