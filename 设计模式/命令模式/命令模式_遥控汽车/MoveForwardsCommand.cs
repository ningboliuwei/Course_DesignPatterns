using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	internal class MoveForwardsCommand : CarSeperateCommand
	{
		private Car _car;

		private ArrayList CarState;

		public MoveForwardsCommand(Car car, ArrayList state)
			: base(car)
		{
			this._car = car;
			CarState = state;
		}

		public override void Excute()
		{
			_car.MoveForwards();
			_car._curStateStr += "-MoveForwards";
			CarState.Add(_car._curStateStr);
		}
	}
}