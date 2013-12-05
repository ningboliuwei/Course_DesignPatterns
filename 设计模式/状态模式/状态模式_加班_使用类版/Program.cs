using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_使用类版
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//紧急项目
			Work emergencyProjects = new Work();
			emergencyProjects.MHour = 9;
			emergencyProjects.WriteProgram();

			emergencyProjects.MHour = 10;
			emergencyProjects.WriteProgram();

			emergencyProjects.MHour = 12;
			emergencyProjects.WriteProgram();

			emergencyProjects.MHour = 13;
			emergencyProjects.WriteProgram();

			emergencyProjects.MHour = 14;
			emergencyProjects.WriteProgram();

			emergencyProjects.MHour = 17;

			//第一步开始
			//emergencyProjects.TaskFinished = true;
			//第一步结束

			//第二步开始
			emergencyProjects.TaskFinished = false;
			//第二步结束

			emergencyProjects.WriteProgram();
			emergencyProjects.MHour = 19;
			emergencyProjects.WriteProgram();
			emergencyProjects.MHour = 22;
			emergencyProjects.WriteProgram();

			Console.Read();
		}
	}
}