using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式_遥控汽车
{
	internal class CarSeperateInvoker
	{
		private CarSeperateCommand _start;

		private CarSeperateCommand _moveforwards;

		private CarSeperateCommand _movebackwards;

		private CarSeperateCommand _stop;

		private CarSeperateCommand _undo;

		public CarSeperateInvoker(
			CarSeperateCommand start,
			CarSeperateCommand moveforwards,
			CarSeperateCommand movebackwards,
			CarSeperateCommand stop,
			CarSeperateCommand undo)
		{
			this._start = start;
			this._moveforwards = moveforwards;
			this._movebackwards = movebackwards;
			this._stop = stop;
			this._undo = undo;
		}

		public void Start()
		{
			_start.Excute();
		}

		public void MoveForwards()
		{
			_moveforwards.Excute();
		}

		public void MoveBackwards()
		{
			_movebackwards.Excute();
		}

		public void Stop()
		{
			_stop.Excute();
		}

		public void Undo()
		{
			_undo.Excute();
		}
	}
}