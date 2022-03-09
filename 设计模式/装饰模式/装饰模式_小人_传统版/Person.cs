#region

using System;

#endregion

namespace 装饰模式_小人_传统版 {
    internal class Person {
        private readonly string m_name;

        public Person(string name) {
            m_name = name;
        }

        public void Show() {
            Console.WriteLine("装扮的{0}", m_name);
        }

        public void WearBigTrouser() {
            Console.Write("垮裤 ");
        }

        public void WearLeatherShoes() {
            Console.Write("皮鞋 ");
        }

        public void WearSneakers() {
            Console.Write("破球鞋 ");
        }

        public void WearSuit() {
            Console.Write("西装 ");
        }

        public void WearTie() {
            Console.Write("领带 ");
        }

        public void WearTShirts() {
            Console.Write("大T恤 ");
        }
    }
}