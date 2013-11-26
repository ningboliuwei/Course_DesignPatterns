using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 适配器模式_日志
{
	internal class LogHelperAdapter : LogHelper //为了适应接口的变化新建的适配器类
	{
		private NewLogHelper _helper = new NewLogHelper();

		public override void Write(string s)
		{
			_helper.WriteLog(s);
		}
	}
}