using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	public class Car
	{
		public string _curStateStr;

		public Car()
		{
			_curStateStr = "";
		}

		public void Start()
		{
			Console.WriteLine("车子起动");
		}

		public void MoveForwards()
		{
			Console.WriteLine("车子前进");
		}

		public void MoveBackwards()
		{
			Console.WriteLine("车子倒退");
		}

		public void Stop()
		{
			Console.WriteLine("车子停止");
		}
	}
}