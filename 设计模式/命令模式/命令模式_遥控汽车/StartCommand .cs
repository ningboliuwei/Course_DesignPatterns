using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	internal class StartCommand : CarSeperateCommand
	{
		private Car _car;

		private ArrayList CarState;

		public StartCommand(Car car, ArrayList state)
			: base(car)
		{
			this._car = car;
			CarState = state;
		}

		public override void Excute()
		{
			_car.Start();
			_car._curStateStr += "-Start";
			CarState.Add(_car._curStateStr);
		}
	}
}