using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 策略模式_计算器_无打折_非策略
{
	public partial class Caculator : Form
	{
		private double total = 0.0;

		public Caculator()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			double totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
			total += totalPrices;
			lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " 合计：" + totalPrices.ToString());
			lblResult.Text = total.ToString();
		}
	}
}