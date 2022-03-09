#region

using System;

#endregion

namespace 适配器模式_姚明 {
    internal class ForeignCenter {
        public string Name { get; set; }

        public void FangShou() {
            Console.Write("外籍中锋{0}防守", Name);
        }

        public void JinGong() {
            Console.Write("外籍中锋{0}进攻", Name);
        }
    }
}