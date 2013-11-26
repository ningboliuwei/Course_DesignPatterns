using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	internal class UnDoCommand : CarSeperateCommand
	{
		private Car _car;

		private ArrayList CarState;

		public UnDoCommand(Car car, ArrayList state)
			: base(car)
		{
			this._car = car;
			CarState = state;
		}

		public override void Excute()
		{
			int count = CarState.Count;

			if (count < 1)
			{
				Console.WriteLine("无法再回退操作!");
			}
			if (count == 1)
			{
				_car._curStateStr = (string)CarState[0];
				CarState.Clear();
			}

			if (count > 1)
			{
				_car._curStateStr = (string)CarState[count - 2];
				CarState.RemoveAt(count - 1);
			}
		}
	}
}