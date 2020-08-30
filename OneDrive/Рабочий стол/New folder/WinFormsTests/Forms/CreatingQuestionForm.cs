using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class CreatingQuestionForm : Form
	{
		public CreatingQuestionForm()
		{
			InitializeComponent();

			_answers = new List<string>();
			_openAnswers = new List<string>();
		}

		private List<string> _answers;
		private List<string> _openAnswers;

		public Question Question { get; private set; }

		private void CreatingQuestionForm_Load(object sender, EventArgs e)
		{

		}

		private void Save_Click(object sender, EventArgs e)
		{

			if (OpenCheck.Checked)
			{
				Question = new OpenQuestion(OpenQuestionText.Text);
				var openQuestion = Question as OpenQuestion;

				foreach (var openAnswer in _openAnswers) 
					openQuestion.AddAnswer(openAnswer);
			}
			else
			{
				var rightAnswers = new List<int>();

				foreach (var checkedItem in AnswersList.CheckedItems)
				{
					var index = _answers.IndexOf((string)checkedItem);

					rightAnswers.Add(index);
				}

				Question = new TestQuestion(
					TestQuestionText.Text,
					_answers.ToArray(),
					rightAnswers.ToArray());
			}

			Close();
		}

		private void AddAnswer_Click(object sender, EventArgs e)
		{
			var text = AnswerText.Text;

			_answers.Add(text);

			AnswersList.Items.Add(text, false);
		}

		private void AddOpenAnswer_Click(object sender, EventArgs e)
		{
			var answer = OpenAnswer.Text;

			_openAnswers.Add(answer);

			ListOpenAnswers.Items.Add(answer);
		}
	}
}
