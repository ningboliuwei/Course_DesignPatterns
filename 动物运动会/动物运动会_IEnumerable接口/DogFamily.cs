namespace 动物运动会_泛型 {
    public class DogFamily3 : Family {
        public override void Add(Animal member) {
            _members.Add(member);
        }

        public override void Remove(Animal member) {
            _members.Remove(member);
        }
    }
}