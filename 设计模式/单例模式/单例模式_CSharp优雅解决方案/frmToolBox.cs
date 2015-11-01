using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式_CSharp优雅解决方案
{
	public partial class frmToolBox : Form
	{
		private static readonly frmToolBox _instance = new frmToolBox();

		private frmToolBox()
		{
			InitializeComponent();
		}

		public static frmToolBox GetInstance()
		{
			return _instance;
		}
	}
}