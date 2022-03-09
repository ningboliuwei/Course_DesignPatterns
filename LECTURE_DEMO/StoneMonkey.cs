#region

using System;

#endregion

namespace LECTURE_DEMO {
    internal class StoneMonkey : Monkey, IChange {
        public StoneMonkey(string name) : base(name) {
        }

        public void Change() {
            Console.WriteLine("我能七十二变");
        }

        public void Method1() {
            throw new NotImplementedException();
        }
    }
}