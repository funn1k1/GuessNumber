using System;
using System.Collections.Generic;
using System.Linq;

namespace WinFormsTests.Models.TestModels
{
    public class OpenQuestion : Question
    {
        public IReadOnlyList<string> Answers => _answers.ToList().AsReadOnly();

        public int RightAnswer { get; }
        
        private string[] _answers;

        public OpenQuestion(string text, string[] answers, int rightAnswer) : base(text)
        {
            _answers = answers;
            RightAnswer = rightAnswer;
        }

        public override int CheckAnswer(string input)
        {
            if (Int32.TryParse(input, out var ans))
            {
                if (ans > _answers.Length)
                    return -1;

                return ans - 1 == RightAnswer ? 1 : 0;
            }

            return -1;
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