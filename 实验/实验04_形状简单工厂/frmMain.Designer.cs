namespace 实验04_形状简单工厂
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbShape = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.pictureBoxShape = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShape)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbShape
            // 
            this.cmbShape.FormattingEnabled = true;
            this.cmbShape.Location = new System.Drawing.Point(23, 31);
            this.cmbShape.Margin = new System.Windows.Forms.Padding(4);
            this.cmbShape.Name = "cmbShape";
            this.cmbShape.Size = new System.Drawing.Size(160, 25);
            this.cmbShape.TabIndex = 0;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(227, 31);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(150, 25);
            this.cmbColor.TabIndex = 1;
            // 
            // pictureBoxShape
            // 
            this.pictureBoxShape.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShape.Location = new System.Drawing.Point(12, 76);
            this.pictureBoxShape.Name = "pictureBoxShape";
            this.pictureBoxShape.Size = new System.Drawing.Size(427, 194);
            this.pictureBoxShape.TabIndex = 2;
            this.pictureBoxShape.TabStop = false;
            this.pictureBoxShape.Click += new System.EventHandler(this.pictureBoxShape_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 282);
            this.Controls.Add(this.pictureBoxShape);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbShape);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "ShapeFactory";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbShape;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.PictureBox pictureBoxShape;
    }
}

