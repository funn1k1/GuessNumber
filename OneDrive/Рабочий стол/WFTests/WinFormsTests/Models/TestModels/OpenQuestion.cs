using System;

namespace WinFormsTests.Models.TestModels
{
   [Serializable]
    public class OpenQuestion : Question
    {
        public OpenQuestion(string text) : base(text)
        {
        }

        public int CheckAnswer(string answer) => answer == null ? 0 : 1;

        public override string ToString() => $"{Text}";
    }
}