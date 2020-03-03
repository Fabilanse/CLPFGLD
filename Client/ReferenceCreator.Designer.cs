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
			this.nounTree = new System.Windows.Forms.TreeView();
			this.antecedentTree = new System.Windows.Forms.TreeView();
			this.addButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeLeft
			// 
			this.treeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeLeft.Location = new System.Drawing.Point(12, 5);
			this.treeLeft.Name = "treeLeft";
			this.treeLeft.Size = new System.Drawing.Size(1496, 241);
			this.treeLeft.TabIndex = 0;
			// 
			// treeRight
			// 
			this.treeRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeRight.Location = new System.Drawing.Point(12, 252);
			this.treeRight.Name = "treeRight";
			this.treeRight.Size = new System.Drawing.Size(1496, 245);
			this.treeRight.TabIndex = 1;
			// 
			// treeViewMain
			// 
			this.treeViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.treeViewMain.Location = new System.Drawing.Point(12, 503);
			this.treeViewMain.Name = "treeViewMain";
			this.treeViewMain.Size = new System.Drawing.Size(411, 152);
			this.treeViewMain.TabIndex = 2;
			// 
			// treeViewLeft
			// 
			this.nounTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nounTree.Location = new System.Drawing.Point(429, 503);
			this.nounTree.Name = "treeViewLeft";
			this.nounTree.Size = new System.Drawing.Size(539, 152);
			this.nounTree.TabIndex = 3;
			// 
			// treeViewRight
			// 
			this.antecedentTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.antecedentTree.Location = new System.Drawing.Point(974, 503);
			this.antecedentTree.Name = "treeViewRight";
			this.antecedentTree.Size = new System.Drawing.Size(534, 152);
			this.antecedentTree.TabIndex = 4;
			// 
			// addButton
			// 
			this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.addButton.Location = new System.Drawing.Point(429, 656);
			this.addButton.Name = "addButton";
			this.addButton.Size = new System.Drawing.Size(1079, 23);
			this.addButton.TabIndex = 5;
			this.addButton.Text = "Добавить";
			this.addButton.UseVisualStyleBackColor = true;
			this.addButton.Click += new System.EventHandler(this.addButton_Click);
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(12, 656);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(306, 23);
			this.saveButton.TabIndex = 6;
			this.saveButton.Text = "Сохранить";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(324, 656);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(99, 23);
			this.openButton.TabIndex = 7;
			this.openButton.Text = "Открыть";
			this.openButton.UseVisualStyleBackColor = true;
			// 
			// ReferenceCreator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1515, 680);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.addButton);
			this.Controls.Add(this.antecedentTree);
			this.Controls.Add(this.nounTree);
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
		private System.Windows.Forms.TreeView nounTree;
		private System.Windows.Forms.TreeView antecedentTree;
		private System.Windows.Forms.Button addButton;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button openButton;
	}
}