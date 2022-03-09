#region

using System;

#endregion

namespace 策略模式_电影票折扣 {
    internal class VIPDiscount : Discount {
        public override void Caculate() {
            Console.WriteLine("原价打5折！并增加积分！");
        }
    }
}