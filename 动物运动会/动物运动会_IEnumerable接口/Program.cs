#region

using System.Collections.Generic;

#endregion

namespace 动物运动会_泛型 {
    internal class Program {
        private static void Main(string[] args) {
            var dogFamily = new Family<Dog>();
            dogFamily.Add(new Dog("旺财"));
            dogFamily.Add(new Dog("小白"));
        }
    }
}