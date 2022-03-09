#region

using System;

#endregion

namespace LECTURE_DEMO {
    internal class Dog : Animal {
        public Dog(string name) : base(name) {
        }

        public override string GetShoutSound() {
            return "汪~";
        }

        public void SwingTail() {
            Console.WriteLine("摇摇摇尾巴");
        }
    }
}