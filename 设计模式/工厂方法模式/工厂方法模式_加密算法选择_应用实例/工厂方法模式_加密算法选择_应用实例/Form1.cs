namespace 工厂方法模式_加密算法选择_应用实例
{
	using System;
	using System.Security.Cryptography;
	using System.Windows.Forms;

	public partial class Form1 : Form
	{
		#region Constructors and Destructors

		public Form1()
		{
			this.InitializeComponent();
		}

		#endregion

		#region Methods

		private void Form1_Click(object sender, EventArgs e)
		{
			SymmetricAlgorithm sa = SymmetricAlgorithm.Create();
			AsymmetricAlgorithm aa = AsymmetricAlgorithm.Create();
			HashAlgorithm ha = HashAlgorithm.Create();
		}

		#endregion
	}
}