using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	public abstract class CarSeperateCommand
	{
		private Car _car;

		public CarSeperateCommand(Car mycar)
		{
			this._car = mycar;
		}

		public abstract void Excute();
	}
}