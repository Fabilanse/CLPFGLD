namespace Client
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.init = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.forvard = new System.Windows.Forms.Button();
			this.next = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.textBoxSteep = new System.Windows.Forms.TextBox();
			this.viewAllTree = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button4 = new System.Windows.Forms.Button();
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
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(565, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(92, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Открыть";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.Location = new System.Drawing.Point(12, 415);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Обновить";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// listBox1
			// 
			this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(794, 14);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(243, 329);
			this.listBox1.TabIndex = 6;
			// 
			// forvard
			// 
			this.forvard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.forvard.Location = new System.Drawing.Point(766, 415);
			this.forvard.Name = "forvard";
			this.forvard.Size = new System.Drawing.Size(75, 23);
			this.forvard.TabIndex = 7;
			this.forvard.Text = "Назад";
			this.forvard.UseVisualStyleBackColor = true;
			this.forvard.Click += new System.EventHandler(this.Forvard_Click);
			// 
			// next
			// 
			this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.next.Location = new System.Drawing.Point(847, 415);
			this.next.Name = "next";
			this.next.Size = new System.Drawing.Size(75, 23);
			this.next.TabIndex = 8;
			this.next.Text = "Вперед";
			this.next.UseVisualStyleBackColor = true;
			this.next.Click += new System.EventHandler(this.Next_Click);
			// 
			// button7
			// 
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button7.Location = new System.Drawing.Point(953, 349);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 9;
			this.button7.Text = "Удалить";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(663, 12);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(92, 23);
			this.button8.TabIndex = 10;
			this.button8.Text = "Сохранить";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8_Click);
			// 
			// textBoxSteep
			// 
			this.textBoxSteep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSteep.Location = new System.Drawing.Point(928, 415);
			this.textBoxSteep.Name = "textBoxSteep";
			this.textBoxSteep.Size = new System.Drawing.Size(100, 20);
			this.textBoxSteep.TabIndex = 11;
			this.textBoxSteep.TextChanged += new System.EventHandler(this.TextBoxSteep_TextChanged);
			// 
			// viewAllTree
			// 
			this.viewAllTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.viewAllTree.Location = new System.Drawing.Point(94, 415);
			this.viewAllTree.Name = "viewAllTree";
			this.viewAllTree.Size = new System.Drawing.Size(250, 23);
			this.viewAllTree.TabIndex = 12;
			this.viewAllTree.Text = "Показать все предложение деревом";
			this.viewAllTree.UseVisualStyleBackColor = true;
			this.viewAllTree.Click += new System.EventHandler(this.viewAllTree_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar1.Location = new System.Drawing.Point(364, 415);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(391, 23);
			this.progressBar1.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.Location = new System.Drawing.Point(797, 349);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(150, 60);
			this.button4.TabIndex = 14;
			this.button4.Text = "Простроитель связей";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1040, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.viewAllTree);
			this.Controls.Add(this.textBoxSteep);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.next);
			this.Controls.Add(this.forvard);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.init);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "CoNLL-UМ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button init;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button forvard;
		private System.Windows.Forms.Button next;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.TextBox textBoxSteep;
		private System.Windows.Forms.Button viewAllTree;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button4;
	}
}

