using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 建造者模式_画小人_建造者模式版
{
    class Person
    {
        protected List<Part> _parts = new List<Part>();

        public void AddPart(Part part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            foreach (Part part in _parts)
            {
                part.Show();
            }
        }
    }
}