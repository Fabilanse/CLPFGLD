namespace Client
{
	partial class Form1
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
			this.init = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// init
			// 
			this.init.Location = new System.Drawing.Point(12, 14);
			this.init.Name = "init";
			this.init.Size = new System.Drawing.Size(157, 23);
			this.init.TabIndex = 0;
			this.init.Text = "Загрузить корпус";
			this.init.UseVisualStyleBackColor = true;
			this.init.Click += new System.EventHandler(this.init_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(187, 14);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(267, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Частота местоимений + Частота Лем";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.init);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button init;
		private System.Windows.Forms.Button button1;
	}
}

