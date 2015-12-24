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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ShowDataInForm1();
		}

		private void ShowDataInForm1()
		{
			string filePath = $"{Application.StartupPath}\\data.txt";

			try
			{
				label1.Text = File.ReadAllText(filePath);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		private void ShowDataInForm3()
		{
			Form3 frm = new Form3(label1.Text);
			frm.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			frm.DataChanged += ShowDataInForm1;
			frm.DataChanged += ShowDataInForm3;
			frm.ShowDialog();
		}


	}
}