#region

using System;

#endregion

namespace LECTURE_DEMO {
    internal class MachineCat : Cat {
        public MachineCat(string name) : base(name) {
        }

        public void Change() {
            Console.WriteLine("我有魔法口袋");
        }
    }
}