using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsTests.Models.TestModels;

namespace WinFormsTests.Models.ProgressTestModels
{
    public class ProgressSubSubTest
    {
        private List<PassedQuestion> _passedQuestions;

        public IReadOnlyList<PassedQuestion> PassedQuestions => _passedQuestions.AsReadOnly();

        public SubSubTest SubSubTest { get; }

        public bool SubSubTestPassed => CurrentQuestion == SubSubTest.Questions.Count;

        public int CurrentQuestion { get; private set; }

        public ProgressSubSubTest(SubSubTest subSubTest)
        {
            _passedQuestions = new List<PassedQuestion>();
            SubSubTest = subSubTest;
            CurrentQuestion = 0;
        }

        public Question GetQuestion()
        {
            if (CurrentQuestion == SubSubTest.Questions.Count)
                return null;

            return SubSubTest.Questions[CurrentQuestion];
        }

        public (int right, int all) GetResult()
        {
            if (!SubSubTestPassed)
                throw new Exception("Подподтест не пройден");
            
            var all = SubSubTest.Questions.Count;
            var right = _passedQuestions.Count(
                t => t.Question.CheckAnswer(t.Answer) == 1);

            return (all, right);
        }

        public bool CheckAnswer(string answer)
        {
            if (SubSubTest.Questions[CurrentQuestion] is OpenQuestion openQuestion)
            {
                if (openQuestion.CheckAnswer(answer) == -1)
                    return false;

                _passedQuestions.Add(new PassedQuestion(openQuestion, answer));

                CurrentQuestion++;

                return true;
            }
            else
            {
                _passedQuestions.Add(new PassedQuestion(SubSubTest.Questions[CurrentQuestion], answer));

                CurrentQuestion++;

                return true;
            }
        }

        public override string ToString()
        {
            var (right, all) = GetResult();
            
            var percent = (double) right / all * 100d;
            percent = Math.Round(percent, 2);

            return $"Подподтест {SubSubTest.Name} - {percent}% правильно";
        }
    }
}