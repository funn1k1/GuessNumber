using System;
using System.Collections.Generic;

namespace WinFormsTests.Models.TestModels
{
	[Serializable]
	public class SubTest
	{
		public string Name { get; }

		private List<Question> _questions;

		public IReadOnlyList<Question> Questions => _questions.AsReadOnly(); // ReadOnly нужен для того, чтобы из других областей программы невозможно было поменять список вопросов, тем самым случайно сломав объект
																

		public SubTest(string name)
		{
			Name = name;
			_questions = new List<Question>();
		}

		public void RemoveQuestion(int index) => _questions.RemoveAt(index);

		public void AddQuestion(Question question) => _questions.Add(question);

		public override string ToString() => Name;
	}
}