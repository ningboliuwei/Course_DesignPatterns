namespace 动物运动会
{
	partial class Form5
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
			this.btnShout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShout
			// 
			this.btnShout.Location = new System.Drawing.Point(106, 199);
			this.btnShout.Name = "btnShout";
			this.btnShout.Size = new System.Drawing.Size(75, 23);
			this.btnShout.TabIndex = 3;
			this.btnShout.Text = "叫";
			this.btnShout.UseVisualStyleBackColor = true;
			this.btnShout.Click += new System.EventHandler(this.btnShout_Click);
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.btnShout);
			this.Name = "Form5";
			this.Text = "Form5";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnShout;
	}
}