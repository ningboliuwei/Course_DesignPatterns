#region

using System;
using System.Windows.Forms;

#endregion

namespace 实验16_命令模式_自定义按键 {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoHelp2_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoHelp3_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoMinimize1_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoMinimize2_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoMinimize3_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoScreenShot1_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoScreenShot2_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void rdoScreenShot3_CheckedChanged(object sender, EventArgs e) {
            SetCommand();
        }

        private void SetCommand() {
            if (rdoHelp1.Checked) {
                btnFunction1.SetCommand(new HelperCommand());
            }
            else if (rdoMinimize1.Checked) {
                btnFunction1.SetCommand(new MinimizeCommand(this));
            }
            else if (rdoScreenShot1.Checked) {
                btnFunction1.SetCommand(new ScreenShotCommand());
            }

            if (rdoHelp2.Checked) {
                btnFunction2.SetCommand(new HelperCommand());
            }
            else if (rdoMinimize2.Checked) {
                btnFunction2.SetCommand(new MinimizeCommand(this));
            }
            else if (rdoScreenShot2.Checked) {
                btnFunction2.SetCommand(new ScreenShotCommand());
            }

            if (rdoHelp3.Checked) {
                btnFunction3.SetCommand(new HelperCommand());
            }
            else if (rdoMinimize3.Checked) {
                btnFunction3.SetCommand(new MinimizeCommand(this));
            }
            else if (rdoScreenShot3.Checked) {
                btnFunction3.SetCommand(new ScreenShotCommand());
            }
        }
    }
}