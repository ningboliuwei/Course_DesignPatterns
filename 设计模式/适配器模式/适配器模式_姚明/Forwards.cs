#region

using System;

#endregion

namespace 适配器模式_姚明 {
    internal class Forwards : Player {
        public Forwards(string name)
            : base(name) {
        }

        public override void Attack() {
            Console.Write("前锋{0}进攻", _name);
        }

        public override void Defense() {
            Console.Write("前锋{0}防守", _name);
        }
    }
}