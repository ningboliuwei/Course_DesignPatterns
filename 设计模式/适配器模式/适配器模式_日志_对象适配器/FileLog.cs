﻿using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式_日志_对象适配器
{
	internal class FileLog : LogAdaptee
	{
		public override void WriteLog()
		{
			Console.WriteLine("WriteLog -> File");
		}
	}
}