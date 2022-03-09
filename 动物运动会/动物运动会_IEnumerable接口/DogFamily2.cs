#region

using System.Collections.Generic;

#endregion

namespace 动物运动会_泛型 {
    public class DogFamily2 : Family2 {
        private readonly List<Cat> _cats = new();
        public string FamilyName { get; set; }

        public void Add(Cat cat)
        {
            _cats.Add(cat);
        }

        public void Remove(Cat cat)
        {
            _cats.Remove(cat);
        }
    }
}