namespace 策略模式_计算器_满送_策略和工厂_反射
{
	partial class Caculator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbxType = new System.Windows.Forms.ComboBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbxList = new System.Windows.Forms.ListBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbxType
			// 
			this.cbxType.FormattingEnabled = true;
			this.cbxType.Location = new System.Drawing.Point(117, 109);
			this.cbxType.Name = "cbxType";
			this.cbxType.Size = new System.Drawing.Size(121, 20);
			this.cbxType.TabIndex = 38;
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblResult.Location = new System.Drawing.Point(82, 326);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(191, 51);
			this.lblResult.TabIndex = 36;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(47, 326);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 37;
			this.label3.Text = "总计";
			// 
			// lbxList
			// 
			this.lbxList.FormattingEnabled = true;
			this.lbxList.ItemHeight = 12;
			this.lbxList.Location = new System.Drawing.Point(46, 139);
			this.lbxList.Name = "lbxList";
			this.lbxList.Size = new System.Drawing.Size(236, 184);
			this.lbxList.TabIndex = 35;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(200, 71);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 34;
			this.btnReset.Text = "重置";
			this.btnReset.UseVisualStyleBackColor = true;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(200, 34);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 33;
			this.btnOK.Text = "确定";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(93, 73);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(100, 21);
			this.txtNum.TabIndex = 32;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(93, 36);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(100, 21);
			this.txtPrice.TabIndex = 31;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(46, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 29;
			this.label4.Text = "计算方式：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 30;
			this.label2.Text = "数量：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 28;
			this.label1.Text = "单价：";
			// 
			// Caculator_IV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 410);
			this.Controls.Add(this.cbxType);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lbxList);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Caculator_IV";
			this.Text = "Caculator_IV";
			this.Load += new System.EventHandler(this.Caculator_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbxType;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox lbxList;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}