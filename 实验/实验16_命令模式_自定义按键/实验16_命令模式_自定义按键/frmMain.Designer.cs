namespace 实验16_命令模式_自定义按键
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnFunction1 = new 实验16_命令模式_自定义按键.FunctionButton();
            this.btnFunction2 = new 实验16_命令模式_自定义按键.FunctionButton();
            this.btnFunction3 = new 实验16_命令模式_自定义按键.FunctionButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoScreenShot1 = new System.Windows.Forms.RadioButton();
            this.rdoMinimize1 = new System.Windows.Forms.RadioButton();
            this.rdoHelp1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoScreenShot2 = new System.Windows.Forms.RadioButton();
            this.rdoMinimize2 = new System.Windows.Forms.RadioButton();
            this.rdoHelp2 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoScreenShot3 = new System.Windows.Forms.RadioButton();
            this.rdoMinimize3 = new System.Windows.Forms.RadioButton();
            this.rdoHelp3 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFunction1
            // 
            this.btnFunction1.Location = new System.Drawing.Point(15, 28);
            this.btnFunction1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFunction1.Name = "btnFunction1";
            this.btnFunction1.Size = new System.Drawing.Size(117, 58);
            this.btnFunction1.TabIndex = 0;
            this.btnFunction1.Text = "功能键1";
            this.btnFunction1.UseVisualStyleBackColor = true;
            // 
            // btnFunction2
            // 
            this.btnFunction2.Location = new System.Drawing.Point(15, 111);
            this.btnFunction2.Margin = new System.Windows.Forms.Padding(4);
            this.btnFunction2.Name = "btnFunction2";
            this.btnFunction2.Size = new System.Drawing.Size(117, 58);
            this.btnFunction2.TabIndex = 4;
            this.btnFunction2.Text = "功能键2";
            this.btnFunction2.UseVisualStyleBackColor = true;
            // 
            // btnFunction3
            // 
            this.btnFunction3.Location = new System.Drawing.Point(15, 194);
            this.btnFunction3.Margin = new System.Windows.Forms.Padding(4);
            this.btnFunction3.Name = "btnFunction3";
            this.btnFunction3.Size = new System.Drawing.Size(117, 58);
            this.btnFunction3.TabIndex = 8;
            this.btnFunction3.Text = "功能键3";
            this.btnFunction3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoScreenShot1);
            this.groupBox1.Controls.Add(this.rdoMinimize1);
            this.groupBox1.Controls.Add(this.rdoHelp1);
            this.groupBox1.Location = new System.Drawing.Point(156, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(401, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rdoScreenShot1
            // 
            this.rdoScreenShot1.AutoSize = true;
            this.rdoScreenShot1.Location = new System.Drawing.Point(275, 30);
            this.rdoScreenShot1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoScreenShot1.Name = "rdoScreenShot1";
            this.rdoScreenShot1.Size = new System.Drawing.Size(61, 25);
            this.rdoScreenShot1.TabIndex = 6;
            this.rdoScreenShot1.Text = "截屏";
            this.rdoScreenShot1.UseVisualStyleBackColor = true;
            this.rdoScreenShot1.CheckedChanged += new System.EventHandler(this.rdoScreenShot1_CheckedChanged);
            // 
            // rdoMinimize1
            // 
            this.rdoMinimize1.AutoSize = true;
            this.rdoMinimize1.Location = new System.Drawing.Point(141, 30);
            this.rdoMinimize1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMinimize1.Name = "rdoMinimize1";
            this.rdoMinimize1.Size = new System.Drawing.Size(106, 25);
            this.rdoMinimize1.TabIndex = 5;
            this.rdoMinimize1.Text = "最大化窗体";
            this.rdoMinimize1.UseVisualStyleBackColor = true;
            this.rdoMinimize1.CheckedChanged += new System.EventHandler(this.rdoMinimize1_CheckedChanged);
            // 
            // rdoHelp1
            // 
            this.rdoHelp1.AutoSize = true;
            this.rdoHelp1.Checked = true;
            this.rdoHelp1.Location = new System.Drawing.Point(8, 30);
            this.rdoHelp1.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHelp1.Name = "rdoHelp1";
            this.rdoHelp1.Size = new System.Drawing.Size(121, 25);
            this.rdoHelp1.TabIndex = 4;
            this.rdoHelp1.TabStop = true;
            this.rdoHelp1.Text = "打开帮助文档";
            this.rdoHelp1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoScreenShot2);
            this.groupBox2.Controls.Add(this.rdoMinimize2);
            this.groupBox2.Controls.Add(this.rdoHelp2);
            this.groupBox2.Location = new System.Drawing.Point(156, 95);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(401, 74);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // rdoScreenShot2
            // 
            this.rdoScreenShot2.AutoSize = true;
            this.rdoScreenShot2.Location = new System.Drawing.Point(275, 32);
            this.rdoScreenShot2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoScreenShot2.Name = "rdoScreenShot2";
            this.rdoScreenShot2.Size = new System.Drawing.Size(61, 25);
            this.rdoScreenShot2.TabIndex = 10;
            this.rdoScreenShot2.Text = "截屏";
            this.rdoScreenShot2.UseVisualStyleBackColor = true;
            this.rdoScreenShot2.CheckedChanged += new System.EventHandler(this.rdoScreenShot2_CheckedChanged);
            // 
            // rdoMinimize2
            // 
            this.rdoMinimize2.AutoSize = true;
            this.rdoMinimize2.Checked = true;
            this.rdoMinimize2.Location = new System.Drawing.Point(141, 32);
            this.rdoMinimize2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMinimize2.Name = "rdoMinimize2";
            this.rdoMinimize2.Size = new System.Drawing.Size(106, 25);
            this.rdoMinimize2.TabIndex = 9;
            this.rdoMinimize2.TabStop = true;
            this.rdoMinimize2.Text = "最大化窗体";
            this.rdoMinimize2.UseVisualStyleBackColor = true;
            this.rdoMinimize2.CheckedChanged += new System.EventHandler(this.rdoMinimize2_CheckedChanged);
            // 
            // rdoHelp2
            // 
            this.rdoHelp2.AutoSize = true;
            this.rdoHelp2.Location = new System.Drawing.Point(8, 32);
            this.rdoHelp2.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHelp2.Name = "rdoHelp2";
            this.rdoHelp2.Size = new System.Drawing.Size(121, 25);
            this.rdoHelp2.TabIndex = 8;
            this.rdoHelp2.Text = "打开帮助文档";
            this.rdoHelp2.UseVisualStyleBackColor = true;
            this.rdoHelp2.CheckedChanged += new System.EventHandler(this.rdoHelp2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoScreenShot3);
            this.groupBox3.Controls.Add(this.rdoMinimize3);
            this.groupBox3.Controls.Add(this.rdoHelp3);
            this.groupBox3.Location = new System.Drawing.Point(156, 178);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(401, 74);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            // 
            // rdoScreenShot3
            // 
            this.rdoScreenShot3.AutoSize = true;
            this.rdoScreenShot3.Checked = true;
            this.rdoScreenShot3.Location = new System.Drawing.Point(275, 30);
            this.rdoScreenShot3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoScreenShot3.Name = "rdoScreenShot3";
            this.rdoScreenShot3.Size = new System.Drawing.Size(61, 25);
            this.rdoScreenShot3.TabIndex = 14;
            this.rdoScreenShot3.TabStop = true;
            this.rdoScreenShot3.Text = "截屏";
            this.rdoScreenShot3.UseVisualStyleBackColor = true;
            this.rdoScreenShot3.CheckedChanged += new System.EventHandler(this.rdoScreenShot3_CheckedChanged);
            // 
            // rdoMinimize3
            // 
            this.rdoMinimize3.AutoSize = true;
            this.rdoMinimize3.Location = new System.Drawing.Point(141, 30);
            this.rdoMinimize3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMinimize3.Name = "rdoMinimize3";
            this.rdoMinimize3.Size = new System.Drawing.Size(106, 25);
            this.rdoMinimize3.TabIndex = 13;
            this.rdoMinimize3.Text = "最大化窗体";
            this.rdoMinimize3.UseVisualStyleBackColor = true;
            this.rdoMinimize3.CheckedChanged += new System.EventHandler(this.rdoMinimize3_CheckedChanged);
            // 
            // rdoHelp3
            // 
            this.rdoHelp3.AutoSize = true;
            this.rdoHelp3.Location = new System.Drawing.Point(8, 30);
            this.rdoHelp3.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHelp3.Name = "rdoHelp3";
            this.rdoHelp3.Size = new System.Drawing.Size(121, 25);
            this.rdoHelp3.TabIndex = 12;
            this.rdoHelp3.Text = "打开帮助文档";
            this.rdoHelp3.UseVisualStyleBackColor = true;
            this.rdoHelp3.CheckedChanged += new System.EventHandler(this.rdoHelp3_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 264);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFunction3);
            this.Controls.Add(this.btnFunction2);
            this.Controls.Add(this.btnFunction1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "控制面板";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FunctionButton btnFunction1;
        private FunctionButton btnFunction2;
        private FunctionButton btnFunction3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoScreenShot1;
        private System.Windows.Forms.RadioButton rdoMinimize1;
        private System.Windows.Forms.RadioButton rdoHelp1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoScreenShot2;
        private System.Windows.Forms.RadioButton rdoMinimize2;
        private System.Windows.Forms.RadioButton rdoHelp2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoScreenShot3;
        private System.Windows.Forms.RadioButton rdoMinimize3;
        private System.Windows.Forms.RadioButton rdoHelp3;
    }
}
