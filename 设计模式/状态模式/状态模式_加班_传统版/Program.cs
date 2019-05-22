using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式_加班_传统版
{
    class Program
    {
        static int Hour = 0;
        static bool WorkFinished = false;

        private static void Main(string[] args) {
            Hour = 9;
            Coding();

            Hour = 10;
            Coding();

            Hour = 12;
            Coding();

            Hour = 13;
            Coding();

            Hour = 14;
            Coding();

            Hour = 17;

            //第一步开始
            //WorkFinished = true;
            //第一步结束

            //第二步开始
            WorkFinished = false;
            //第二步结束

            Coding();
            Hour = 19;
            Coding();
            Hour = 22;
            Coding();

            Console.Read();
        }

        private static void Coding() {
            if (Hour < 12) {
                Console.WriteLine($"当前时间：{Hour}点 上午工作，精神百倍");
            }
            else if (Hour < 13) {
                Console.WriteLine($"当前时间：{Hour}点 饿了，午饭；犯困，午休。");
            }
            else if (Hour < 17) {
                Console.WriteLine($"当前时间：{Hour}点 下午状态还不错，继续努力");
            }
            else {
                if (WorkFinished) {
                    Console.WriteLine($"当前时间：{Hour}点 下班回家了");
                }
                else {
                    if (Hour < 21) {
                        Console.WriteLine($"当前时间：{Hour}点 加班哦，疲累之极");
                    }
                    else {
                        Console.WriteLine($"当前时间：{Hour}点 不行了，睡着了。");
                    }
                }
            }
        }
    }
}