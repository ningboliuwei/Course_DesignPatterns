using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 策略模式_计算器_打折_非策略
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
			double totalPrices = 0;

			switch (cbxType.SelectedIndex)
			{
				case 0:
					totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
					break;
				case 1:
					totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.8;
					break;
				case 2:
					totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.7;
					break;
				case 3:
					totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text) * 0.5;
					break;
			}
			total += totalPrices;
			lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " 合计：" + totalPrices.ToString());
			lblResult.Text = total.ToString();
		}

		private void Caculator_Load(object sender, EventArgs e)
		{
			cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "打七折", "打五折" });
			cbxType.SelectedIndex = 0;
		}
	}
}