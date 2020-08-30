namespace WinFormsTests.Forms
{
	partial class EditTestsForm
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
			this.TestList = new System.Windows.Forms.ListBox();
			this.Edit = new System.Windows.Forms.Button();
			this.DeleteTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TestList
			// 
			this.TestList.FormattingEnabled = true;
			this.TestList.Location = new System.Drawing.Point(0, 0);
			this.TestList.Name = "TestList";
			this.TestList.Size = new System.Drawing.Size(555, 446);
			this.TestList.TabIndex = 0;
			this.TestList.SelectedIndexChanged += new System.EventHandler(this.TestList_SelectedIndexChanged);
			// 
			// Edit
			// 
			this.Edit.Enabled = false;
			this.Edit.Location = new System.Drawing.Point(561, 12);
			this.Edit.Name = "Edit";
			this.Edit.Size = new System.Drawing.Size(227, 23);
			this.Edit.TabIndex = 1;
			this.Edit.Text = "Редактировать выбранный тест";
			this.Edit.UseVisualStyleBackColor = true;
			this.Edit.Click += new System.EventHandler(this.Edit_Click);
			// 
			// DeleteTest
			// 
			this.DeleteTest.Enabled = false;
			this.DeleteTest.Location = new System.Drawing.Point(561, 41);
			this.DeleteTest.Name = "DeleteTest";
			this.DeleteTest.Size = new System.Drawing.Size(227, 23);
			this.DeleteTest.TabIndex = 2;
			this.DeleteTest.Text = "Удалить выбранный тест";
			this.DeleteTest.UseVisualStyleBackColor = true;
			this.DeleteTest.Click += new System.EventHandler(this.DeleteTest_Click);
			// 
			// EditTestsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteTest);
			this.Controls.Add(this.Edit);
			this.Controls.Add(this.TestList);
			this.Name = "EditTestsForm";
			this.Text = "Редактирование тестов";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox TestList;
		private System.Windows.Forms.Button Edit;
		private System.Windows.Forms.Button DeleteTest;
	}
}