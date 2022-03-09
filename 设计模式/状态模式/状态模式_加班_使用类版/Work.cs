#region

using System;

#endregion

namespace 状态模式_加班_使用类版 {
    //工作
    public class Work {
        public int Hour { get; set; }
        public bool TaskFinished { get; set; }

        public void WriteProgram() {
            if (Hour < 12) {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
            }
            else if (Hour < 13) {
                Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休。", Hour);
            }
            else if (Hour < 17) {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", Hour);
            }
            else {
                if (TaskFinished) {
                    Console.WriteLine("当前时间：{0}点 下班回家了", Hour);
                }
                else {
                    if (Hour < 21) {
                        Console.WriteLine("当前时间：{0}点 加班哦，疲累之极", Hour);
                    }
                    else {
                        Console.WriteLine("当前时间：{0}点 不行了，睡着了。", Hour);
                    }
                }
            }
        }
    }
}