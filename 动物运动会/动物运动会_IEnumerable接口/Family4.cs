#region

using System.Collections.Generic;

#endregion

namespace 动物运动会_泛型 {
    public class Family4<T> where T : class {
        private List<T> _members { get; set; }
        public string FamilyName { get; set; }

        public void Add(T member) {
            _members.Add(member);
        }

        public void Remove(T member) {
            _members.Remove(member);
        }
    }
}