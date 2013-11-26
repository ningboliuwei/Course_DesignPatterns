using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_姚明
{
	internal class ForeignCenter
	{
		private string _name;

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public void JinGong()
		{
			Console.Write("外籍中锋{0}进攻", _name);
		}

		public void FangShou()
		{
			Console.Write("外籍中锋{0}防守", _name);
		}
	}
}