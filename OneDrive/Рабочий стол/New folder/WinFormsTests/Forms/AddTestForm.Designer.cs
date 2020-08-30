namespace WinFormsTests.Forms
{
	partial class AddTestForm
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
			this.TestTree = new System.Windows.Forms.TreeView();
			this.AddSubTest = new System.Windows.Forms.Button();
			this.TestName = new System.Windows.Forms.TextBox();
			this.SaveTest = new System.Windows.Forms.Button();
			this.AddQuestion = new System.Windows.Forms.Button();
			this.SubTestName = new System.Windows.Forms.TextBox();
			this.TestTime = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.DeleteNode = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.TestTime)).BeginInit();
			this.SuspendLayout();
			// 
			// TestTree
			// 
			this.TestTree.Location = new System.Drawing.Point(0, 0);
			this.TestTree.Name = "TestTree";
			this.TestTree.Size = new System.Drawing.Size(346, 450);
			this.TestTree.TabIndex = 0;
			this.TestTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TestTree_AfterSelect);
			// 
			// AddSubTest
			// 
			this.AddSubTest.Location = new System.Drawing.Point(352, 38);
			this.AddSubTest.Name = "AddSubTest";
			this.AddSubTest.Size = new System.Drawing.Size(436, 23);
			this.AddSubTest.TabIndex = 1;
			this.AddSubTest.Text = "Добавить подтест";
			this.AddSubTest.UseVisualStyleBackColor = true;
			this.AddSubTest.Click += new System.EventHandler(this.AddSubTest_Click);
			// 
			// TestName
			// 
			this.TestName.Location = new System.Drawing.Point(601, 363);
			this.TestName.Name = "TestName";
			this.TestName.Size = new System.Drawing.Size(187, 20);
			this.TestName.TabIndex = 2;
			// 
			// SaveTest
			// 
			this.SaveTest.Location = new System.Drawing.Point(352, 415);
			this.SaveTest.Name = "SaveTest";
			this.SaveTest.Size = new System.Drawing.Size(436, 23);
			this.SaveTest.TabIndex = 3;
			this.SaveTest.Text = "Сохранить тест";
			this.SaveTest.UseVisualStyleBackColor = true;
			this.SaveTest.Click += new System.EventHandler(this.SaveTest_Click);
			// 
			// AddQuestion
			// 
			this.AddQuestion.Location = new System.Drawing.Point(352, 83);
			this.AddQuestion.Name = "AddQuestion";
			this.AddQuestion.Size = new System.Drawing.Size(436, 23);
			this.AddQuestion.TabIndex = 4;
			this.AddQuestion.Text = "Добавить вопрос в выбраный подтест";
			this.AddQuestion.UseVisualStyleBackColor = true;
			this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
			// 
			// SubTestName
			// 
			this.SubTestName.Location = new System.Drawing.Point(352, 12);
			this.SubTestName.Name = "SubTestName";
			this.SubTestName.Size = new System.Drawing.Size(436, 20);
			this.SubTestName.TabIndex = 5;
			// 
			// TestTime
			// 
			this.TestTime.Location = new System.Drawing.Point(601, 389);
			this.TestTime.Name = "TestTime";
			this.TestTime.Size = new System.Drawing.Size(187, 20);
			this.TestTime.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(352, 391);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Время на тест в минутах (0-без ограничений):";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(352, 366);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Название теста:";
			// 
			// DeleteNode
			// 
			this.DeleteNode.Location = new System.Drawing.Point(352, 160);
			this.DeleteNode.Name = "DeleteNode";
			this.DeleteNode.Size = new System.Drawing.Size(436, 23);
			this.DeleteNode.TabIndex = 9;
			this.DeleteNode.Text = "Удалить";
			this.DeleteNode.UseVisualStyleBackColor = true;
			this.DeleteNode.Click += new System.EventHandler(this.DeleteNode_Click);
			// 
			// AddTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DeleteNode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TestTime);
			this.Controls.Add(this.SubTestName);
			this.Controls.Add(this.AddQuestion);
			this.Controls.Add(this.SaveTest);
			this.Controls.Add(this.TestName);
			this.Controls.Add(this.AddSubTest);
			this.Controls.Add(this.TestTree);
			this.Name = "AddTestForm";
			this.Text = "Добавить тест";
			((System.ComponentModel.ISupportInitialize)(this.TestTime)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView TestTree;
		private System.Windows.Forms.Button AddSubTest;
		private System.Windows.Forms.TextBox TestName;
		private System.Windows.Forms.Button SaveTest;
		private System.Windows.Forms.Button AddQuestion;
		private System.Windows.Forms.TextBox SubTestName;
		private System.Windows.Forms.NumericUpDown TestTime;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button DeleteNode;
	}
}