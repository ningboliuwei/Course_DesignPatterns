﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	internal class CarCombineCommandAll : CarCombineCommand
	{
		private Car _car;

		public CarCombineCommandAll(Car mycar)
		{
			this._car = mycar;
		}

		public override void Start()
		{
			_car.Start();
		}

		public override void MoveForwards()
		{
			_car.MoveForwards();
		}

		public override void MoveBackwards()
		{
			_car.MoveBackwards();
		}

		public override void Stop()
		{
			_car.Stop();
		}
	}
}