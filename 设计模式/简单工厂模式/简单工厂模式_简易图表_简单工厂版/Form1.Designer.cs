namespace 简单工厂模式_简易图表_简单工厂版
{
	partial class Form1
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.cmbChartType = new System.Windows.Forms.ComboBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmbChartType
			// 
			this.cmbChartType.FormattingEnabled = true;
			this.cmbChartType.Items.AddRange(new object[] {
            "LINE",
            "BAR",
            "PIE"});
			this.cmbChartType.Location = new System.Drawing.Point(651, 12);
			this.cmbChartType.Name = "cmbChartType";
			this.cmbChartType.Size = new System.Drawing.Size(121, 23);
			this.cmbChartType.TabIndex = 0;
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(651, 42);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(121, 22);
			this.txtData.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 745);
			this.Controls.Add(this.txtData);
			this.Controls.Add(this.cmbChartType);
			this.Name = "Form1";
			this.Text = "简易图表";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Click += new System.EventHandler(this.Form1_Click);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbChartType;
		private System.Windows.Forms.TextBox txtData;
	}
}

