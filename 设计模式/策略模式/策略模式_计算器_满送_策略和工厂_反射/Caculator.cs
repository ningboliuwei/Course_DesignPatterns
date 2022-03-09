﻿#region

using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

#endregion

namespace 策略模式_计算器_满送_策略和工厂_反射 {
    public partial class Caculator : Form {
        private DataSet ds; //用于存放配置文件信息

        private double total; //用于总计

        public Caculator() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            //根据用户的选项，查询用户选择项的相关行    
            var dr = ds.Tables[0].Select("name='" + cbxType.SelectedItem + "'")[0];
            //声明一个参数的对象数组   
            object[] args = null; //若有参数，则将其分割成字符串数组，用于实例化时所用的参数   
            if (dr["para"].ToString() != "") {
                args = dr["para"].ToString().Split(',');
            }

            //通过反射实例化出相应的算法对象    
            var cashSuper =
                Assembly.Load("策略模式_计算器_满送_策略和工厂_反射")
                    .CreateInstance(
                        "策略模式_计算器_满送_策略和工厂_反射." + dr["class"],
                        false,
                        BindingFlags.Default,
                        null,
                        args,
                        null,
                        null) as CashSuper;
            var cc = new CashContext(cashSuper);

            var totalPrices = 0d;
            totalPrices = cc.GetResult(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text));
            total = total + totalPrices;
            lbxList.Items.Add(
                "单价：" + txtPrice.Text + " 数量：" + txtNum.Text + " " + cbxType.SelectedItem + " 合计：" + totalPrices);
            lblResult.Text = total.ToString();
        }

        private void Caculator_Load(object sender, EventArgs e) {
            //读配置文件    
            ds = new DataSet();
            //ds.ReadXml(Application.StartupPath + "\\CashAcceptType.xml");
            ds.ReadXml("r:\\CashAcceptType.xml");
            //将读取到的记录绑定到下拉列表框中    
            foreach (DataRowView dr in ds.Tables[0].DefaultView) {
                cbxType.Items.Add(dr["name"].ToString());
            }

            cbxType.SelectedIndex = 0;
        }
    }
}