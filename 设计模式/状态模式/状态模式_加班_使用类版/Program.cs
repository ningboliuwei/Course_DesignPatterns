using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_使用类版
{
    internal class Program
    {
        private static void Main(string[] args) {
            //紧急项目
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();

            emergencyProjects.Hour = 17;

            //第一步开始
            //emergencyProjects.TaskFinished = true;
            //第一步结束

            //第二步开始
            emergencyProjects.TaskFinished = false;
            //第二步结束

            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();

            Console.Read();
        }
    }
}