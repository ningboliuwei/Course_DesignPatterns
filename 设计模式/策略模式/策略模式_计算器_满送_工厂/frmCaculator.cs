#region

using System;
using System.Windows.Forms;

#endregion

namespace 策略模式_计算器_满送_工厂 {
    public partial class frmCaculator : Form {
        private double total;

        public frmCaculator() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            double totalPrices = 0;
            var factory = CaculatorFactory.CreateCaculator(cbxType.SelectedItem.ToString());

            totalPrices = factory.CaculatePrice(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total += totalPrices;
            lbxList.Items.Add(
                "单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " " + cbxType.SelectedItem + " 合计：" + totalPrices);
            lblResult.Text = total.ToString();
        }

        private void Caculator_Load(object sender, EventArgs e) {
            cbxType.Items.AddRange(new object[] { "正常收费", "打八折", "满300返100" });
            cbxType.SelectedIndex = 0;
        }
    }
}