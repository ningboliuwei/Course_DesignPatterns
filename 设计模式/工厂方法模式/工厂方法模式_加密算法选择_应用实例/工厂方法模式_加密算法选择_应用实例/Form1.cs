#region

using System;
using System.Security.Cryptography;
using System.Windows.Forms;

#endregion

namespace 工厂方法模式_加密算法选择_应用实例 {
    public partial class Form1 : Form {
        #region Constructors and Destructors

        public Form1() {
            InitializeComponent();
        }

        #endregion

        #region Methods

        private void Form1_Click(object sender, EventArgs e) {
            var sa = SymmetricAlgorithm.Create();
            var aa = AsymmetricAlgorithm.Create();
            var ha = HashAlgorithm.Create();
        }

        #endregion
    }
}