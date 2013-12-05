using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_状态模式_环境类转换版
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Work work = new Work();
            work.Hour = 9;
            work.WriteProgram();

            work.Hour = 10;
            work.WriteProgram();

            work.Hour = 11;
            work.WriteProgram();

            work.Hour = 12;
            work.WriteProgram();

            work.Hour = 13;
            work.WriteProgram();

            work.Hour = 14;
            work.WriteProgram();

            work.Hour = 15;
            work.WriteProgram();

            work.Hour = 16;
            work.WriteProgram();

            work.Hour = 17;
            work.WriteProgram();

            //第一步开始
            work.TaskFinished = true;
            //第一步结束

            //第二步开始
            //w.TaskFinished = false;
            //第二步结束

            work.Hour = 18;
            work.WriteProgram();

            work.Hour = 19;
            work.WriteProgram();

            work.Hour = 20;
            work.WriteProgram();

            work.Hour = 21;
            work.WriteProgram();

            work.Hour = 22;
            work.WriteProgram();

            Console.ReadLine();
        }
    }
}