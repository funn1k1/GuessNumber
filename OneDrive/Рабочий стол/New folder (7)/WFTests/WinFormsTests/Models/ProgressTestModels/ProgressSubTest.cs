using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
	[Serializable]
	public class ProgressSubTest
	{
		private List<PassedQuestion> _passedQuestions;

		public IReadOnlyList<PassedQuestion> PassedQuestions => _passedQuestions.AsReadOnly();

		public SubTest SubTest { get; }

		public bool SubTestPassed => CurrentQuestion == SubTest.Questions.Count;

		public int CurrentQuestion { get; private set; }

		public ProgressSubTest(SubTest subTest)
		{
			_passedQuestions = new List<PassedQuestion>();
			SubTest = subTest;
			CurrentQuestion = 0;
		}

		public Question GetQuestion()
		{
			if (CurrentQuestion == SubTest.Questions.Count)
				return null;

			return SubTest.Questions[CurrentQuestion];
		}

		public (int right, int all) GetResult()
		{
			if (!SubTestPassed)
				throw new Exception("Подподтест не пройден");

			var all = SubTest.Questions.Count;
			var right = _passedQuestions.Count( // подсчет количества правильных вопросов в подтесте, LINQ запрос
				 t =>
				 {
					 var q = t.Question;

					 if (q is OpenQuestion oc)
						 return oc.CheckAnswer(t.Answer as string) == 1;

					 return (t.Question as TestQuestion).CheckAnswer(t.Answer as int[]) == 1;
				 });

			return (right, all);
		}

		public bool CheckAnswer(object answer) // проверка ответа
		{
			if (SubTest.Questions[CurrentQuestion] is TestQuestion testQuestion) // если вопрос тестовый то ответом на него является массив индексов
			{
				if (testQuestion.CheckAnswer(answer as int[]) == -1)
					return false;

				_passedQuestions.Add(new PassedQuestion(testQuestion, answer));

				CurrentQuestion++;

				return true;
			}

			_passedQuestions.Add(new PassedQuestion(SubTest.Questions[CurrentQuestion], answer)); 

			CurrentQuestion++;

			return true;
		}

		public override string ToString()
		{
			var (right, all) = GetResult();

			var percent = (double)right / all * 100d;
			percent = Math.Round(percent, 2);

			return $"Подтест {SubTest.Name} - {percent}% правильно";
		}
	}
}