using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式_端口设备_传统版
{
	public class Equipment
	{
		public Equipment()
		{
			Ports = new List<Port>();
		}

		public List<Port> Ports { get; set; }
		public Machine Machine { get; set; }
		public string Name { get; set; }

		public void AddPort(Port port)
		{
			Ports.Add(port);
		}

		public void RemovePort(Port port)
		{
			Ports.Remove(port);
		}

		public void Run()
		{
			Console.WriteLine("The Equipment {0} is running as below...", Name);
			foreach (Port port in Ports)
			{
				port.Transfer();
			}
			Machine.Run();
		}
	}
}