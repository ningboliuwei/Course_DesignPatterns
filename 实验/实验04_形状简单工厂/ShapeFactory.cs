#region

using System;
using System.Drawing;

#endregion

namespace 实验04_形状简单工厂 {
    public class ShapeFactory {
        public static Shape CreateShape(string shapeType, Color color) {
            switch (shapeType.ToLower()) {
                case "圆形":
                    return new Circle(color);
                case "矩形":
                    return new Rectangle(color);
                case "三角形":
                    return new Triangle(color);
                default:
                    throw new ArgumentException("无效的形状");
            }
        }
    }
}