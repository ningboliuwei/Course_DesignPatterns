#region

using System;

#endregion

namespace 策略模式_电影票折扣 {
    internal class ChildrenDiscount : Discount {
        public override void Caculate() {
            Console.WriteLine("原价减去10元！");
        }
    }
}