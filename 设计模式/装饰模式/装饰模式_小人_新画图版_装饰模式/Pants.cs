using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰模式_小人_新画图版_装饰模式
{
	class Pants : Wear
	{
		public Pants(Graphics g) : base(g)
		{
		}

		public override void Show()
		{
			base.Show();
			AddPants();
		}

		public void AddPants()
		{
			//pants
			_g.FillPolygon(
				new SolidBrush(Color.Black),
				new Point[]
				{
					new Point(61, 138), new Point(39, 204), new Point(55, 208), new Point(76, 154), new Point(109, 195),
					new Point(120, 184), new Point(85, 140), new Point(62, 139)
				});


			//pants end
		}
	}
}