#region

using System.Drawing;

#endregion

namespace 工厂方法模式_简易图表_工厂方法版 {
    internal abstract class Chart {
        protected int[] _data;
        protected Graphics _g;

        protected Pen _p;

        public Chart(Graphics g, Pen p) {
            _g = g;
            _p = p;
            //X230 添加
            //OFFICE 添加
        }

        public int[] Data {
            get => _data;
            set => _data = value;
        }

        public virtual void Display() {
        }
    }
}