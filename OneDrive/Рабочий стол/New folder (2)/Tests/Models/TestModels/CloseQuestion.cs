namespace WinFormsTests.Models.TestModels
{
    public class CloseQuestion : Question
    {
        public CloseQuestion(string text) : base(text)
        {
        }

        public override int CheckAnswer(string answer) => 1;

        public override string ToString() => $"{Text}";
    }
}