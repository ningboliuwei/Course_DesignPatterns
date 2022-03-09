#region

using System;

#endregion

namespace LECTURE_DEMO {
    internal class Cat : Animal {
        public Cat(string name) : base(name) {
        }

        public void CatchMouse() {
            Console.WriteLine("我抓到老鼠啦！");
        }

        // public override string GetShoutSound() {
        //     return "喵~";
        // }
    }
}