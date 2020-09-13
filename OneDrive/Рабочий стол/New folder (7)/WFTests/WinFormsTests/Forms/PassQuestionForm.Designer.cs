namespace WinFormsTests.Forms
{
	partial class PassQuestionForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.Answer = new System.Windows.Forms.TextBox();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ответ:";
			// 
			// Answer
			// 
			this.Answer.Location = new System.Drawing.Point(17, 63);
			this.Answer.Name = "Answer";
			this.Answer.Size = new System.Drawing.Size(771, 20);
			this.Answer.TabIndex = 2;
			// 
			// Pass
			// 
			this.Pass.Location = new System.Drawing.Point(17, 89);
			this.Pass.Name = "Pass";
			this.Pass.Size = new System.Drawing.Size(771, 23);
			this.Pass.TabIndex = 3;
			this.Pass.Text = "Ответить";
			this.Pass.UseVisualStyleBackColor = true;
			this.Pass.Click += new System.EventHandler(this.Pass_Click);
			// 
			// PassQuestionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 125);
			this.Controls.Add(this.Pass);
			this.Controls.Add(this.Answer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Question);
			this.Name = "PassQuestionForm";
			this.Text = "Открытый вопрос";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Question;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Answer;
		private System.Windows.Forms.Button Pass;
	}
}