using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 观察者模式_更改数据事件
{
	public partial class Form2 : Form
	{
		public event DataEventHandler DataChanged;

		public delegate void DataEventHandler();


		public Form2()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}


		private void button1_Click(object sender, EventArgs e)
		{
			WriteData(textBox1.Text);
			OnDataChanged();
			Close();
		}

		private void WriteData(string data)
		{
			string filePath = $"{Application.StartupPath}\\data.txt";

			try
			{
				File.WriteAllText(filePath, data);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		protected virtual void OnDataChanged()
		{
			DataChanged?.Invoke();
		}
	}
}