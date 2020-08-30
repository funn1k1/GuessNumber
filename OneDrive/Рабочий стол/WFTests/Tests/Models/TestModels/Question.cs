namespace WinFormsTests.Models.TestModels
{
    public abstract class Question
    {
        public string Text { get; }

        protected Question(string text) => Text = text;

        public abstract int CheckAnswer(string input);
    }
}