using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsTests.Models.TestModels
{
	[Serializable]
	public class OpenQuestion : Question
	{
		public OpenQuestion(string text) : base(text) => _rightAnswers = new HashSet<string>();

		public void AddAnswer(string answer) => _rightAnswers.Add(answer.Trim().ToLower());

		public IReadOnlyCollection<string> RightAnswers => _rightAnswers.ToList().AsReadOnly();

		private HashSet<string> _rightAnswers;

		public int CheckAnswer(string answer)
		{
			if (answer == null)
				return 0;

			if (_rightAnswers.Any(
				rightAnswer => 
					rightAnswer == (answer.Trim().ToLower())))
				return 1;

			return 0;
		}

		public override string ToString() => $"{Text}";
	}
}