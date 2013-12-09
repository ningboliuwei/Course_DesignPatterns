using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 策略模式_电影票折扣
{
	class MovieTicket
	{
		private Discount m_discount;
		public void SetDiscount(Discount discount)
		{
			m_discount = discount;
		}

		public void GetPrice()
		{
			m_discount.Caculate();
		}
	}
}
