using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 观察者模式_气象站_传统版
{
	internal class Device1
	{
		public void Update(float temperature, float humidity, float pressure)
		{
			Console.WriteLine(
				string.Format("DEVICE1:\n temperature: {0}\n humidity: {1}%\n pressure: {2}\n", temperature, humidity, pressure));
		}
	}
}