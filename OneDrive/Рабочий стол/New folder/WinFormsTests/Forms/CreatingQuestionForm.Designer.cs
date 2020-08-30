namespace WinFormsTests.Forms
{
	partial class CreatingQuestionForm
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
			this.Save = new System.Windows.Forms.Button();
			this.OpenCheck = new System.Windows.Forms.RadioButton();
			this.TestCheck = new System.Windows.Forms.RadioButton();
			this.OpenQuestionText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TestQuestionText = new System.Windows.Forms.TextBox();
			this.AnswersList = new System.Windows.Forms.CheckedListBox();
			this.AnswerText = new System.Windows.Forms.TextBox();
			this.AddAnswer = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.ListOpenAnswers = new System.Windows.Forms.ListBox();
			this.AddOpenAnswer = new System.Windows.Forms.Button();
			this.OpenAnswer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(15, 400);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(776, 23);
			this.Save.TabIndex = 0;
			this.Save.Text = "Сохранить";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// OpenCheck
			// 
			this.OpenCheck.AutoSize = true;
			this.OpenCheck.Checked = true;
			this.OpenCheck.Location = new System.Drawing.Point(12, 12);
			this.OpenCheck.Name = "OpenCheck";
			this.OpenCheck.Size = new System.Drawing.Size(116, 17);
			this.OpenCheck.TabIndex = 1;
			this.OpenCheck.TabStop = true;
			this.OpenCheck.Text = "Открытый вопрос";
			this.OpenCheck.UseVisualStyleBackColor = true;
			// 
			// TestCheck
			// 
			this.TestCheck.AutoSize = true;
			this.TestCheck.Location = new System.Drawing.Point(15, 185);
			this.TestCheck.Name = "TestCheck";
			this.TestCheck.Size = new System.Drawing.Size(114, 17);
			this.TestCheck.TabIndex = 2;
			this.TestCheck.Text = "Тестовый вопрос";
			this.TestCheck.UseVisualStyleBackColor = true;
			// 
			// OpenQuestionText
			// 
			this.OpenQuestionText.Location = new System.Drawing.Point(65, 35);
			this.OpenQuestionText.Name = "OpenQuestionText";
			this.OpenQuestionText.Size = new System.Drawing.Size(509, 20);
			this.OpenQuestionText.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Вопрос:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Вопрос:";
			// 
			// TestQuestionText
			// 
			this.TestQuestionText.Location = new System.Drawing.Point(68, 208);
			this.TestQuestionText.Name = "TestQuestionText";
			this.TestQuestionText.Size = new System.Drawing.Size(509, 20);
			this.TestQuestionText.TabIndex = 5;
			// 
			// AnswersList
			// 
			this.AnswersList.FormattingEnabled = true;
			this.AnswersList.Location = new System.Drawing.Point(18, 234);
			this.AnswersList.Name = "AnswersList";
			this.AnswersList.Size = new System.Drawing.Size(249, 154);
			this.AnswersList.TabIndex = 7;
			// 
			// AnswerText
			// 
			this.AnswerText.Location = new System.Drawing.Point(294, 262);
			this.AnswerText.Name = "AnswerText";
			this.AnswerText.Size = new System.Drawing.Size(247, 20);
			this.AnswerText.TabIndex = 8;
			// 
			// AddAnswer
			// 
			this.AddAnswer.Location = new System.Drawing.Point(294, 288);
			this.AddAnswer.Name = "AddAnswer";
			this.AddAnswer.Size = new System.Drawing.Size(247, 23);
			this.AddAnswer.TabIndex = 9;
			this.AddAnswer.Text = "Добавить ответ";
			this.AddAnswer.UseVisualStyleBackColor = true;
			this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(273, 334);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(340, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Галочкой пометьте те вопросы, которые являются правильными";
			// 
			// ListOpenAnswers
			// 
			this.ListOpenAnswers.FormattingEnabled = true;
			this.ListOpenAnswers.Location = new System.Drawing.Point(18, 61);
			this.ListOpenAnswers.Name = "ListOpenAnswers";
			this.ListOpenAnswers.Size = new System.Drawing.Size(249, 121);
			this.ListOpenAnswers.TabIndex = 11;
			// 
			// AddOpenAnswer
			// 
			this.AddOpenAnswer.Location = new System.Drawing.Point(276, 87);
			this.AddOpenAnswer.Name = "AddOpenAnswer";
			this.AddOpenAnswer.Size = new System.Drawing.Size(247, 23);
			this.AddOpenAnswer.TabIndex = 13;
			this.AddOpenAnswer.Text = "Добавить ответ";
			this.AddOpenAnswer.UseVisualStyleBackColor = true;
			this.AddOpenAnswer.Click += new System.EventHandler(this.AddOpenAnswer_Click);
			// 
			// OpenAnswer
			// 
			this.OpenAnswer.Location = new System.Drawing.Point(276, 61);
			this.OpenAnswer.Name = "OpenAnswer";
			this.OpenAnswer.Size = new System.Drawing.Size(247, 20);
			this.OpenAnswer.TabIndex = 12;
			// 
			// CreatingQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 439);
			this.Controls.Add(this.AddOpenAnswer);
			this.Controls.Add(this.OpenAnswer);
			this.Controls.Add(this.ListOpenAnswers);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddAnswer);
			this.Controls.Add(this.AnswerText);
			this.Controls.Add(this.AnswersList);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TestQuestionText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OpenQuestionText);
			this.Controls.Add(this.TestCheck);
			this.Controls.Add(this.OpenCheck);
			this.Controls.Add(this.Save);
			this.Name = "CreatingQuestionForm";
			this.Text = "Создание вопроса";
			this.Load += new System.EventHandler(this.CreatingQuestionForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.RadioButton OpenCheck;
		private System.Windows.Forms.RadioButton TestCheck;
		private System.Windows.Forms.TextBox OpenQuestionText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TestQuestionText;
		private System.Windows.Forms.CheckedListBox AnswersList;
		private System.Windows.Forms.TextBox AnswerText;
		private System.Windows.Forms.Button AddAnswer;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox ListOpenAnswers;
		private System.Windows.Forms.Button AddOpenAnswer;
		private System.Windows.Forms.TextBox OpenAnswer;
	}
}