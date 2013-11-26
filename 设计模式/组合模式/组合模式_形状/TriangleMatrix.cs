using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 组合模式_形状
{
	internal class TriangleMatrix : Shape
	{
		private List<Shape> m_shapList = new List<Shape>();

		public List<Shape> ShapeList
		{
			get
			{
				return m_shapList;
			}
			set
			{
				m_shapList = value;
			}
		}

		public void AddShape(Shape shape)
		{
			m_shapList.Add(shape);
		}

		public override void Draw()
		{
			foreach (Shape shape in m_shapList)
			{
				shape.Draw();
			}
		}
	}
}