using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Work w = new Work();
			w.Hour = 9;
			w.WriteProgram();

			w.Hour = 10;
			w.WriteProgram();

			w.Hour = 11;
			w.WriteProgram();

			w.Hour = 12;
			w.WriteProgram();

			w.Hour = 13;
			w.WriteProgram();

			w.Hour = 14;
			w.WriteProgram();

			w.Hour = 15;
			w.WriteProgram();

			w.Hour = 16;
			w.WriteProgram();

			w.Hour = 17;
			w.WriteProgram();

			//w.TaskFinished = true;
			w.TaskFinished = false;

			w.Hour = 18;
			w.WriteProgram();

			w.Hour = 19;
			w.WriteProgram();

			w.Hour = 20;
			w.WriteProgram();

			w.Hour = 21;
			w.WriteProgram();

			w.Hour = 22;
			w.WriteProgram();

			Console.ReadLine();
		}
	}
}