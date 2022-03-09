#region

using System.Collections.Generic;

#endregion

namespace 组合模式_形状 {
    internal class TriangleMatrix : Shape {
        public List<Shape> ShapeList { get; set; } = new List<Shape>();

        public void AddShape(Shape shape) {
            ShapeList.Add(shape);
        }

        public override void Draw() {
            foreach (var shape in ShapeList) {
                shape.Draw();
            }
        }
    }
}