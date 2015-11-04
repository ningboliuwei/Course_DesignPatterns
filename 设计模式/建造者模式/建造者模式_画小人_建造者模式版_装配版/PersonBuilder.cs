using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using 建造者模式_画小人_建造者模式版;

namespace 建造者模式_画小人_建造者模式_装配版
{
    abstract class PersonBuilder
    {
        protected Graphics _g;

        protected Person _person = new Person();

        public PersonBuilder(Graphics g)
        {
            _g = g;
        }

        public abstract void BuildHead();

        public abstract void BuildBody();

        public abstract void BuildLeftArm();

        public abstract void BuildRightArm();

        public abstract void BuildLeftLeg();

        public abstract void BuildRightLeg();

        public Person GetPerson()
        {
            return _person;
        }
    }
}