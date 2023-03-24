#region

using System;
using System.Drawing;
using System.Windows.Forms;

#endregion

namespace 实验04_形状简单工厂 {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        // 窗体的 Load 事件会在窗体加载时就执行
        private void frmMain_Load(object sender, EventArgs e) {
            // 为形状下拉菜单添加形状选项
            cmbShape.Items.AddRange(new object[] { "圆形", "矩形", "三角形" });
            // 为颜色下拉菜单添加颜色选项
            cmbColor.Items.AddRange(new object[] { "红色", "绿色", "蓝色" });
            // 设置形状下拉菜单选中项为第 1 项（相当于设置默认值）
            cmbShape.SelectedIndex = 0;
            // 设置颜色下拉菜单选中项为第 1 项（相当于设置默认值）
            cmbColor.SelectedIndex = 0;
        }

        private void pictureBoxShape_Click(object sender, EventArgs e)
        {
            var g = pictureBoxShape.CreateGraphics();
            var x = pictureBoxShape.Width / 2 - 25;
            var y = pictureBoxShape.Height / 2 - 25;
            var shapeType = cmbShape.Text;
            var color = Color.Red; //默认红色

            // 根据选择设置颜色
            switch (cmbColor.Text)
            {
                case "红色":
                    color = Color.Red;
                    break;
                case "绿色":
                    color = Color.Green;
                    break;
                case "蓝色":
                    color = Color.Blue;
                    break;
            }

            // 在绘制形状前清空 PictureBox
            g.Clear(pictureBoxShape.BackColor);
            // 根据选项得到形状对象
            var shape = ShapeFactory.CreateShape(shapeType, color);
            // x, y 分别为绘制形状的 “起点” 的 x 与 y 坐标
            shape.Draw(g, x, y);
        }
    }
}