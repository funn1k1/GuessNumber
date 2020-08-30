using System.Collections.Generic;

namespace WinFormsTests.Models.TestModels
{
    public class SubSubTest
    {
        public string Name { get; }

        private List<Question> _questions;

        public IReadOnlyList<Question> Questions => _questions.AsReadOnly();

        public SubSubTest(string name)
        {
            Name = name;
            _questions = new List<Question>();
        }

        public void AddQuestions(Question question) => _questions.Add(question);

        public override string ToString() => Name;
    }
}