using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 简单工厂模式_简易图表_简单工厂版
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}

		private void Form1_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			using (Graphics g = this.CreateGraphics())
			{
				Pen p = new Pen(Color.Maroon);

				g.Clear(Color.LightBlue);

				Chart chart;

				chart = ChartFactory.CreateChart(cmbChartType.Text, g, p);
				//chart.Data = new int[]{100,400,300,500,200};
				//chart.Data = new int[] { 300, 200, 400, 500, 100 };
				//以下代码为用户输入

				string[] content = txtData.Text.Split(',');
				chart.Data = new int[content.Length];
				for (int i = 0; i < content.Length; i++)
				{
					chart.Data[i] = Convert.ToInt32(content[i]);
				}
				chart.Display();
			}
		}
	}
}