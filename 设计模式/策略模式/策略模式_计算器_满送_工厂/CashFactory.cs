using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式_计算器_满送_工厂
{
	internal class CashFactory
	{
		public static CashSuper CreateCashAccept(string type)
		{
			CashSuper cs = null;

			switch (type)
			{
				case "正常收费":
					cs = new CashNormal();
					break;
				case "满300返100":
					CashReturn cr1 = new CashReturn("300", "100");
					cs = cr1;
					break;
				case "打八折":
					CashDiscount cr2 = new CashDiscount("0.8");
					cs = cr2;
					break;
			}
			return cs;
		}
	}
}