using System;

namespace WinFormsTests.Models.TestModels
{
   [Serializable]
    public class Question
    {
        public string Text { get; }

        protected Question(string text) => Text = text;
    }
}