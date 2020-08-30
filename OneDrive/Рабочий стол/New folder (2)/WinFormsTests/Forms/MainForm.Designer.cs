namespace WinFormsTests.Forms
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
			this.AddTest = new System.Windows.Forms.Button();
			this.PassTest = new System.Windows.Forms.Button();
			this.EditTests = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// AddTest
			// 
			this.AddTest.Location = new System.Drawing.Point(12, 12);
			this.AddTest.Name = "AddTest";
			this.AddTest.Size = new System.Drawing.Size(208, 23);
			this.AddTest.TabIndex = 0;
			this.AddTest.Text = "Добавить тест";
			this.AddTest.UseVisualStyleBackColor = true;
			this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
			// 
			// PassTest
			// 
			this.PassTest.Location = new System.Drawing.Point(12, 41);
			this.PassTest.Name = "PassTest";
			this.PassTest.Size = new System.Drawing.Size(208, 23);
			this.PassTest.TabIndex = 1;
			this.PassTest.Text = "Пройти тест";
			this.PassTest.UseVisualStyleBackColor = true;
			this.PassTest.Click += new System.EventHandler(this.PassTest_Click);
			// 
			// EditTests
			// 
			this.EditTests.Location = new System.Drawing.Point(12, 70);
			this.EditTests.Name = "EditTests";
			this.EditTests.Size = new System.Drawing.Size(208, 23);
			this.EditTests.TabIndex = 2;
			this.EditTests.Text = "Редактировать тесты";
			this.EditTests.UseVisualStyleBackColor = true;
			this.EditTests.Click += new System.EventHandler(this.EditTests_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(239, 107);
			this.Controls.Add(this.EditTests);
			this.Controls.Add(this.PassTest);
			this.Controls.Add(this.AddTest);
			this.Name = "MainForm";
			this.Text = "Основное меню";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button AddTest;
		private System.Windows.Forms.Button PassTest;
		private System.Windows.Forms.Button EditTests;
	}
}