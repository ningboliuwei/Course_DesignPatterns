using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 命令模式_自定义功能键_传统版
{
	class FunctionButton
	{
		//第一步开始——显示帮助文档
		private HelpHandler helpHandler;

		public void Click()
		{
			helpHandler = new HelpHandler();
			helpHandler.Display();
		}
		////第一步结束

		//第二步开始——最小化当前窗口
		//private MinimizeHandler minimizeHandler;

		//public void Click()
		//{
		//	minimizeHandler = new MinimizeHandler();
		//	minimizeHandler.Minimize();
		//}
		//第二步结束

		//第三步开始——截取当前屏幕
		//private ScreenShotHandler screenShotHandler;

		//public void Click()
		//{
		//	screenShotHandler = new ScreenShotHandler();
		//	screenShotHandler.Shot();
		//}
		//第三步结束


	}
}
