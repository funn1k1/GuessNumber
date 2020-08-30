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

				for (var i = 0; i < subTest.PassedQuestions.Count; i++)
				{
					var question = subTest.PassedQuestions[i];
					result.AppendLine($"\tВопрос {i + 1}: {(question.IsRightAnswer() ? "правильно" : "неправильно")}");
				}
			}

			Result.Text = result + ProgramData.TestContainer.GetStat();
		}
	}
}
