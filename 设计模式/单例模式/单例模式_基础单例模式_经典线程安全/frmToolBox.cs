using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 单例模式_基础单例模式_经典线程安全
{
	public partial class frmToolBox : Form
	{
		private static frmToolBox ftb;

		private frmToolBox()
		{
			InitializeComponent();
		}

		public static frmToolBox GetInstance()
		{
			if (ftb == null || ftb.IsDisposed)
			{
				lock (typeof (frmToolBox))
				{
					if (ftb == null || ftb.IsDisposed)
					{
						ftb = new frmToolBox();
						ftb.TopLevel = false;
						ftb.Parent = ActiveForm;
					}
				}
			}
			return ftb;
		}
	}
}