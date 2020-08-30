using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTests.Models.ProgressTestModels;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class ResultTestForm : Form
	{
		public ResultTestForm(ProgressTest progress)
		{
			InitializeComponent();

			PrintResult(progress);
		}

		public void PrintResult(ProgressTest progress)
		{
			var result = new StringBuilder();

			result.AppendLine($"Тест - {progress.Test.Name}");
			result.AppendLine("Общий" +
									" результат: " +
									$"{progress.GetResult().right} из {progress.GetResult().all}");

			result.AppendLine("Результаты по подтестам:");

			foreach (var subTest in progress.ProgressSubTests)
			{
				result.AppendLine(
					$"Подтест {subTest.SubTest.Name} " +
					$"- {subTest.GetResult().right} из " +
					$"{subTest.GetResult().all}"
				);

				foreach (var question in subTest.PassedQuestions)
				{
					if (question.Question is OpenQuestion oq) 
						result.AppendLine($"\tОткрытый вопрос {question.Question.Text}: " +
						                  $"{(question.IsRightAnswer() ? "правильно" : "неправильно")}, " +
						                  $"один из правильных ответов - {oq.RightAnswers.First()}");
					else
					{
						var testQuestion = question.Question as TestQuestion;

						result.AppendLine($"\tТестовый вопрос {question.Question.Text}: " +
						                  $"{(question.IsRightAnswer() ? "правильно" : "неправильно")}, " +
						                  $"правильный ответ - " +
						                  $"{string.Join(", ", testQuestion.RightAnswers.Select(t => testQuestion.Answers[t]))}");
					}
				}
			}

			Result.Text = result + ProgramData.TestContainer.GetStat();
		}
	}
}
