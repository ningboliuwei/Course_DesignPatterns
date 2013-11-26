namespace 工厂方法模式_简易图表_工厂方法版
{
	using System;
	using System.Drawing;
	using System.Reflection;
	using System.Windows.Forms;

	public partial class Form1 : Form
	{
		#region Constructors and Destructors

		public Form1()
		{
			this.InitializeComponent();
		}

		#endregion

		#region Methods

		private void Form1_Click(object sender, EventArgs e)
		{
			//string AssemblyName = "工厂方法模式_简易图表_工厂方法版";//直接指定当前程序集名称
			string AssemblyName = Assembly.GetExecutingAssembly().GetName().Name; //得到当前程序集名称

			Graphics g = this.CreateGraphics();
			var p = new Pen(Color.Maroon);

			g.Clear(Color.LightBlue);

			IChartFactory chartFactory = null;

			//利用swich语句，选择要创建的工厂类对象
			//switch (this.comboBox1.Text)
			//{
			//	case "Pie":
			//		chartFactory = new PieChartFactory();
			//		break;
			//	case "Bar":
			//		chartFactory = new BarChartFactory();
			//		break;
			//	case "Line":
			//		chartFactory = new LineChartFactory();
			//		break;
			//}

			string className = AssemblyName + "." + comboBox1.Text + "ChartFactory"; //组装出需要的工厂类的类名
			chartFactory = (IChartFactory)Assembly.Load(AssemblyName).CreateInstance(className); //利用反射，创建指定类名的实例

			Chart chart = chartFactory.Create(g, p);

			//chart.Data = new int[]{100,400,300,500,200};
			//chart.Data = new int[] { 300, 200, 400, 500, 100 };
			string[] content = this.textBox1.Text.Split(',');

			chart.Data = new int[content.Length]; //创建需要的长度的int数组

			for (int i = 0; i < content.Length; i++)
			{
				chart.Data[i] = Convert.ToInt32(content[i]);
			} //将字符串数组中各字符串转换为整型

			chart.Display();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		#endregion
	}
}