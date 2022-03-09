#region

using System;

#endregion

namespace 状态模式_加班_状态模式_状态类转换版 {
    internal class Program {
        private static void Main(string[] args) {
            var work = new Work();
            work.Hour = 9;
            work.Coding();

            work.Hour = 10;
            work.Coding();

            work.Hour = 11;
            work.Coding();

            work.Hour = 12;
            work.Coding();

            work.Hour = 13;
            work.Coding();

            work.Hour = 14;
            work.Coding();

            work.Hour = 15;
            work.Coding();

            work.Hour = 16;
            work.Coding();

            work.Hour = 17;
            work.Coding();

            //第一步开始
            work.TaskFinished = true;
            //第一步结束

            //第二步开始
            //w.TaskFinished = false;
            //第二步结束

            work.Hour = 18;
            work.Coding();

            work.Hour = 19;
            work.Coding();

            work.Hour = 20;
            work.Coding();

            work.Hour = 21;
            work.Coding();

            work.Hour = 22;
            work.Coding();

            Console.ReadLine();
        }
    }
}