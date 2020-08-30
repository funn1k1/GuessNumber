namespace WinFormsTests.Forms
{
	partial class PassTestQuestionForm
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
			this.Question = new System.Windows.Forms.Label();
			this.Answers = new System.Windows.Forms.CheckedListBox();
			this.Pass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Question
			// 
			this.Question.AutoSize = true;
			this.Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Question.Location = new System.Drawing.Point(12, 9);
			this.Question.Name = "Question";
			this.Question.Size = new System.Drawing.Size(78, 25);
			this.Question.TabIndex = 0;
			this.Question.Text = "Вопрос";
			// 
			// Answers
			// 
			this.Answers.FormattingEnabled = true;
			this.Answers.Location = new System.Drawing.Point(17, 55);
			this.Answers.Name = "Answers";
			this.Answers.Size = new System.Drawing.Size(771, 319);
			this.Answers.TabIndex = 1;
			// 
			// Pass
			// 
			this.Pass.Location = new System.Drawing.Point(17, 380);
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(771, 23);
			this.Pass.TabIndex = 2;
			this.Pass.Text = "Ответить";
			this.Pass.UseVisualStyleBackColor = true;
			this.Pass.Click += new System.EventHandler(this.Pass_Click);
			// 
			// PassTestQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 412);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.Answers);
			this.Controls.Add(this.Question);
			this.Name = "PassTestQuestionForm";
			this.Text = "Тестовый вопрос";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Question;
		private System.Windows.Forms.CheckedListBox Answers;
		private System.Windows.Forms.Button Pass;
	}
}