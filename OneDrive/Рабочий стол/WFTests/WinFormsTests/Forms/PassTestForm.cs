using System;
using System.Threading;
using System.Windows.Forms;
using WinFormsTests.Models.ProgressTestModels;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Forms
{
	public partial class PassTestForm : Form
	{
		public PassTestForm()
		{
			InitializeComponent();

			foreach (var test in ProgramData.TestContainer.Tests)
				TestList.Items.Add($"{test.Name}");
		}

		private void TestList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (TestList.SelectedIndex != -1)
				PassTest.Enabled = true;
			else
				PassTest.Enabled = false;
		}

		private bool _isTestCanceled = false;
		private bool _isTestPassed = false;

		private void PassTest_Click(object sender, EventArgs e)
		{
			_isTestCanceled = false;
			_isTestPassed = false;

			var testIndex = TestList.SelectedIndex;

			var test = ProgramData.TestContainer.Tests[testIndex];

			if (test.Time != null) // если есть ограничение по времени
			{
				MessageBox.Show($"Для прохождения теста Вам дано {test.Time.Value.Minutes} минут");

				(new Thread(() => // создаем новый поток исполнения кода, который будет обновлять таймер
				{
					var startTime = DateTime.Now; // берем текущее время

					while (true) 
					{
						if (_isTestPassed) // если тест уже пройден, время обновлять не нужно
							break;

						if (DateTime.Now - startTime > test.Time) // если время закончилось, то выводим сообщение
						{
							_isTestCanceled = true;
							MessageBox.Show("Вы не успели сдать тест вовремя");
							break;
						}

						BeginInvoke(new Action(() => // обновляем надпись со временем, это
                                   // нужно делать через BeginInvoke, так как через
                                   // другой поток в WF запрещено изменять UI 
						{
							var time = DateTime.Now - startTime; // измеряем пройденное время

							TimeLabel.Text = $"Время: {time.Hours}:{time.Minutes}:{time.Seconds}"; // выводим
						}));

						Thread.Sleep(900); // усыпляем поток на 900мс чтобы не было постоянной нагрузки на UI поток
					}

					
				})).Start(); // стартуем новый поток
			}

			var progressTest = new ProgressTest(test);

			while (progressTest.GetSubTest() != null) // дальше идет прохождение теста, заходим циклами в каждый подтест, а в нем в каждый вопрос
			{
				var subTest = progressTest.GetSubTest();

				while (subTest.GetQuestion() != null) // захождение в каждый вопрос в данном подтесте
				{
					var question = subTest.GetQuestion();

					if (question is OpenQuestion openQuestion)
					{
						var form = new PassQuestionForm(openQuestion);
						form.ShowDialog();

						var answer = form.Ans;

						subTest.CheckAnswer(answer);
					}
					else
					{
						var testQuestion = question as TestQuestion;

						var form = new PassTestQuestionForm(testQuestion);
						form.ShowDialog();

						var answer = form.AnswerIndices;

						subTest.CheckAnswer(answer);
					}

					if (_isTestCanceled) // если тест отменен, т.е. время на прохождение закончилось, то выводить результат не нужно
						return;
				}

				progressTest.CheckSubTest(subTest);
			}

			_isTestPassed = true; // флаг для того чтобы остановить поток, который обновляет время, после прохождения теста
			ProgramData.TestContainer.AddPassedTest(progressTest);

			(new ResultTestForm(progressTest)).ShowDialog(); // показываем форму с результатами
		}
	}
}
