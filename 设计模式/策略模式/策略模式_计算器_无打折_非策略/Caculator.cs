#region

using System;
using System.Windows.Forms;

#endregion

namespace 策略模式_计算器_无打折_非策略 {
    public partial class Caculator : Form {
        private double total;

        public Caculator() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var totalPrices = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
            total += totalPrices;
            lbxList.Items.Add("单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " 合计：" + totalPrices);
            lblResult.Text = total.ToString();
        }
    }
}