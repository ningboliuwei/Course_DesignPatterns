using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 策略模式_计算器_满送_工厂
{
	public partial class Caculator : Form
	{
		private double total = 0;

		public Caculator()
		{
			InitializeComponent();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			CashSuper csuper = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
			double totalPrices = 0;
			totalPrices = csuper.AcceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
			total += totalPrices;
			lbxList.Items.Add(
				"单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " " + cbxType.SelectedItem + " 合计：" + totalPrices.ToString());
			lblResult.Text = total.ToString();
		}

		private void Caculator_Load(object sender, EventArgs e)
		{
			cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "满300返100" });
			cbxType.SelectedIndex = 0;
		}
	}
}