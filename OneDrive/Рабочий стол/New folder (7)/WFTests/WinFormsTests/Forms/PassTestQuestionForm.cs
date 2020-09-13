using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class PassTestQuestionForm : Form
	{
		public PassTestQuestionForm(TestQuestion question)
		{
			InitializeComponent();

			Question.Text = question.Text;

			foreach (var q in question.Answers) 
				Answers.Items.Add(q);
		}

		public int[] AnswerIndices = null;

		private void Pass_Click(object sender, EventArgs e)
		{
			var result = new List<int>();

			foreach (int i in Answers.CheckedIndices)
				result.Add(i);

			AnswerIndices = result.ToArray();

			Close();
		}
	}
}
