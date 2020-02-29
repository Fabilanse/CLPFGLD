namespace Client
{
	partial class ReferenceCreator
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
			this.treeLeft = new System.Windows.Forms.TreeView();
			this.treeRight = new System.Windows.Forms.TreeView();
			this.treeViewMain = new System.Windows.Forms.TreeView();
			this.treeViewLeft = new System.Windows.Forms.TreeView();
			this.treeViewRight = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeLeft
			// 
			this.treeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeLeft.Location = new System.Drawing.Point(12, 12);
			this.treeLeft.Name = "treeLeft";
			this.treeLeft.Size = new System.Drawing.Size(1496, 268);
			this.treeLeft.TabIndex = 0;
			// 
			// treeRight
			// 
			this.treeRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeRight.Location = new System.Drawing.Point(12, 286);
			this.treeRight.Name = "treeRight";
			this.treeRight.Size = new System.Drawing.Size(1496, 271);
			this.treeRight.TabIndex = 1;
			// 
			// treeViewMain
			// 
			this.treeViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treeViewMain.Location = new System.Drawing.Point(12, 563);
			this.treeViewMain.Name = "treeViewMain";
			this.treeViewMain.Size = new System.Drawing.Size(411, 152);
			this.treeViewMain.TabIndex = 2;
			// 
			// treeViewLeft
			// 
			this.treeViewLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treeViewLeft.Location = new System.Drawing.Point(429, 563);
			this.treeViewLeft.Name = "treeViewLeft";
			this.treeViewLeft.Size = new System.Drawing.Size(534, 152);
			this.treeViewLeft.TabIndex = 3;
			// 
			// treeViewRight
			// 
			this.treeViewRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treeViewRight.Location = new System.Drawing.Point(969, 563);
			this.treeViewRight.Name = "treeViewRight";
			this.treeViewRight.Size = new System.Drawing.Size(534, 152);
			this.treeViewRight.TabIndex = 4;
			// 
			// ReferenceCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1515, 720);
			this.Controls.Add(this.treeViewRight);
			this.Controls.Add(this.treeViewLeft);
			this.Controls.Add(this.treeViewMain);
			this.Controls.Add(this.treeRight);
			this.Controls.Add(this.treeLeft);
			this.Name = "ReferenceCreator";
			this.Text = "ReferenceCreator";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeLeft;
		private System.Windows.Forms.TreeView treeRight;
		private System.Windows.Forms.TreeView treeViewMain;
		private System.Windows.Forms.TreeView treeViewLeft;
		private System.Windows.Forms.TreeView treeViewRight;
	}
}