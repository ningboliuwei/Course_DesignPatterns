#region

using System.Collections.Generic;

#endregion

namespace 动物运动会_泛型 {
    public class Family2 {
        private List<Animal> _members { get; set; }
        public string FamilyName { get; set; }

        public void Add(Animal member) {
            _members.Add(member);
        }

        public void Remove(Animal member) {
            _members.Remove(member);
        }
    }
}