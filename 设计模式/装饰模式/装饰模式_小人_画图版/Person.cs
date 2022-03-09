﻿#region

using System.Drawing;

#endregion

namespace 装饰模式_小人_画图版 {
    internal class Person {
        protected Graphics _g;

        protected Pen _p;

        public Person() {
        }

        public Person(Graphics g, Pen p) {
            _g = g;
            _p = p;
        }

        public virtual void Show() {
        }
    }
}