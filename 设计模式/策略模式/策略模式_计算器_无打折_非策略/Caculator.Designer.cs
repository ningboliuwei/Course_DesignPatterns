namespace 策略模式_计算器_无打折_非策略
{
	partial class Caculator
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lbxList = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "单价：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 1;
			this.label2.Text = "数量：";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(59, 6);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 21);
			this.txtPrice.TabIndex = 2;
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(59, 43);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(100, 21);
			this.txtNum.TabIndex = 3;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(166, 4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "确定";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(166, 41);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// lbxList
			// 
			this.lbxList.FormattingEnabled = true;
			this.lbxList.ItemHeight = 12;
			this.lbxList.Location = new System.Drawing.Point(12, 70);
			this.lbxList.Name = "lbxList";
			this.lbxList.Size = new System.Drawing.Size(236, 184);
			this.lbxList.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 261);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "总计";
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblResult.Location = new System.Drawing.Point(48, 257);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(191, 51);
			this.lblResult.TabIndex = 6;
			// 
			// Caculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(260, 321);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbxList);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Caculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ListBox lbxList;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblResult;
	}
}

