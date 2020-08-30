using System;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
	[Serializable]
	public class PassedQuestion
	{
		public Question Question { get; }

		public object Answer { get; }

		public PassedQuestion(Question question, object answer)
		{
			Question = question;
			Answer = answer;
		}

		public bool IsRightAnswer()
		{
			if (Question is OpenQuestion oc)
			{
				return oc.CheckAnswer(Answer as string) == 1;
			}

			return (Question as TestQuestion).CheckAnswer(Answer as int[]) == 1;
		}

		public override string ToString()
		{
			if (Question is OpenQuestion oc)
			{
				return oc.CheckAnswer(Answer as string) == 1 ? "правильно" : "неправильно";
			}

			return (Question as TestQuestion).CheckAnswer(Answer as int[]) == 1 ? "правильно" : "неправильно";
		}
	}
}