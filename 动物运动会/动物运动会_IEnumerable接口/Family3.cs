#region

using System.Collections.Generic;

#endregion

namespace 动物运动会_泛型 {
    public abstract class Family3 {
        protected List<Animal> _members { get; set; }
        public string FamilyName { get; set; }

        public abstract void Add(Animal member);
        public abstract void Remove(Animal member);
    }
}