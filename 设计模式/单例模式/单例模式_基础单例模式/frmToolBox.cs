#region

using System.Windows.Forms;

#endregion

namespace 单例模式_基础单例模式 {
    public partial class frmToolBox : Form {
        private static frmToolBox ftb;

        private frmToolBox() {
            InitializeComponent();
        }

        public static frmToolBox GetInstance() {
            if (ftb == null || ftb.IsDisposed) {
                ftb = new frmToolBox();
                ftb.TopLevel = false;
                ftb.Parent = ActiveForm;
            }

            return ftb;
        }
    }
}