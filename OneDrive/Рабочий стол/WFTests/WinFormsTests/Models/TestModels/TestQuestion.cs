using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsTests.Models.TestModels
{
	[Serializable]
	public class TestQuestion : Question
	{
		public IReadOnlyList<string> Answers => _answers.ToList().AsReadOnly();

		private int[] _rightAnswers;

		public IReadOnlyList<int> RightAnswers => _rightAnswers.ToList().AsReadOnly();

		private string[] _answers;

		public TestQuestion(string text, string[] answers, int[] rightAnswers) : base(text)
		{
			_answers = answers;
			_rightAnswers = rightAnswers;
		}

		public int CheckAnswer(int[] answer)
		{
			if (answer == null)
				return 0;

			if (new HashSet<int>(answer).SetEquals(_rightAnswers))
				return 1;

			return 0;
		}

		public override string ToString()
		{
			var stringAnswers = new List<string>();

			for (int i = 0; i < _answers.Length; i++)
				stringAnswers.Add($"{i + 1}: {_answers[i]}");

			return $"{Text}{Environment.NewLine}{String.Join(Environment.NewLine, stringAnswers)}";
		}
	}
}