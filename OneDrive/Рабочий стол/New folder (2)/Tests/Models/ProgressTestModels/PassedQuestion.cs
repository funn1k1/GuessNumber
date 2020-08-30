using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
    public class PassedQuestion
    {
        public Question Question { get; }

        public string Answer { get; }

        public PassedQuestion(Question question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public override string ToString() => Question.CheckAnswer(Answer) == 1 ? "правильно" : "неправильно";
    }
}